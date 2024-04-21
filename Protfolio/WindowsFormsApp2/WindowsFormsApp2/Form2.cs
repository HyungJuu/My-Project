using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("아이디 입력하세요");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("비밀번호 입력하세요");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("이름 입력하세요");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=master;User ID=sa;Password=mssql_p@ss;Encrypt=False");
                    con.Open(); // 데이터베이스 연결 열기

                    SqlCommand cmd = new SqlCommand("INSERT INTO signin (id, pw, name) VALUES (@id, @pw, @name)", con);
                    cmd.Parameters.AddWithValue("@id", textBox3.Text);
                    cmd.Parameters.AddWithValue("@pw", textBox4.Text);
                    cmd.Parameters.AddWithValue("@name", textBox5.Text);

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd; // SelectCommand 속성 초기화

                    DataTable dt = new DataTable();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    da.Fill(dt);
                    con.Close(); // 데이터베이스 연결 열기
                                 // 쿼리 실행

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("성공");

                    }
                    else
                    {
                        MessageBox.Show("실패");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            /*try
            {
                // 데이터베이스 연결 문자열
                string connectionString = "Data Source=localhost;Initial Catalog=master;User ID=sa;Password=mssql_p@ss;Encrypt=False";

                // SQL 쿼리문
                string query = "INSERT INTO signin (id, pw, name) VALUES (@id, @pw, @name)";

                // 데이터베이스 연결 객체 생성
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // 연결 열기
                    con.Open();

                    // SQL 쿼리 실행을 위한 Command 객체 생성
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // 매개변수 설정
                        cmd.Parameters.AddWithValue("@id", textBox3.Text);
                        cmd.Parameters.AddWithValue("@pw", textBox4.Text);
                        cmd.Parameters.AddWithValue("@name", textBox5.Text);

                        // 쿼리 실행
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // 쿼리 결과 확인 후 메시지 출력
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("회원가입이 완료되었습니다.");
                        }
                        else
                        {
                            MessageBox.Show("회원가입에 실패했습니다.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }*/
        }
    }
}