using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace pj01_myproject
{
    public partial class Mainprogram : MetroForm
    {
        private string loginUserId;

        public Mainprogram(string loginUserId) //string loginUserId
        {
            InitializeComponent();

            this.loginUserId = loginUserId; // 로그인한 아이디를 저장
        }

        //private bool CheckPassword(string password)
        //{
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
        //        {
        //            conn.Open();

        //            string query = @"SELECT username
        //                          , userid
        //                          , userphone
        //                          , useremail
        //                          , gender
        //                       FROM signup 
        //                      WHERE userid = @userid
        //                        AND userpwd = @userpwd";

        //            SqlCommand cmd = new SqlCommand(query, conn);
        //            cmd.Parameters.AddWithValue("@userid", loginUserId);
        //            cmd.Parameters.AddWithValue("@userpwd", password);
        //            cmd.Parameters.AddWithValue("@username", Txt_InfoName.Text);

        //            SqlDataAdapter adapter = new SqlDataAdapter();
        //            adapter.SelectCommand = cmd;

        //            DataTable dt = new DataTable();
        //            adapter.Fill(dt);

        //            Dgv_show.DataSource = dt;

        //            return true; // 비밀번호가 확인되면 true 반환
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false; // 오류 발생 시 false 반환
        //    }
        //}


        #region '창닫기'
        // 창닫기 이벤트핸들러
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        // 정보조회버튼
        private void Btn_ShowInfo_Click(object sender, EventArgs e)
        {
            using (var pwdchek = new PwdCheck())
            {
                var result = pwdchek.ShowDialog();  // 비밀번호 확인창

                if (result == DialogResult.OK)
                {
                    string insertpwd = pwdchek.Pwd; // 입력된 비밀번호를 가져옴

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                        {
                            conn.Open();

                            // 비밀번호는 표시하지 않음
                            string query = @"SELECT username
                                                  , userid
                                                  , userphone
                                                  , useremail
                                                  , gender
                                               FROM signup 
                                              WHERE userid = @userid
                                                AND userpwd = @userpwd";

                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@userid", loginUserId);
                            cmd.Parameters.AddWithValue("@userpwd", insertpwd);
                            cmd.Parameters.AddWithValue("@username", Txt_InfoName.Text);
                            //cmd.Parameters.AddWithValue("@userid", Txt_InfoId.Text);

                            SqlDataAdapter adapter = new SqlDataAdapter();
                            adapter.SelectCommand = cmd;

                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // 데이터테이블 초기화
                            Dgv_show.DataSource = null;
                            Dgv_show.Rows.Clear();
                            Dgv_show.Columns.Clear();

                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.Read())
                            {
                                //DataTable dt = new DataTable();
                                //dt.Load(reader);

                                Dgv_show.DataSource = dt;

                                MessageBox.Show("비밀번호가 확인되었습니다\n회원정보를 조회합니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("비밀번호가 일치하지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("비밀번호 입력이 취소되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 회원탈퇴
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show(this, "정말 삭제하시겠습니까?", "삭제여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();
                var query = @"DELETE FROM signup 
                                    WHERE userid = @userid ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmUserIdx = new SqlParameter("@userid", Txt_InfoId.Text);
                cmd.Parameters.Add(prmUserIdx);

                var result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("삭제성공!", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("삭제실패!", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 창을 열었을 때
        private void Mainprogram_Load(object sender, EventArgs e)
        {
            Txt_InfoId.ReadOnly = true;
            Txt_InfoName.ReadOnly = true;

            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();
                var query = @"SELECT username
                                   , userid 
                                FROM signup 
                               WHERE userid = @userid";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userid", loginUserId);

                // DB에서 사용자 정보를 가져와서 텍스트박스에 연결
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Txt_InfoName.Text = reader["username"].ToString();
                    Txt_InfoId.Text = reader["userid"].ToString();
                }
                else
                {
                    MessageBox.Show("사용자 정보를 가져올 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}