namespace My_project
{
    partial class Signup
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
            Txt_Name = new TextBox();
            Txt_Id = new TextBox();
            Txt_Pwd = new TextBox();
            Btn_Ok = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Txt_phone = new TextBox();
            panel1 = new Panel();
            Btn_Cancel = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // Txt_Name
            // 
            Txt_Name.BackColor = SystemColors.Control;
            Txt_Name.Location = new Point(348, 57);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(181, 23);
            Txt_Name.TabIndex = 0;
            Txt_Name.TextChanged += Txt_Name_TextChanged;
            // 
            // Txt_Id
            // 
            Txt_Id.BackColor = SystemColors.Control;
            Txt_Id.Location = new Point(348, 95);
            Txt_Id.Name = "Txt_Id";
            Txt_Id.Size = new Size(181, 23);
            Txt_Id.TabIndex = 1;
            Txt_Id.TextChanged += Txt_Id_TextChanged;
            // 
            // Txt_Pwd
            // 
            Txt_Pwd.BackColor = SystemColors.Control;
            Txt_Pwd.Location = new Point(348, 137);
            Txt_Pwd.Name = "Txt_Pwd";
            Txt_Pwd.Size = new Size(181, 23);
            Txt_Pwd.TabIndex = 2;
            // 
            // Btn_Ok
            // 
            Btn_Ok.Location = new Point(379, 269);
            Btn_Ok.Name = "Btn_Ok";
            Btn_Ok.Size = new Size(73, 22);
            Btn_Ok.TabIndex = 3;
            Btn_Ok.Text = "완료";
            Btn_Ok.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 60);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "이름 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 98);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "아이디 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 140);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 6;
            label3.Text = "비밀번호 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 179);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 7;
            label4.Text = "전화번호 :";
            // 
            // Txt_phone
            // 
            Txt_phone.BackColor = SystemColors.Control;
            Txt_phone.Location = new Point(348, 176);
            Txt_phone.Name = "Txt_phone";
            Txt_phone.Size = new Size(181, 23);
            Txt_phone.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Location = new Point(22, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 265);
            panel1.TabIndex = 8;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Location = new Point(458, 269);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(73, 22);
            Btn_Cancel.TabIndex = 9;
            Btn_Cancel.Text = "취소";
            Btn_Cancel.UseVisualStyleBackColor = true;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "여성", "남성", "선택안함" });
            comboBox1.Location = new Point(348, 215);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(304, 218);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 11;
            label5.Text = "성별 :";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(557, 314);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(Btn_Cancel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_Ok);
            Controls.Add(Txt_phone);
            Controls.Add(Txt_Pwd);
            Controls.Add(Txt_Id);
            Controls.Add(Txt_Name);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Signup";
            Resizable = false;
            Style = MetroFramework.MetroColorStyle.White;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Name;
        private TextBox Txt_Id;
        private TextBox Txt_Pwd;
        private Button Btn_Ok;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Txt_phone;
        private Panel panel1;
        private Button Btn_Cancel;
        private ComboBox comboBox1;
        private Label label5;
    }
}