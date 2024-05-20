namespace pj01_myproject
{
    partial class InfoUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoUpdate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            this.Txt_UserId = new System.Windows.Forms.TextBox();
            this.Txt_UserPwd = new System.Windows.Forms.TextBox();
            this.Txt_userPhone = new System.Windows.Forms.TextBox();
            this.Txt_UserEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Chk_Woman = new System.Windows.Forms.CheckBox();
            this.Chk_None = new System.Windows.Forms.CheckBox();
            this.Chk_Man = new System.Windows.Forms.CheckBox();
            this.Chk_Show = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(20, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 316);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(-1, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "회원정보수정";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Update
            // 
            this.Btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Update.Location = new System.Drawing.Point(426, 303);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(83, 28);
            this.Btn_Update.TabIndex = 10;
            this.Btn_Update.Text = "수정";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancel.Location = new System.Drawing.Point(526, 303);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(83, 28);
            this.Btn_Cancel.TabIndex = 11;
            this.Btn_Cancel.Text = "취소";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(345, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(332, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(318, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "비밀번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(318, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "전화번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(295, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "이메일(선택)";
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_UserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txt_UserName.Location = new System.Drawing.Point(392, 58);
            this.Txt_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(218, 21);
            this.Txt_UserName.TabIndex = 1;
            // 
            // Txt_UserId
            // 
            this.Txt_UserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_UserId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txt_UserId.Location = new System.Drawing.Point(392, 98);
            this.Txt_UserId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_UserId.Name = "Txt_UserId";
            this.Txt_UserId.Size = new System.Drawing.Size(218, 21);
            this.Txt_UserId.TabIndex = 2;
            // 
            // Txt_UserPwd
            // 
            this.Txt_UserPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_UserPwd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txt_UserPwd.Location = new System.Drawing.Point(392, 138);
            this.Txt_UserPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_UserPwd.Name = "Txt_UserPwd";
            this.Txt_UserPwd.PasswordChar = '●';
            this.Txt_UserPwd.Size = new System.Drawing.Size(218, 21);
            this.Txt_UserPwd.TabIndex = 3;
            // 
            // Txt_userPhone
            // 
            this.Txt_userPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_userPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txt_userPhone.Location = new System.Drawing.Point(392, 178);
            this.Txt_userPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_userPhone.Name = "Txt_userPhone";
            this.Txt_userPhone.Size = new System.Drawing.Size(218, 21);
            this.Txt_userPhone.TabIndex = 5;
            // 
            // Txt_UserEmail
            // 
            this.Txt_UserEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_UserEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txt_UserEmail.Location = new System.Drawing.Point(392, 218);
            this.Txt_UserEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_UserEmail.Name = "Txt_UserEmail";
            this.Txt_UserEmail.Size = new System.Drawing.Size(218, 21);
            this.Txt_UserEmail.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "성별";
            // 
            // Chk_Woman
            // 
            this.Chk_Woman.AutoSize = true;
            this.Chk_Woman.Location = new System.Drawing.Point(392, 264);
            this.Chk_Woman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Chk_Woman.Name = "Chk_Woman";
            this.Chk_Woman.Size = new System.Drawing.Size(36, 16);
            this.Chk_Woman.TabIndex = 7;
            this.Chk_Woman.Text = "여";
            this.Chk_Woman.UseVisualStyleBackColor = true;
            this.Chk_Woman.CheckedChanged += new System.EventHandler(this.Chk_Woman_CheckedChanged);
            // 
            // Chk_None
            // 
            this.Chk_None.AutoSize = true;
            this.Chk_None.Location = new System.Drawing.Point(531, 264);
            this.Chk_None.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Chk_None.Name = "Chk_None";
            this.Chk_None.Size = new System.Drawing.Size(72, 16);
            this.Chk_None.TabIndex = 9;
            this.Chk_None.Text = "선택안함";
            this.Chk_None.UseVisualStyleBackColor = true;
            this.Chk_None.CheckedChanged += new System.EventHandler(this.Chk_None_CheckedChanged);
            // 
            // Chk_Man
            // 
            this.Chk_Man.AutoSize = true;
            this.Chk_Man.Location = new System.Drawing.Point(461, 264);
            this.Chk_Man.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Chk_Man.Name = "Chk_Man";
            this.Chk_Man.Size = new System.Drawing.Size(36, 16);
            this.Chk_Man.TabIndex = 8;
            this.Chk_Man.Text = "남";
            this.Chk_Man.UseVisualStyleBackColor = true;
            this.Chk_Man.CheckedChanged += new System.EventHandler(this.Chk_Man_CheckedChanged);
            // 
            // Chk_Show
            // 
            this.Chk_Show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Chk_Show.AutoSize = true;
            this.Chk_Show.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Chk_Show.Location = new System.Drawing.Point(516, 163);
            this.Chk_Show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Chk_Show.Name = "Chk_Show";
            this.Chk_Show.Size = new System.Drawing.Size(94, 15);
            this.Chk_Show.TabIndex = 4;
            this.Chk_Show.Text = "비밀번호 표시";
            this.Chk_Show.UseVisualStyleBackColor = true;
            this.Chk_Show.CheckedChanged += new System.EventHandler(this.Chk_Show_CheckedChanged);
            // 
            // InfoUpdate
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 360);
            this.ControlBox = false;
            this.Controls.Add(this.Chk_Show);
            this.Controls.Add(this.Chk_Man);
            this.Controls.Add(this.Chk_None);
            this.Controls.Add(this.Chk_Woman);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_UserEmail);
            this.Controls.Add(this.Txt_userPhone);
            this.Controls.Add(this.Txt_UserPwd);
            this.Controls.Add(this.Txt_UserId);
            this.Controls.Add(this.Txt_UserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoUpdate";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 16);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_UserName;
        private System.Windows.Forms.TextBox Txt_UserId;
        private System.Windows.Forms.TextBox Txt_UserPwd;
        private System.Windows.Forms.TextBox Txt_userPhone;
        private System.Windows.Forms.TextBox Txt_UserEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Chk_Woman;
        private System.Windows.Forms.CheckBox Chk_None;
        private System.Windows.Forms.CheckBox Chk_Man;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox Chk_Show;
    }
}