using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace pj01_myproject
{
    public partial class InfoUpdate : MetroForm
    {
        private string loginUserId;
        private string gender;

        //public InfoUpdate(string loginUserId)
        //{
        //    InitializeComponent();
        //    this.loginUserId = loginUserId; // 로그인한 아이디를 저장
        //    LoadUserInfo(); // 사용자 정보를 불러와서 텍스트 상자에 표시
        //}

        public InfoUpdate(string loginUserId)
        {
            InitializeComponent();
            this.loginUserId = loginUserId; // 로그인한 아이디를 저장
            LoadUserInfo(); // 사용자 정보를 불러와서 텍스트 상자에 표시
        }

        // 사용자정보를 불러와서 텍스트 상자에 표시하는 메서드
        private void LoadUserInfo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();

                    string query = @"SELECT username
                                          , userid
                                          , userpwd
                                          , userphone
                                          , useremail
                                          , gender
                                     FROM signup
                                    WHERE userid = @userid";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userid", loginUserId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Txt_UserName.Text = reader["username"].ToString(); // 각 텍스트박스에 해당 정보를 보여줌
                        Txt_UserId.Text = reader["userid"].ToString();
                        Txt_UserId.ReadOnly = true; // 아이디는 변경불가능하도록
                        Txt_UserPwd.Text = reader["userpwd"].ToString();
                        Txt_userPhone.Text = reader["userphone"].ToString();
                        Txt_UserEmail.Text = reader["useremail"].ToString();

                        // 성별에 따라 체크박스 선택설정
                        string gender = reader["gender"].ToString();
                        if (gender == "여")
                            Chk_Woman.Checked = true;
                        else if (gender == "남")
                            Chk_Man.Checked = true;
                        else
                            Chk_None.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("사용자 정보를 불러올 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 회원정보 수정 버튼 클릭 이벤트
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            string username = Txt_UserName.Text;
            string userpwd = Txt_UserPwd.Text;
            string userphone = Txt_userPhone.Text;
            string useremail = Txt_UserEmail.Text;
            string gender = this.gender;

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();

                    string query = @"UPDATE signup 
                                        SET username = @username,
                                            userpwd = @userpwd,
                                            userphone = @userphone,
                                            useremail = @useremail,
                                            gender = @gender
                                      WHERE userid = @userid";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@userpwd", userpwd);
                    cmd.Parameters.AddWithValue("@userphone", userphone);
                    cmd.Parameters.AddWithValue("@useremail", useremail);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@userid", loginUserId);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("회원정보가 수정되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("회원정보 수정에 실패했습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL 오류 발생: " + ex.Message, "SQL 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 취소 버튼 클릭 이벤트
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region '성별 선택'
        // 성별(여)체크박스
        private void Chk_Woman_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Woman.Checked) // 성별 : 여 선택 -> true 값
            {
                // 선택하지 않은 성별은 중복체크가 안되도록 false 처리
                Chk_Man.Checked = false;
                Chk_None.Checked = false;
                gender = "여";
            }
            else
            {
                gender = ""; // 선택을 취소하면 gender 값을 초기화
            }
        }

        // 성별(남)체크박스
        private void Chk_Man_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Man.Checked)
            {
                Chk_Woman.Checked = false;
                Chk_None.Checked = false;
                gender = "남";
            }
            else
            {
                gender = "";
            }
        }

        // 성별(선택안함)체크박스
        private void Chk_None_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_None.Checked)
            {
                Chk_Woman.Checked = false;
                Chk_Man.Checked = false;
                gender = "선택안함";
            }
            else
            {
                gender = "";
            }
        }

        #endregion

        // 비밀번호 표시유무
        private void Chk_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Show.Checked)
                Txt_UserPwd.PasswordChar = '\0';
            else
                Txt_UserPwd.PasswordChar = '●';
        }
    }
}
