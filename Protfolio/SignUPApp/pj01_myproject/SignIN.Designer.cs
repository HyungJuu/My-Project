namespace pj01_myproject
{
    partial class SignIN
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_SignUp = new System.Windows.Forms.Button();
            this.Btn_SignIn = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Chk_Show = new System.Windows.Forms.CheckBox();
            this.Txt_UserId = new System.Windows.Forms.TextBox();
            this.Txt_UserPwd = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Btn_SignUp);
            this.panel1.Location = new System.Drawing.Point(23, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 395);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(-1, 230);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(295, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "반갑습니다";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("굴림", 8.25F);
            this.label4.Location = new System.Drawing.Point(-1, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "기존회원이 아니신가요?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_SignUp
            // 
            this.Btn_SignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_SignUp.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_SignUp.Location = new System.Drawing.Point(103, 346);
            this.Btn_SignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_SignUp.Name = "Btn_SignUp";
            this.Btn_SignUp.Size = new System.Drawing.Size(95, 35);
            this.Btn_SignUp.TabIndex = 6;
            this.Btn_SignUp.Text = "회원가입";
            this.Btn_SignUp.UseVisualStyleBackColor = true;
            this.Btn_SignUp.Click += new System.EventHandler(this.Btn_SignUp_Click);
            // 
            // Btn_SignIn
            // 
            this.Btn_SignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_SignIn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_SignIn.Location = new System.Drawing.Point(497, 379);
            this.Btn_SignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_SignIn.Name = "Btn_SignIn";
            this.Btn_SignIn.Size = new System.Drawing.Size(95, 35);
            this.Btn_SignIn.TabIndex = 4;
            this.Btn_SignIn.Text = "로그인";
            this.Btn_SignIn.UseVisualStyleBackColor = true;
            this.Btn_SignIn.Click += new System.EventHandler(this.Btn_SignIn_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Clear.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Clear.Location = new System.Drawing.Point(611, 379);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(95, 35);
            this.Btn_Clear.TabIndex = 5;
            this.Btn_Clear.Text = "초기화";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Exit.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Exit.Location = new System.Drawing.Point(707, 11);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(30, 30);
            this.Btn_Exit.TabIndex = 7;
            this.Btn_Exit.Text = "X";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(356, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "로그-인";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(369, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(369, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "비밀번호";
            // 
            // Chk_Show
            // 
            this.Chk_Show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Chk_Show.AutoSize = true;
            this.Chk_Show.Font = new System.Drawing.Font("굴림", 9F);
            this.Chk_Show.Location = new System.Drawing.Point(582, 285);
            this.Chk_Show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Chk_Show.Name = "Chk_Show";
            this.Chk_Show.Size = new System.Drawing.Size(124, 19);
            this.Chk_Show.TabIndex = 3;
            this.Chk_Show.Text = "비밀번호 표시";
            this.Chk_Show.UseVisualStyleBackColor = true;
            this.Chk_Show.CheckedChanged += new System.EventHandler(this.Chk_Show_CheckedChanged);
            // 
            // Txt_UserId
            // 
            this.Txt_UserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_UserId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txt_UserId.Location = new System.Drawing.Point(373, 176);
            this.Txt_UserId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_UserId.Name = "Txt_UserId";
            this.Txt_UserId.Size = new System.Drawing.Size(333, 25);
            this.Txt_UserId.TabIndex = 1;
            this.Txt_UserId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_UserId_KeyPress);
            // 
            // Txt_UserPwd
            // 
            this.Txt_UserPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_UserPwd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txt_UserPwd.Location = new System.Drawing.Point(373, 256);
            this.Txt_UserPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_UserPwd.Name = "Txt_UserPwd";
            this.Txt_UserPwd.PasswordChar = '●';
            this.Txt_UserPwd.Size = new System.Drawing.Size(333, 25);
            this.Txt_UserPwd.TabIndex = 2;
            this.Txt_UserPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_UserPwd_KeyPress);
            // 
            // SignIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Txt_UserPwd);
            this.Controls.Add(this.Txt_UserId);
            this.Controls.Add(this.Chk_Show);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_SignIn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignIN";
            this.Padding = new System.Windows.Forms.Padding(21, 75, 21, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.SignIN_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignIN_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_SignUp;
        private System.Windows.Forms.Button Btn_SignIn;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Chk_Show;
        private System.Windows.Forms.TextBox Txt_UserId;
        private System.Windows.Forms.TextBox Txt_UserPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

