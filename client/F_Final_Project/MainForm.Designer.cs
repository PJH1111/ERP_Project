namespace F_Final_Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuTab = new System.Windows.Forms.Panel();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.TeamHome = new System.Windows.Forms.Button();
            this.EmployeeHome = new System.Windows.Forms.Button();
            this.AttendanceHome = new System.Windows.Forms.Button();
            this.DocumentHome = new System.Windows.Forms.Button();
            this.PostHome = new System.Windows.Forms.Button();
            this.NoticeHome = new System.Windows.Forms.Button();
            this.MyPageHome = new System.Windows.Forms.Button();
            this.MenuTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(2, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 880);
            this.panel1.TabIndex = 4;
            // 
            // MenuTab
            // 
            this.MenuTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.MenuTab.Controls.Add(this.BtnLogOut);
            this.MenuTab.Controls.Add(this.TeamHome);
            this.MenuTab.Controls.Add(this.EmployeeHome);
            this.MenuTab.Controls.Add(this.AttendanceHome);
            this.MenuTab.Controls.Add(this.DocumentHome);
            this.MenuTab.Controls.Add(this.PostHome);
            this.MenuTab.Controls.Add(this.NoticeHome);
            this.MenuTab.Controls.Add(this.MyPageHome);
            this.MenuTab.Location = new System.Drawing.Point(0, 0);
            this.MenuTab.Name = "MenuTab";
            this.MenuTab.Size = new System.Drawing.Size(1262, 37);
            this.MenuTab.TabIndex = 5;
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLogOut.BackgroundImage")));
            this.BtnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLogOut.FlatAppearance.BorderSize = 0;
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLogOut.Location = new System.Drawing.Point(1215, 0);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(37, 37);
            this.BtnLogOut.TabIndex = 0;
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // TeamHome
            // 
            this.TeamHome.BackColor = System.Drawing.Color.Transparent;
            this.TeamHome.FlatAppearance.BorderSize = 0;
            this.TeamHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeamHome.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamHome.ForeColor = System.Drawing.Color.White;
            this.TeamHome.Location = new System.Drawing.Point(662, 0);
            this.TeamHome.Name = "TeamHome";
            this.TeamHome.Size = new System.Drawing.Size(100, 37);
            this.TeamHome.TabIndex = 0;
            this.TeamHome.Text = "부서관리";
            this.TeamHome.UseVisualStyleBackColor = false;
            this.TeamHome.Click += new System.EventHandler(this.TeamHome_Click);
            // 
            // EmployeeHome
            // 
            this.EmployeeHome.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeHome.FlatAppearance.BorderSize = 0;
            this.EmployeeHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeHome.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeHome.ForeColor = System.Drawing.Color.White;
            this.EmployeeHome.Location = new System.Drawing.Point(552, 0);
            this.EmployeeHome.Name = "EmployeeHome";
            this.EmployeeHome.Size = new System.Drawing.Size(100, 37);
            this.EmployeeHome.TabIndex = 0;
            this.EmployeeHome.Text = "사원관리";
            this.EmployeeHome.UseVisualStyleBackColor = false;
            this.EmployeeHome.Click += new System.EventHandler(this.EmployeeHome_Click);
            // 
            // AttendanceHome
            // 
            this.AttendanceHome.BackColor = System.Drawing.Color.Transparent;
            this.AttendanceHome.FlatAppearance.BorderSize = 0;
            this.AttendanceHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttendanceHome.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AttendanceHome.ForeColor = System.Drawing.Color.White;
            this.AttendanceHome.Location = new System.Drawing.Point(442, 0);
            this.AttendanceHome.Name = "AttendanceHome";
            this.AttendanceHome.Size = new System.Drawing.Size(100, 37);
            this.AttendanceHome.TabIndex = 0;
            this.AttendanceHome.Text = "근태관리";
            this.AttendanceHome.UseVisualStyleBackColor = false;
            this.AttendanceHome.Click += new System.EventHandler(this.AttendanceHome_Click);
            // 
            // DocumentHome
            // 
            this.DocumentHome.BackColor = System.Drawing.Color.Transparent;
            this.DocumentHome.FlatAppearance.BorderSize = 0;
            this.DocumentHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DocumentHome.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DocumentHome.ForeColor = System.Drawing.Color.White;
            this.DocumentHome.Location = new System.Drawing.Point(332, 0);
            this.DocumentHome.Name = "DocumentHome";
            this.DocumentHome.Size = new System.Drawing.Size(100, 37);
            this.DocumentHome.TabIndex = 0;
            this.DocumentHome.Text = "전자결재";
            this.DocumentHome.UseVisualStyleBackColor = false;
            this.DocumentHome.Click += new System.EventHandler(this.DocumentHome_Click);
            // 
            // PostHome
            // 
            this.PostHome.BackColor = System.Drawing.Color.Transparent;
            this.PostHome.FlatAppearance.BorderSize = 0;
            this.PostHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostHome.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PostHome.ForeColor = System.Drawing.Color.White;
            this.PostHome.Location = new System.Drawing.Point(222, 0);
            this.PostHome.Name = "PostHome";
            this.PostHome.Size = new System.Drawing.Size(100, 37);
            this.PostHome.TabIndex = 0;
            this.PostHome.Text = "자유게시판";
            this.PostHome.UseVisualStyleBackColor = false;
            this.PostHome.Click += new System.EventHandler(this.PostHome_Click);
            // 
            // NoticeHome
            // 
            this.NoticeHome.BackColor = System.Drawing.Color.Transparent;
            this.NoticeHome.FlatAppearance.BorderSize = 0;
            this.NoticeHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoticeHome.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoticeHome.ForeColor = System.Drawing.Color.White;
            this.NoticeHome.Location = new System.Drawing.Point(112, 0);
            this.NoticeHome.Name = "NoticeHome";
            this.NoticeHome.Size = new System.Drawing.Size(100, 37);
            this.NoticeHome.TabIndex = 0;
            this.NoticeHome.Text = "공지사항";
            this.NoticeHome.UseVisualStyleBackColor = false;
            this.NoticeHome.Click += new System.EventHandler(this.NoticeHome_Click);
            // 
            // MyPageHome
            // 
            this.MyPageHome.BackColor = System.Drawing.Color.Transparent;
            this.MyPageHome.FlatAppearance.BorderSize = 0;
            this.MyPageHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyPageHome.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MyPageHome.ForeColor = System.Drawing.Color.White;
            this.MyPageHome.Location = new System.Drawing.Point(2, 0);
            this.MyPageHome.Name = "MyPageHome";
            this.MyPageHome.Size = new System.Drawing.Size(100, 37);
            this.MyPageHome.TabIndex = 0;
            this.MyPageHome.Text = "마이페이지";
            this.MyPageHome.UseVisualStyleBackColor = false;
            this.MyPageHome.Click += new System.EventHandler(this.MyPageHome_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.MenuTab);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MenuTab;
        private System.Windows.Forms.Button PostHome;
        private System.Windows.Forms.Button NoticeHome;
        private System.Windows.Forms.Button MyPageHome;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button TeamHome;
        private System.Windows.Forms.Button EmployeeHome;
        private System.Windows.Forms.Button AttendanceHome;
        private System.Windows.Forms.Button DocumentHome;
    }
}