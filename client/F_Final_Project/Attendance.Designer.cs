namespace F_Final_Project
{
    partial class Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AttendanceL = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 1);
            this.panel1.TabIndex = 9;
            // 
            // AttendanceL
            // 
            this.AttendanceL.AutoSize = true;
            this.AttendanceL.Font = new System.Drawing.Font("휴먼모음T", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AttendanceL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AttendanceL.Location = new System.Drawing.Point(12, 23);
            this.AttendanceL.Name = "AttendanceL";
            this.AttendanceL.Size = new System.Drawing.Size(179, 53);
            this.AttendanceL.TabIndex = 12;
            this.AttendanceL.Text = "근태관리";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(634, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 700);
            this.panel2.TabIndex = 27;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(1147, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(85, 78);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 41;
            this.Logo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(36, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 700);
            this.panel3.TabIndex = 42;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1244, 849);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AttendanceL);
            this.Controls.Add(this.panel1);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AttendanceL;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel2;
    }
}