namespace My_project
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Txt_Username = new TextBox();
            Txt_Password = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Btn_Login = new Button();
            Btn_Reset = new Button();
            panel1 = new Panel();
            Btn_signup = new Button();
            label5 = new Label();
            label4 = new Label();
            ChkShow = new CheckBox();
            Btn_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("나눔고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(71, 141);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 24);
            label1.TabIndex = 1;
            label1.Text = "반갑습니다";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 35);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Txt_Username
            // 
            Txt_Username.BackColor = SystemColors.Menu;
            Txt_Username.Location = new Point(284, 128);
            Txt_Username.Margin = new Padding(2);
            Txt_Username.Name = "Txt_Username";
            Txt_Username.Size = new Size(233, 23);
            Txt_Username.TabIndex = 3;
            Txt_Username.TextChanged += Txt_Id_TextChanged;
            // 
            // Txt_Password
            // 
            Txt_Password.BackColor = SystemColors.Menu;
            Txt_Password.Location = new Point(284, 185);
            Txt_Password.Margin = new Padding(2);
            Txt_Password.Name = "Txt_Password";
            Txt_Password.PasswordChar = '●';
            Txt_Password.Size = new Size(233, 23);
            Txt_Password.TabIndex = 4;
            Txt_Password.TextChanged += Txt_Pwd_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("나눔고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(284, 106);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "아이디";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("나눔고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(284, 163);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "비밀번호";
            // 
            // Btn_Login
            // 
            Btn_Login.Location = new Point(381, 269);
            Btn_Login.Margin = new Padding(2);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new Size(73, 23);
            Btn_Login.TabIndex = 7;
            Btn_Login.Text = "로그인";
            Btn_Login.UseVisualStyleBackColor = true;
            Btn_Login.Click += Btn_Login_Click;
            // 
            // Btn_Reset
            // 
            Btn_Reset.Location = new Point(458, 269);
            Btn_Reset.Margin = new Padding(2);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(73, 22);
            Btn_Reset.TabIndex = 8;
            Btn_Reset.Text = "초기화";
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(Btn_signup);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(22, 27);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 265);
            panel1.TabIndex = 9;
            // 
            // Btn_signup
            // 
            Btn_signup.Location = new Point(87, 232);
            Btn_signup.Name = "Btn_signup";
            Btn_signup.Size = new Size(75, 23);
            Btn_signup.TabIndex = 5;
            Btn_signup.Text = "회원가입";
            Btn_signup.UseVisualStyleBackColor = true;
            Btn_signup.Click += Btn_signup_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 214);
            label5.Name = "label5";
            label5.Size = new Size(137, 15);
            label5.TabIndex = 4;
            label5.Text = "기존회원이 아니신가요?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.Location = new Point(284, 57);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 10;
            label4.Text = "로그-인";
            // 
            // ChkShow
            // 
            ChkShow.AutoSize = true;
            ChkShow.Font = new Font("맑은 고딕", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ChkShow.Location = new Point(421, 213);
            ChkShow.Name = "ChkShow";
            ChkShow.Size = new Size(96, 17);
            ChkShow.TabIndex = 11;
            ChkShow.Text = "비밀번호 표시";
            ChkShow.UseVisualStyleBackColor = true;
            ChkShow.CheckedChanged += ChkShow_CheckedChanged_1;
            // 
            // Btn_exit
            // 
            Btn_exit.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Btn_exit.Location = new Point(526, 8);
            Btn_exit.Name = "Btn_exit";
            Btn_exit.Size = new Size(23, 23);
            Btn_exit.TabIndex = 12;
            Btn_exit.Text = "X";
            Btn_exit.UseVisualStyleBackColor = true;
            Btn_exit.Click += Btn_exit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(557, 314);
            Controls.Add(Btn_exit);
            Controls.Add(panel1);
            Controls.Add(ChkShow);
            Controls.Add(label4);
            Controls.Add(Btn_Reset);
            Controls.Add(Btn_Login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Txt_Password);
            Controls.Add(Txt_Username);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            Resizable = false;
            Style = MetroFramework.MetroColorStyle.White;
            FormClosing += Login_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox Txt_Username;
        private TextBox Txt_Password;
        private Label label2;
        private Label label3;
        private Button Btn_Login;
        private Button Btn_Reset;
        private Panel panel1;
        private Label label4;
        private CheckBox ChkShow;
        private Label label5;
        private Button Btn_signup;
        private Button Btn_exit;
    }
}
