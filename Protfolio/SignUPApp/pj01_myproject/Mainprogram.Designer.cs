namespace pj01_myproject
{
    partial class Mainprogram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainprogram));
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dgv_show = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_InfoName = new System.Windows.Forms.TextBox();
            this.Txt_InfoId = new System.Windows.Forms.TextBox();
            this.Btn_ShowInfo = new System.Windows.Forms.Button();
            this.Btn_ModifyInfo = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.Txt_InputMemo = new MetroFramework.Controls.MetroTextBox();
            this.Btn_SaveMemo = new MetroFramework.Controls.MetroButton();
            this.Txt_SelectedSaveDate = new MetroFramework.Controls.MetroTextBox();
            this.Txt_OutputMemo = new MetroFramework.Controls.MetroTextBox();
            this.Btn_Signout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(503, 449);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 25);
            this.Btn_Delete.TabIndex = 4;
            this.Btn_Delete.Text = "회원탈퇴";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Exit.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Exit.Location = new System.Drawing.Point(567, 9);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(26, 24);
            this.Btn_Exit.TabIndex = 5;
            this.Btn_Exit.Text = "X";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dgv_show);
            this.panel1.Location = new System.Drawing.Point(25, 384);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 61);
            this.panel1.TabIndex = 10;
            // 
            // Dgv_show
            // 
            this.Dgv_show.AllowUserToAddRows = false;
            this.Dgv_show.AllowUserToDeleteRows = false;
            this.Dgv_show.BackgroundColor = System.Drawing.Color.Azure;
            this.Dgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_show.Location = new System.Drawing.Point(0, 0);
            this.Dgv_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_show.Name = "Dgv_show";
            this.Dgv_show.ReadOnly = true;
            this.Dgv_show.RowHeadersWidth = 51;
            this.Dgv_show.RowTemplate.Height = 27;
            this.Dgv_show.Size = new System.Drawing.Size(553, 61);
            this.Dgv_show.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Txt_InfoName
            // 
            this.Txt_InfoName.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_InfoName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_InfoName.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Txt_InfoName.Location = new System.Drawing.Point(204, 76);
            this.Txt_InfoName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_InfoName.Name = "Txt_InfoName";
            this.Txt_InfoName.Size = new System.Drawing.Size(118, 26);
            this.Txt_InfoName.TabIndex = 14;
            this.Txt_InfoName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_InfoId
            // 
            this.Txt_InfoId.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_InfoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_InfoId.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Txt_InfoId.Location = new System.Drawing.Point(204, 124);
            this.Txt_InfoId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_InfoId.Name = "Txt_InfoId";
            this.Txt_InfoId.Size = new System.Drawing.Size(118, 26);
            this.Txt_InfoId.TabIndex = 15;
            this.Txt_InfoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_ShowInfo
            // 
            this.Btn_ShowInfo.Location = new System.Drawing.Point(26, 183);
            this.Btn_ShowInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ShowInfo.Name = "Btn_ShowInfo";
            this.Btn_ShowInfo.Size = new System.Drawing.Size(83, 28);
            this.Btn_ShowInfo.TabIndex = 1;
            this.Btn_ShowInfo.Text = "정보조회";
            this.Btn_ShowInfo.UseVisualStyleBackColor = true;
            this.Btn_ShowInfo.Click += new System.EventHandler(this.Btn_ShowInfo_Click);
            // 
            // Btn_ModifyInfo
            // 
            this.Btn_ModifyInfo.Location = new System.Drawing.Point(115, 183);
            this.Btn_ModifyInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ModifyInfo.Name = "Btn_ModifyInfo";
            this.Btn_ModifyInfo.Size = new System.Drawing.Size(83, 28);
            this.Btn_ModifyInfo.TabIndex = 2;
            this.Btn_ModifyInfo.Text = "정보수정";
            this.Btn_ModifyInfo.UseVisualStyleBackColor = true;
            this.Btn_ModifyInfo.Click += new System.EventHandler(this.Btn_ModifyInfo_Click);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(358, 44);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 19;
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateSelected);
            // 
            // Txt_InputMemo
            // 
            // 
            // 
            // 
            this.Txt_InputMemo.CustomButton.Image = null;
            this.Txt_InputMemo.CustomButton.Location = new System.Drawing.Point(507, 2);
            this.Txt_InputMemo.CustomButton.Name = "";
            this.Txt_InputMemo.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.Txt_InputMemo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_InputMemo.CustomButton.TabIndex = 1;
            this.Txt_InputMemo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_InputMemo.CustomButton.UseSelectable = true;
            this.Txt_InputMemo.CustomButton.Visible = false;
            this.Txt_InputMemo.Lines = new string[0];
            this.Txt_InputMemo.Location = new System.Drawing.Point(25, 223);
            this.Txt_InputMemo.MaxLength = 32767;
            this.Txt_InputMemo.Multiline = true;
            this.Txt_InputMemo.Name = "Txt_InputMemo";
            this.Txt_InputMemo.PasswordChar = '\0';
            this.Txt_InputMemo.PromptText = "한줄 메모...";
            this.Txt_InputMemo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Txt_InputMemo.SelectedText = "";
            this.Txt_InputMemo.SelectionLength = 0;
            this.Txt_InputMemo.SelectionStart = 0;
            this.Txt_InputMemo.ShortcutsEnabled = true;
            this.Txt_InputMemo.Size = new System.Drawing.Size(553, 48);
            this.Txt_InputMemo.TabIndex = 3;
            this.Txt_InputMemo.UseSelectable = true;
            this.Txt_InputMemo.WaterMark = "한줄 메모...";
            this.Txt_InputMemo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_InputMemo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_SaveMemo
            // 
            this.Btn_SaveMemo.Location = new System.Drawing.Point(524, 277);
            this.Btn_SaveMemo.Name = "Btn_SaveMemo";
            this.Btn_SaveMemo.Size = new System.Drawing.Size(54, 22);
            this.Btn_SaveMemo.TabIndex = 20;
            this.Btn_SaveMemo.Text = "저장";
            this.Btn_SaveMemo.UseSelectable = true;
            this.Btn_SaveMemo.Click += new System.EventHandler(this.Btn_SaveMemo_Click);
            // 
            // Txt_SelectedSaveDate
            // 
            // 
            // 
            // 
            this.Txt_SelectedSaveDate.CustomButton.Image = null;
            this.Txt_SelectedSaveDate.CustomButton.Location = new System.Drawing.Point(64, 1);
            this.Txt_SelectedSaveDate.CustomButton.Name = "";
            this.Txt_SelectedSaveDate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_SelectedSaveDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_SelectedSaveDate.CustomButton.TabIndex = 1;
            this.Txt_SelectedSaveDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_SelectedSaveDate.CustomButton.UseSelectable = true;
            this.Txt_SelectedSaveDate.CustomButton.Visible = false;
            this.Txt_SelectedSaveDate.Lines = new string[0];
            this.Txt_SelectedSaveDate.Location = new System.Drawing.Point(432, 277);
            this.Txt_SelectedSaveDate.MaxLength = 32767;
            this.Txt_SelectedSaveDate.Name = "Txt_SelectedSaveDate";
            this.Txt_SelectedSaveDate.PasswordChar = '\0';
            this.Txt_SelectedSaveDate.PromptText = "-- 저장 날짜 --";
            this.Txt_SelectedSaveDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_SelectedSaveDate.SelectedText = "";
            this.Txt_SelectedSaveDate.SelectionLength = 0;
            this.Txt_SelectedSaveDate.SelectionStart = 0;
            this.Txt_SelectedSaveDate.ShortcutsEnabled = true;
            this.Txt_SelectedSaveDate.Size = new System.Drawing.Size(86, 23);
            this.Txt_SelectedSaveDate.TabIndex = 21;
            this.Txt_SelectedSaveDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_SelectedSaveDate.UseSelectable = true;
            this.Txt_SelectedSaveDate.WaterMark = "-- 저장 날짜 --";
            this.Txt_SelectedSaveDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_SelectedSaveDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Txt_OutputMemo
            // 
            // 
            // 
            // 
            this.Txt_OutputMemo.CustomButton.Image = null;
            this.Txt_OutputMemo.CustomButton.Location = new System.Drawing.Point(487, 2);
            this.Txt_OutputMemo.CustomButton.Name = "";
            this.Txt_OutputMemo.CustomButton.Size = new System.Drawing.Size(63, 63);
            this.Txt_OutputMemo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_OutputMemo.CustomButton.TabIndex = 1;
            this.Txt_OutputMemo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_OutputMemo.CustomButton.UseSelectable = true;
            this.Txt_OutputMemo.CustomButton.Visible = false;
            this.Txt_OutputMemo.Lines = new string[0];
            this.Txt_OutputMemo.Location = new System.Drawing.Point(25, 305);
            this.Txt_OutputMemo.MaxLength = 32767;
            this.Txt_OutputMemo.Multiline = true;
            this.Txt_OutputMemo.Name = "Txt_OutputMemo";
            this.Txt_OutputMemo.PasswordChar = '\0';
            this.Txt_OutputMemo.PromptText = "저장된 메모...";
            this.Txt_OutputMemo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Txt_OutputMemo.SelectedText = "";
            this.Txt_OutputMemo.SelectionLength = 0;
            this.Txt_OutputMemo.SelectionStart = 0;
            this.Txt_OutputMemo.ShortcutsEnabled = true;
            this.Txt_OutputMemo.Size = new System.Drawing.Size(553, 68);
            this.Txt_OutputMemo.TabIndex = 22;
            this.Txt_OutputMemo.UseCustomBackColor = true;
            this.Txt_OutputMemo.UseSelectable = true;
            this.Txt_OutputMemo.WaterMark = "저장된 메모...";
            this.Txt_OutputMemo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_OutputMemo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_Signout
            // 
            this.Btn_Signout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Signout.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Signout.Location = new System.Drawing.Point(484, 9);
            this.Btn_Signout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Signout.Name = "Btn_Signout";
            this.Btn_Signout.Size = new System.Drawing.Size(75, 25);
            this.Btn_Signout.TabIndex = 5;
            this.Btn_Signout.Text = "로그아웃";
            this.Btn_Signout.UseVisualStyleBackColor = true;
            this.Btn_Signout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // Mainprogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 483);
            this.ControlBox = false;
            this.Controls.Add(this.Txt_OutputMemo);
            this.Controls.Add(this.Txt_SelectedSaveDate);
            this.Controls.Add(this.Btn_SaveMemo);
            this.Controls.Add(this.Txt_InputMemo);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.Btn_ModifyInfo);
            this.Controls.Add(this.Btn_ShowInfo);
            this.Controls.Add(this.Txt_InfoId);
            this.Controls.Add(this.Txt_InfoName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Signout);
            this.Controls.Add(this.Btn_Exit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainprogram";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 16);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Mainprogram_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dgv_show;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txt_InfoName;
        private System.Windows.Forms.TextBox Txt_InfoId;
        private System.Windows.Forms.Button Btn_ShowInfo;
        private System.Windows.Forms.Button Btn_ModifyInfo;
        private System.Windows.Forms.MonthCalendar Calendar;
        private MetroFramework.Controls.MetroTextBox Txt_InputMemo;
        private MetroFramework.Controls.MetroButton Btn_SaveMemo;
        private MetroFramework.Controls.MetroTextBox Txt_SelectedSaveDate;
        private MetroFramework.Controls.MetroTextBox Txt_OutputMemo;
        private System.Windows.Forms.Button Btn_Signout;
    }
}