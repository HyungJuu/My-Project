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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("아이디 입력하세요");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("비밀번호 입력하세요");
            }

            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=master;User ID=sa;Password=mssql_p@ss;Encrypt=False");
                    con.Open(); // 데이터베이스 연결 열기

                    SqlCommand cmd = new SqlCommand("select * from signin where id=@id and pw=@pw", con);
                    cmd.Parameters.AddWithValue("@id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@pw", textBox2.Text);

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd; // SelectCommand 속성 초기화

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close(); // 데이터베이스 연결 열기


                    if (dt.Rows.Count > 0)
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 mainform = new Form2();
            mainform.ShowDialog();
            mainform.Hide();
        }
    }
}