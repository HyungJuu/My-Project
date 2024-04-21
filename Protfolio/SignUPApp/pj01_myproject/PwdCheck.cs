using System;
using System.Windows.Forms;

namespace pj01_myproject
{
    public partial class PwdCheck : Form
    {
        public string Pwd { get; private set; }

        public PwdCheck()
        {
            InitializeComponent();
        }

        // 확인버튼 이벤트핸들러
        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            Pwd = Txt_pwdcheck.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        // 취소버튼 이벤트핸들러
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
