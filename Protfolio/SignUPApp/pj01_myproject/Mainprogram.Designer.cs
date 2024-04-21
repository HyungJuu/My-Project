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
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_InfoName = new System.Windows.Forms.TextBox();
            this.Txt_InfoId = new System.Windows.Forms.TextBox();
            this.Btn_ShowInfo = new System.Windows.Forms.Button();
            this.Btn_ModifyInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Delete.Location = new System.Drawing.Point(576, 516);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(95, 35);
            this.Btn_Delete.TabIndex = 0;
            this.Btn_Delete.Text = "회원탈퇴";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Exit.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Exit.Location = new System.Drawing.Point(645, 11);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(30, 30);
            this.Btn_Exit.TabIndex = 8;
            this.Btn_Exit.Text = "X";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(14, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 233);
            this.panel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(632, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(61, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 151);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Txt_InfoName
            // 
            this.Txt_InfoName.Location = new System.Drawing.Point(229, 106);
            this.Txt_InfoName.Name = "Txt_InfoName";
            this.Txt_InfoName.Size = new System.Drawing.Size(108, 25);
            this.Txt_InfoName.TabIndex = 14;
            this.Txt_InfoName.Text = "이름";
            // 
            // Txt_InfoId
            // 
            this.Txt_InfoId.Location = new System.Drawing.Point(229, 155);
            this.Txt_InfoId.Name = "Txt_InfoId";
            this.Txt_InfoId.Size = new System.Drawing.Size(108, 25);
            this.Txt_InfoId.TabIndex = 15;
            this.Txt_InfoId.Text = "아이디";
            // 
            // Btn_ShowInfo
            // 
            this.Btn_ShowInfo.Location = new System.Drawing.Point(445, 96);
            this.Btn_ShowInfo.Name = "Btn_ShowInfo";
            this.Btn_ShowInfo.Size = new System.Drawing.Size(95, 35);
            this.Btn_ShowInfo.TabIndex = 16;
            this.Btn_ShowInfo.Text = "정보조회";
            this.Btn_ShowInfo.UseVisualStyleBackColor = true;
            this.Btn_ShowInfo.Click += new System.EventHandler(this.Btn_ShowInfo_Click);
            // 
            // Btn_ModifyInfo
            // 
            this.Btn_ModifyInfo.Location = new System.Drawing.Point(445, 148);
            this.Btn_ModifyInfo.Name = "Btn_ModifyInfo";
            this.Btn_ModifyInfo.Size = new System.Drawing.Size(95, 35);
            this.Btn_ModifyInfo.TabIndex = 17;
            this.Btn_ModifyInfo.Text = "정보수정";
            this.Btn_ModifyInfo.UseVisualStyleBackColor = true;
            // 
            // Mainprogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 571);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_ModifyInfo);
            this.Controls.Add(this.Btn_ShowInfo);
            this.Controls.Add(this.Txt_InfoId);
            this.Controls.Add(this.Txt_InfoName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Exit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainprogram";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txt_InfoName;
        private System.Windows.Forms.TextBox Txt_InfoId;
        private System.Windows.Forms.Button Btn_ShowInfo;
        private System.Windows.Forms.Button Btn_ModifyInfo;
    }
}