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
        //InfoUpdate infoUpdate = null;
        private string loginUserId;
        private DateTime selectedDate;

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
                    Dgv_show.Columns[0].HeaderText = "이름";
                    Dgv_show.Columns[1].HeaderText = "아이디";
                    Dgv_show.Columns[2].HeaderText = "전화번호";
                    Dgv_show.Columns[3].HeaderText = "이메일";
                    Dgv_show.Columns[4].HeaderText = "성별";

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
                        //MessageBox.Show("비밀번호가 확인되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InfoDelete(); // 비밀번호 확인 시 삭제여부 질문 -> 삭제|취소 기능 메서드 호출
                        //Environment.Exit(0);
                        //// 회원 탈퇴 후 로그인 창으로 이동.. 하고싶었는데.. 종료누르면 종료확인창 또 두번뜸 -> 구현 완료
                        //this.Hide();
                        //SignIN signin = new SignIN();
                        ////signin.FormClosed += (s, args) => this.Hide();
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

        #region '회원정보 삭제여부'
        private void InfoDelete()
        {
            var answer = MessageBox.Show(this, "비밀번호를 확인하였습니다\n정말 삭제하시겠습니까?", "삭제여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();
                // 해당아이디의 정보와 메모들 모두 삭제
                var query = @"DELETE FROM signup
                                    WHERE userid = @userid
                              DELETE FROM Textmemo
                                    WHERE userid = @userid";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmUserIdx = new SqlParameter("@userid", loginUserId);
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
            this.Hide();
            SignIN signin = new SignIN();
            signin.ShowDialog();

        }
        #endregion

        // 창을 열었을 때
        private void Mainprogram_Load(object sender, EventArgs e)
        {
            Txt_InfoId.ReadOnly = true;
            Txt_InfoName.ReadOnly = true;
            Txt_InputMemo.Text = null;

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

        // 창닫기 이벤트핸들러
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("정말 종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes) Environment.Exit(0);

            //Application.Exit(); // 이거는 원래 물어보는 거
        }

        // 회원정보 수정버튼 이벤트핸들러
        private void Btn_ModifyInfo_Click(object sender, EventArgs e)
        {
            using (var pwdCheck = new PwdCheck())
            {
                var result = pwdCheck.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string insertPwd = pwdCheck.Pwd; // 입력된 비밀번호를 가져옴
                    if (CheckPassword(insertPwd)) // 비밀번호가 일치하면 정보수정 폼을 보여줌
                    {
                        MessageBox.Show("비밀번호가 확인되었습니다\n회원정보를 조회합니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InfoUpdate infoUpdate = new InfoUpdate(Txt_InfoId.Text);
                        //infoUpdate.FormClosed += (s, args) => this.Show();
                        infoUpdate.TopMost = true;
                        infoUpdate.ShowDialog();
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

        // 달력 날짜선택 이벤트핸들러
        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate = Calendar.SelectionStart;
            // 선택된 날짜를 텍스트박스에 표시
            Txt_SelectedSaveDate.Text = selectedDate.ToShortDateString();
            Txt_SelectedSaveDate.ReadOnly = true; // 날짜 텍스트박스를 수정할 수 없도록
            Txt_OutputMemo.ReadOnly = true;

            LoadMemo();
        }

        // 저장된 메모를 불러옴
        private void LoadMemo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();

                    string query = @"SELECT usermemo
                                       FROM Textmemo
                                      WHERE userid = @userid
                                        AND savedate = @savedate";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userid", loginUserId);
                    cmd.Parameters.AddWithValue("@savedate", selectedDate.Date);

                    SqlDataReader reader = cmd.ExecuteReader();

                    Txt_OutputMemo.Text = string.Empty;
                    var memo = string.Empty;

                    while (reader.Read())
                    {
                        memo += reader["usermemo"].ToString() + Environment.NewLine;
                    }
                    Txt_OutputMemo.Text = memo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 저장버튼 이벤트핸들러
        private void Btn_SaveMemo_Click(object sender, EventArgs e)
        {
            if (selectedDate == DateTime.MinValue) // 날짜를 선택하지 않았으면
            {
                MessageBox.Show("날짜를 선택해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string memoText = Txt_InputMemo.Text;
            string userId = loginUserId;
            DateTime memoDate = selectedDate.Date;

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Textmemo (userid, usermemo, savedate)
                                     VALUES (@userid, @usermemo, @savedate)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userid", userId);
                    cmd.Parameters.AddWithValue("@usermemo", memoText);
                    cmd.Parameters.AddWithValue("@savedate", memoDate);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("메모가 성공적으로 저장되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Txt_InputMemo.Text = string.Empty;
                        Txt_SelectedSaveDate.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("메모 저장에 실패했습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 로그아웃버튼 이벤트핸들러
        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("로그아웃 하시겠습니까?", "로그아웃여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                this.Hide();
                SignIN signin = new SignIN();
                signin.ShowDialog();
            }
        }
    }
}