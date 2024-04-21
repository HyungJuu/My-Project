﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace pj01_myproject
{
    public partial class Mainprogram : MetroForm
    {
        private string connString = "Data Source=localhost;" +
                                    "Initial Catalog=MemberInfo;" +
                                    "Persist Security Info=True;" +
                                    "User ID=sa;Encrypt=False;Password=mssql_p@ss";

        private string loginUserId;

       
        public Mainprogram(string loginUserId) //string loginUserId
        {
            InitializeComponent();

            this.loginUserId = loginUserId; // 로그인한 아이디를 저장
        }

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
                        using (SqlConnection conn = new SqlConnection(connString))
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

                            SqlDataAdapter adapter = new SqlDataAdapter();
                            adapter.SelectCommand = cmd;

                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // 데이터테이블 초기화
                            dataGridView1.DataSource = null;
                            dataGridView1.Rows.Clear();
                            dataGridView1.Columns.Clear();

                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.Read())
                            {
                                //DataTable dt = new DataTable();
                                //dt.Load(reader);

                                dataGridView1.DataSource = dt;

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
    }
}