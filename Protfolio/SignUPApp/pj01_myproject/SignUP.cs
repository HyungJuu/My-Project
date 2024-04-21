using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace pj01_myproject
{
    public partial class SignUP : MetroForm
    {
        private string connString = "Data Source=localhost;" +
                                    "Initial Catalog=MemberInfo;" +
                                    "Persist Security Info=True;" +
                                    "User ID=sa;Encrypt=False;Password=mssql_p@ss";

        #region '생성자 초기화 영역'

        public SignUP()
        {
            InitializeComponent();
        }
        #endregion

        #region '취소버튼'

        // 취소버튼 이벤트핸들러
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            //this.Show();
            this.Close();
        }

        #endregion

        #region '회원가입 완료버튼'

        // 완료버튼 이벤트핸들러
        private void Btn_Join_Click(object sender, EventArgs e)
        {
            bool isFail = false;
            string errMsg = string.Empty;

            if (string.IsNullOrEmpty(Txt_UserName.Text)) // 이름을 입력하지 않았을 때
            {
                isFail = true;
                errMsg += "이름을 입력하세요\n";
            }

            if (string.IsNullOrEmpty(Txt_UserId.Text)) // 아이디를 입력하지 않았을 때
            {
                isFail = true;
                errMsg += "아이디를 입력하세요\n";
            }

            if (string.IsNullOrEmpty(Txt_UserPwd.Text)) // 비밀번호를 입력하지 않았을 때
            {
                isFail = true;
                errMsg += "비밀번호를 입력하세요\n";
            }

            if (string.IsNullOrEmpty(Txt_userPhone.Text)) // 전화번호를 입력하지 않았을 때
            {
                isFail = true;
                errMsg += "전화번호를 입력하세요\n";
            }

            if (string.IsNullOrEmpty(gender)) // 성별을 입력하지 않았을 때
            {
                isFail = true;
                errMsg += "성별을 입력하세요\n";
            }

            if (isFail == true)
            {
                MessageBox.Show("(필수)\n" + errMsg, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SignUpProcess()) this.Close(); // 회원정보를 문제없이 입력했으면 회원가입창을 닫는다
        }

        #endregion


        // 회원가입 DB처리 시작
        private bool SignUpProcess()
        {
            string username = Txt_UserName.Text;
            string userid = Txt_UserId.Text;
            string userpwd = Txt_UserPwd.Text;
            string userphone = Txt_userPhone.Text;
            string useremail = Txt_UserEmail.Text;
            string gender = this.gender;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = @"INSERT INTO signup (username, userid, userpwd, userphone, useremail, gender)
                                 VALUES (@username, @userid, @userpwd, @userphone, @useremail, @gender)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlParameter prmUsreName = new SqlParameter("@username", username);
                    SqlParameter prmUserId = new SqlParameter("@userid", userid);
                    SqlParameter prmUserPwd = new SqlParameter("@userpwd", userpwd);
                    SqlParameter prmUserPhone = new SqlParameter("@userphone", userphone);
                    SqlParameter prmUserEmail = new SqlParameter("@useremail", useremail);
                    SqlParameter prmGender = new SqlParameter("@gender", gender);
                    cmd.Parameters.Add(prmUsreName);
                    cmd.Parameters.Add(prmUserId);
                    cmd.Parameters.Add(prmUserPwd);
                    cmd.Parameters.Add(prmUserPhone);
                    cmd.Parameters.Add(prmUserEmail);
                    cmd.Parameters.Add(prmGender);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("회원가입이 완료되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("회원가입에 실패했습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #region '엔터키로 넘어가기'

        // 이름 -> 아이디
        private void Txt_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Txt_UserId.Focus();
            }
        }
        
        // 아이디 -> 비밀번호
        private void Txt_UserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Txt_UserPwd.Focus();
            }
        }

        // 비밀번호 -> 전화번호
        private void Txt_UserPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Txt_userPhone.Focus();
            }
        }

        // 전화번호 -> 이메일
        private void Txt_userPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Txt_UserEmail.Focus();
            }
        }

        // 이메일 -> 완료버튼
        private void Txt_UserEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Btn_Join.Focus();
            }
        }

        #endregion

        #region '성별 선택'
        private string gender = ""; // gender의 기본값을 빈 문자열로 선언


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


    }
}
