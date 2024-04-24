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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Delete.Location = new System.Drawing.Point(504, 413);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(83, 28);
            this.Btn_Delete.TabIndex = 0;
            this.Btn_Delete.Text = "회원탈퇴";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Exit.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Exit.Location = new System.Drawing.Point(564, 9);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(26, 24);
            this.Btn_Exit.TabIndex = 8;
            this.Btn_Exit.Text = "X";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Dgv_show);
            this.panel1.Location = new System.Drawing.Point(12, 222);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 186);
            this.panel1.TabIndex = 10;
            // 
            // Dgv_show
            // 
            this.Dgv_show.AllowUserToAddRows = false;
            this.Dgv_show.AllowUserToDeleteRows = false;
            this.Dgv_show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_show.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Dgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_show.Location = new System.Drawing.Point(8, 18);
            this.Dgv_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_show.Name = "Dgv_show";
            this.Dgv_show.ReadOnly = true;
            this.Dgv_show.RowHeadersWidth = 51;
            this.Dgv_show.RowTemplate.Height = 27;
            this.Dgv_show.Size = new System.Drawing.Size(553, 153);
            this.Dgv_show.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Txt_InfoName
            // 
            this.Txt_InfoName.Location = new System.Drawing.Point(203, 85);
            this.Txt_InfoName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_InfoName.Name = "Txt_InfoName";
            this.Txt_InfoName.Size = new System.Drawing.Size(95, 21);
            this.Txt_InfoName.TabIndex = 14;
            // 
            // Txt_InfoId
            // 
            this.Txt_InfoId.Location = new System.Drawing.Point(203, 122);
            this.Txt_InfoId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_InfoId.Name = "Txt_InfoId";
            this.Txt_InfoId.Size = new System.Drawing.Size(95, 21);
            this.Txt_InfoId.TabIndex = 15;
            // 
            // Btn_ShowInfo
            // 
            this.Btn_ShowInfo.Location = new System.Drawing.Point(329, 80);
            this.Btn_ShowInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ShowInfo.Name = "Btn_ShowInfo";
            this.Btn_ShowInfo.Size = new System.Drawing.Size(83, 28);
            this.Btn_ShowInfo.TabIndex = 16;
            this.Btn_ShowInfo.Text = "정보조회";
            this.Btn_ShowInfo.UseVisualStyleBackColor = true;
            this.Btn_ShowInfo.Click += new System.EventHandler(this.Btn_ShowInfo_Click);
            // 
            // Btn_ModifyInfo
            // 
            this.Btn_ModifyInfo.Location = new System.Drawing.Point(329, 117);
            this.Btn_ModifyInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ModifyInfo.Name = "Btn_ModifyInfo";
            this.Btn_ModifyInfo.Size = new System.Drawing.Size(83, 28);
            this.Btn_ModifyInfo.TabIndex = 17;
            this.Btn_ModifyInfo.Text = "정보수정";
            this.Btn_ModifyInfo.UseVisualStyleBackColor = true;
            this.Btn_ModifyInfo.Click += new System.EventHandler(this.Btn_ModifyInfo_Click);
            // 
            // Mainprogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 457);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_ModifyInfo);
            this.Controls.Add(this.Btn_ShowInfo);
            this.Controls.Add(this.Txt_InfoId);
            this.Controls.Add(this.Txt_InfoName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Exit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainprogram";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 16);
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
    }
}