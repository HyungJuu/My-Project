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
        InfoUpdate infoUpdate = null;
        private string loginUserId;

        public Mainprogram(string loginUserId)
        {
            InitializeComponent();

            this.loginUserId = loginUserId; // 로그인한 아이디를 저장
        }

        // 비밀번호 확인
        private bool CheckPassword(string userpwd)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();

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
                    cmd.Parameters.AddWithValue("@userpwd", userpwd);
                    //cmd.Parameters.AddWithValue("@username", Txt_InfoName.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    Dgv_show.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        return true; // 비밀번호가 맞으면 true
                    }
                    else
                    {
                        return false; // 비밀번호가 틀리면 false
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // 오류 발생 시 false 반환
            }
        }

        // 정보조회버튼
        private void Btn_ShowInfo_Click(object sender, EventArgs e)
        {
            using (var pwdCheck = new PwdCheck())
            {
                var result = pwdCheck.ShowDialog();  // 비밀번호 확인창

                if (result == DialogResult.OK)
                {
                    string insertPwd = pwdCheck.Pwd; // 입력된 비밀번호를 가져옴
                    if (CheckPassword(insertPwd))
                    {
                        MessageBox.Show("비밀번호가 확인되었습니다\n회원정보를 조회합니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 일치하지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("비밀번호 입력이 취소되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 회원탈퇴버튼 이벤트핸들러
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            using (var pwdCheck = new PwdCheck())
            {
                var result = pwdCheck.ShowDialog();  // 비밀번호 확인창

                if (result == DialogResult.OK)
                {
                    string insertPwd = pwdCheck.Pwd; // 입력된 비밀번호를 가져옴

                    if (CheckPassword(insertPwd))
                    {
                        MessageBox.Show("비밀번호가 확인되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InfoDelete(); // 비밀번호 확인 시 삭제여부 질문 -> 삭제|취소 기능 메서드 호출
                        Environment.Exit(0);
                        //// 회원 탈퇴 후 로그인 창으로 이동.. 하고싶었는데.. 종료누르면 종료확인창 또 두번뜸
                        //this.Hide();
                        //SignIN signin = new SignIN();
                        //signin.FormClosed += (s, args) => this.Hide();
                        //signin.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 일치하지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("비밀번호 입력이 취소되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 회원정보 삭제
        private void InfoDelete()
        {
            var answer = MessageBox.Show(this, "정말 삭제하시겠습니까?", "삭제여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();
                var query = @"DELETE FROM signup 
                                    WHERE userid = @userid ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmUserIdx = new SqlParameter("@userid", loginUserId);
                cmd.Parameters.Add(prmUserIdx);

                var result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("삭제성공!", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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

        #region '창닫기'
        // 창닫기 이벤트핸들러
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        // 회원정보 수정버튼 이벤트핸들러
        private void Btn_ModifyInfo_Click(object sender, EventArgs e)
        {
            infoUpdate = ShowActiveForm(infoUpdate, typeof(InfoUpdate)) as InfoUpdate;
        }

        private InfoUpdate ShowActiveForm(InfoUpdate infoUpdate, Type type)
        {
            if (infoUpdate == null)
            {
                infoUpdate = Activator.CreateInstance(type) as InfoUpdate;
                infoUpdate.MdiParent = this; // 자식창의 부모는 FrmMain
                infoUpdate.WindowState = FormWindowState.Normal;
                infoUpdate.Show();
            }
            else
            {
                if (infoUpdate.IsDisposed) // 창이 한번 닫혔으면
                {
                    infoUpdate = Activator.CreateInstance(type) as InfoUpdate;
                    infoUpdate.MdiParent = this; // 자식창의 부모는 FrmMain
                    infoUpdate.WindowState = FormWindowState.Normal;
                    infoUpdate.Show();
                }
                else // 창을 최소화, 열려있으면
                {
                    infoUpdate.Activate();
                }
            }
            return infoUpdate;
        }
        
    }
}