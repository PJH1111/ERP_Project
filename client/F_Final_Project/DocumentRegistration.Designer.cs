namespace F_Final_Project
{
    partial class DocumentRegistration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.btncancle = new System.Windows.Forms.Button();
            this.SelectMenu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 594);
            this.panel1.TabIndex = 0;
            // 
            // txttitle
            // 
            this.txttitle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txttitle.Location = new System.Drawing.Point(153, 60);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(700, 29);
            this.txttitle.TabIndex = 2;
            // 
            // btnsend
            // 
            this.btnsend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btnsend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsend.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnsend.ForeColor = System.Drawing.SystemColors.Window;
            this.btnsend.Location = new System.Drawing.Point(885, 60);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(92, 29);
            this.btnsend.TabIndex = 3;
            this.btnsend.Text = "완료";
            this.btnsend.UseVisualStyleBackColor = false;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btncancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncancle.ForeColor = System.Drawing.SystemColors.Window;
            this.btncancle.Location = new System.Drawing.Point(885, 106);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(92, 29);
            this.btncancle.TabIndex = 3;
            this.btncancle.Text = "취소";
            this.btncancle.UseVisualStyleBackColor = false;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // SelectMenu
            // 
            this.SelectMenu.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectMenu.FormattingEnabled = true;
            this.SelectMenu.Items.AddRange(new object[] {
            "휴가신청서",
            "일일업무보고서",
            "기안서"});
            this.SelectMenu.Location = new System.Drawing.Point(12, 60);
            this.SelectMenu.Name = "SelectMenu";
            this.SelectMenu.Size = new System.Drawing.Size(121, 29);
            this.SelectMenu.TabIndex = 5;
            this.SelectMenu.Text = "결재 종류";
            this.SelectMenu.SelectedIndexChanged += new System.EventHandler(this.SelectMenu_SelectedIndexChanged);
            // 
            // DocumentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1024, 711);
            this.Controls.Add(this.SelectMenu);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.panel1);
            this.Name = "DocumentRegistration";
            this.Text = "DocumentRegistration";
            this.Load += new System.EventHandler(this.DocumentRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.ComboBox SelectMenu;
    }
}