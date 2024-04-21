using MetroFramework.Forms;
using System.Windows.Forms;

namespace My_project
{
    public partial class Login : MetroForm
    {
        #region '생성자 초기화 영역'

        public Login()
        {
            InitializeComponent();
        }
        #endregion

        // #region '이벤트핸들러 영역'

        // 아이디 입력 이벤트핸들러
        private void Txt_Id_TextChanged(object sender, EventArgs e)
        {

        }

        // 비밀번호 입력 이벤트핸들러
        private void Txt_Pwd_TextChanged(object sender, EventArgs e)
        {

        }

        // 로그인 버튼클릭 이벤트핸들러
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Form mainform = new Form();
            mainform.ShowDialog();
            mainform.Hide();
        }

        #region '입력초기화'
        // 입력초기화버튼 이벤트핸들러
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Username.Clear();
            Txt_Password.Clear();

            Txt_Username.Focus();
        }
        #endregion

        #region '창닫기 관련 이벤트핸들러'
        // 창닫기버튼 이벤트핸들러
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Environment.Exit(0);
        }

        // 창을 닫을시 종료여부 질문창
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("정말 종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) e.Cancel = true;
        }
        #endregion

        #region '회원가입'
        // 회원가입버튼
        private void Btn_signup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.FormClosed += (s, args) => this.Show();
            signup.Show();
            this.Hide();
        }
        #endregion

        // 필요없어짐
        #region '창 이동'

        // 창 이동
        bool TagMove;
        int MValX, MValY;

        private void hidePanel1_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void hidePanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TagMove == true)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void hidePanel1_MouseUp(object sender, MouseEventArgs e)
        {
            TagMove = false;
        }
        #endregion

        #region '비밀번호 표시유무'
        // 비밀번호 표시 이벤트핸들러
        private void ChkShow_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ChkShow.Checked)
            {
                Txt_Password.PasswordChar = '\0';
            }
            else
            {
                Txt_Password.PasswordChar = '●';
            }
        }
 
        #endregion

        #region '엔터키로 이동'
        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 13 : 엔터키
            {
                Btn_Login_Click(sender, e);
            }
        }

        private void Txt_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Txt_Password.Focus();
            }
        }
        #endregion

    }
}
