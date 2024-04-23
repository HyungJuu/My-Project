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
using MetroFramework.Forms;

/*
 1. mssql에서 새 데이더베이스 생성 -> 데이터베이스 이름 입력하고 생성
 2. 생성한 데이터베이스 우클릭 -> 새 쿼리 선택

CREATE TABLE signup(
		username varchar(255) NOT Null,
		userid varchar(255) NOT Null,
		userpwd varchar(255) NOT Null,
		userphone int NOT Null,
		useremail varchar(255) Null
);

 -> signup이라는 테이블 생성

이미 만든 테이블에 열을 추가하고싶다면

ALTER TABLE dbo.signup
ADD gender VARCHAR(20) DEFAULT ' ' NOT NULL;

// 이미 생성된 테이블에 추가할때는 기본적으로 NULL값이 들어가기 때문에
// NULL을 허용하고싶지 않다면 디폴트값을 지정해주면서 넣어준다

 */


namespace pj01_myproject
{
    public partial class SignIN : MetroForm
    {
        private bool isLogin = false;

        public bool IsLogin
        {
            get { return isLogin; }
            set { isLogin = value; }
        }

        #region '생성자 초기화 영역'
        public SignIN()
        {
            InitializeComponent();

            Txt_UserId.Text = string.Empty;
            Txt_UserPwd.Text = string.Empty;
        }

        #endregion

        // 로그인 버튼클릭 이벤트핸들러
        private void Btn_SignIn_Click(object sender, EventArgs e)
        {
            bool isFail = false;
            string errMsg = string.Empty;   // 각 상황에 따른 문자열을 저장해서 상황에 맞춰 출력하려고 빈문자열을 선언

            if (string.IsNullOrEmpty(Txt_UserId.Text)) // 아이디를 입력하지 않았을 때
            {
                isFail = true;
                errMsg += "아이디를 입력하세요\n";
                //MessageBox.Show("아이디 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (string.IsNullOrEmpty(Txt_UserPwd.Text)) // 비밀번호를 입력하지 않았을 때
            {
                isFail = true;
                errMsg += "비밀번호를 입력하세요\n";
                //MessageBox.Show("비밀번호 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // isFail이 true가 될 때 위의 각 아이디, 비밀번호를 입력하지 않았을 때
            // errMsg에 저장된 문자열을 아래의 메시지박스 형태로 출력한다.
            if (isFail == true)
            {
                MessageBox.Show(errMsg, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IsLogin = LoginProcess();
            if (IsLogin) // 로그인에 성공하면 현재창(로그인창)을 숨기고 메인창을 연다
            {

                MessageBox.Show("로그인에 성공하였습니다", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Mainprogram mainprogram = new Mainprogram(Txt_UserId.Text);
                mainprogram.FormClosed += (s, args) => this.Hide(); // 메인폼을 닫았을 때 현재창을 숨김. Close()로 닫으려고 하니까 종료여부창이 두번출력됨
                //mainprogram.TopMost = true; // 메인폼을 가장위로 올리니까 메인폼에서 여는 창이 아래로 내려감(없어도 됨)
                mainprogram.ShowDialog();
            }

        }

        // 로그인 DB처리 시작
        private bool LoginProcess()
        {
            string userid = Txt_UserId.Text;
            string userpwd = Txt_UserPwd.Text;

            string chkUserID = string.Empty;
            string chkUserPwd = string.Empty;

            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();

                // 데이터베이스에서 아이디와 비밀번호만 찾아보도록 쿼리문 작성
                string query = @"SELECT userid
                                      , userpwd
                                   FROM signup
                                  WHERE userid = @userid
                                    AND userpwd = @userpwd";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmUserId = new SqlParameter("@userid", userid);
                SqlParameter prmUserPwd = new SqlParameter("@userpwd", userpwd);
                cmd.Parameters.Add(prmUserId);
                cmd.Parameters.Add(prmUserPwd);

                SqlDataReader reader = cmd.ExecuteReader();
                //var result = cmd.ExecuteNonQuery();

                if (reader.Read()) //reader.Read()
                {
                    //chkUserID = reader["userid"] != null ? reader["userid"].ToString() : "-"; // 유저아이디가 null일때 - 변경
                    //chkUserPwd = reader["userpwd"] != null ? reader["userpwd"].ToString() : "-"; // 패스워드가 null일때 - 변경
                    //MessageBox.Show("로그인 성공", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("로그인 정보가 없습니다.", "DB오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
                //return true;
            }
        }

        #region '비밀번호 표시'
        // 비밀번호 표시여부 이벤트핸들러
        private void Chk_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Show.Checked)
                Txt_UserPwd.PasswordChar = '\0';
            else
                Txt_UserPwd.PasswordChar = '●';
        }
        #endregion

        #region '입력초기화'
        // 입력초기화버튼 이벤트핸들러
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Txt_UserId.Clear();
            Txt_UserPwd.Clear();
            Txt_UserId.Focus(); // 초기화를 누르면 커서를 아이디입력창으로 자동이동
        }
        #endregion

        #region '창닫기'

        // 창닫기버튼 이벤트핸들러
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 창을 닫을 때 종료여부 질문 이벤트핸들러
        private void SignIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("정말 종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) e.Cancel = true;
        }
        #endregion

        #region '회원가입'
        // 회원가입 버튼클릭 이벤트핸들러
        private void Btn_SignUp_Click(object sender, EventArgs e)
        {
            SignUP signup = new SignUP();
            signup.FormClosed += (s, args) => this.Show(); // 회원가입창을 닫을때 로그인창을 다시 띄우도록
            signup.TopMost = true;
            signup.ShowDialog();
            //signup.Hide(); // 원래 회원가입창을 열때 로그인창을 숨기려고 했는데 모달창으로 열어서 로그인창에 간섭하지 못하도록 바꿈
        }

        #endregion

        #region '엔터키로 포커스 이동하기'
        // 아이디입력창에서 엔터키로 비밀번호입력창으로 이동
        private void Txt_UserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Txt_UserPwd.Focus();
            }
        }

        // 비밀번호입력창에서 로그인버튼으로 이동
        private void Txt_UserPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Btn_SignIn.Focus();
            }
        }

        #endregion
        

        // 프로그램 실행시 포커스 위치가 아이디 입력창에 있도록 설정
        private void SignIN_Activated(object sender, EventArgs e)
        {
            this.ActiveControl = Txt_UserId;
        }
    }
}
