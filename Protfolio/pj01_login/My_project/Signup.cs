using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace My_project
{

    public partial class Signup : MetroForm
    {
        public Signup()
        {
            InitializeComponent();
        }

        // 이름입력 이벤트핸들러
        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        // 아이디입력 이벤트핸들러
        private void Txt_Id_TextChanged(object sender, EventArgs e)
        {

        }

        #region '취소버튼'
        // 취소버튼 이벤트핸들러
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Close();
        }
        #endregion

        // 필요없어짐
        #region '창 이동'

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


        // 성별선택 이벤트핸들러
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
