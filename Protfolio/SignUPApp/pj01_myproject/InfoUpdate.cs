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

        public InfoUpdate(string loginUserId)
        {
            InitializeComponent();
            this.loginUserId = loginUserId; // 로그인한 아이디를 저장
        }

        // 회원정보 수정 버튼 클릭 이벤트
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            string username = Txt_UserName.Text;
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
                                         userphone = @userphone,
                                         useremail = @useremail,
                                         gender = @gender
                                   WHERE userid = @userid";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
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

        // 성별 선택 이벤트
        private void Chk_Gender_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Woman.Checked)
            {
                Chk_Man.Checked = false;
                gender = "여";
            }
            else if (Chk_Man.Checked)
            {
                Chk_Woman.Checked = false;
                gender = "남";
            }
            else
            {
                gender = "";
            }
        }
    }
}
