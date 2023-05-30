namespace F_Final_Project
{
    partial class EmployeeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagement));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("0");
            this.panel1 = new System.Windows.Forms.Panel();
            this.ManagementL = new System.Windows.Forms.Label();
            this.WorkersMenu = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.WorkerList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.btnprevPage = new System.Windows.Forms.Button();
            this.page1 = new System.Windows.Forms.Label();
            this.page2 = new System.Windows.Forms.Label();
            this.page3 = new System.Windows.Forms.Label();
            this.page4 = new System.Windows.Forms.Label();
            this.page5 = new System.Windows.Forms.Label();
            this.btnnextPage = new System.Windows.Forms.Button();
            this.btnregistration = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
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
            // ManagementL
            // 
            this.ManagementL.AutoSize = true;
            this.ManagementL.Font = new System.Drawing.Font("휴먼모음T", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManagementL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ManagementL.Location = new System.Drawing.Point(13, 23);
            this.ManagementL.Name = "ManagementL";
            this.ManagementL.Size = new System.Drawing.Size(179, 53);
            this.ManagementL.TabIndex = 12;
            this.ManagementL.Text = "사원관리";
            // 
            // WorkersMenu
            // 
            this.WorkersMenu.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkersMenu.FormattingEnabled = true;
            this.WorkersMenu.Items.AddRange(new object[] {
            "이름",
            "사원번호",
            "부서"});
            this.WorkersMenu.Location = new System.Drawing.Point(12, 97);
            this.WorkersMenu.Name = "WorkersMenu";
            this.WorkersMenu.Size = new System.Drawing.Size(121, 33);
            this.WorkersMenu.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(618, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 740);
            this.panel2.TabIndex = 15;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchTextbox.Location = new System.Drawing.Point(139, 97);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(406, 33);
            this.SearchTextbox.TabIndex = 16;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearch.BackgroundImage")));
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("함초롬돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch.Location = new System.Drawing.Point(551, 90);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(40, 40);
            this.BtnSearch.TabIndex = 17;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // WorkerList
            // 
            this.WorkerList.BackColor = System.Drawing.SystemColors.Window;
            this.WorkerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.WorkerList.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkerList.GridLines = true;
            this.WorkerList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.WorkerList.Location = new System.Drawing.Point(11, 136);
            this.WorkerList.Name = "WorkerList";
            this.WorkerList.Size = new System.Drawing.Size(580, 617);
            this.WorkerList.TabIndex = 18;
            this.WorkerList.UseCompatibleStateImageBehavior = false;
            this.WorkerList.View = System.Windows.Forms.View.Details;
            this.WorkerList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WorkerList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "사원번호";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "이름";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "부서";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "직급";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 105;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "E-Mail";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 145;
            // 
            // btnprevPage
            // 
            this.btnprevPage.BackColor = System.Drawing.Color.Transparent;
            this.btnprevPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnprevPage.BackgroundImage")));
            this.btnprevPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnprevPage.FlatAppearance.BorderSize = 0;
            this.btnprevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprevPage.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnprevPage.Location = new System.Drawing.Point(205, 778);
            this.btnprevPage.Name = "btnprevPage";
            this.btnprevPage.Size = new System.Drawing.Size(30, 30);
            this.btnprevPage.TabIndex = 17;
            this.btnprevPage.UseVisualStyleBackColor = false;
            this.btnprevPage.Click += new System.EventHandler(this.btnprevPage_Click);
            // 
            // page1
            // 
            this.page1.AutoSize = true;
            this.page1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.page1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.page1.Location = new System.Drawing.Point(241, 781);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(23, 25);
            this.page1.TabIndex = 19;
            this.page1.Text = "1";
            this.page1.Click += new System.EventHandler(this.Page_Click);
            // 
            // page2
            // 
            this.page2.AutoSize = true;
            this.page2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.page2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.page2.Location = new System.Drawing.Point(266, 781);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(23, 25);
            this.page2.TabIndex = 19;
            this.page2.Text = "2";
            this.page2.Click += new System.EventHandler(this.Page_Click);
            // 
            // page3
            // 
            this.page3.AutoSize = true;
            this.page3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.page3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.page3.Location = new System.Drawing.Point(291, 781);
            this.page3.Name = "page3";
            this.page3.Size = new System.Drawing.Size(23, 25);
            this.page3.TabIndex = 19;
            this.page3.Text = "3";
            this.page3.Click += new System.EventHandler(this.Page_Click);
            // 
            // page4
            // 
            this.page4.AutoSize = true;
            this.page4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.page4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.page4.Location = new System.Drawing.Point(316, 781);
            this.page4.Name = "page4";
            this.page4.Size = new System.Drawing.Size(23, 25);
            this.page4.TabIndex = 19;
            this.page4.Text = "4";
            this.page4.Click += new System.EventHandler(this.Page_Click);
            // 
            // page5
            // 
            this.page5.AutoSize = true;
            this.page5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.page5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.page5.Location = new System.Drawing.Point(340, 781);
            this.page5.Name = "page5";
            this.page5.Size = new System.Drawing.Size(23, 25);
            this.page5.TabIndex = 19;
            this.page5.Text = "5";
            this.page5.Click += new System.EventHandler(this.Page_Click);
            // 
            // btnnextPage
            // 
            this.btnnextPage.BackColor = System.Drawing.Color.Transparent;
            this.btnnextPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnextPage.BackgroundImage")));
            this.btnnextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnextPage.FlatAppearance.BorderSize = 0;
            this.btnnextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnextPage.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnnextPage.Location = new System.Drawing.Point(369, 778);
            this.btnnextPage.Name = "btnnextPage";
            this.btnnextPage.Size = new System.Drawing.Size(30, 30);
            this.btnnextPage.TabIndex = 17;
            this.btnnextPage.UseVisualStyleBackColor = false;
            this.btnnextPage.Click += new System.EventHandler(this.btnnextPage_Click);
            // 
            // btnregistration
            // 
            this.btnregistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btnregistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistration.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnregistration.ForeColor = System.Drawing.SystemColors.Window;
            this.btnregistration.Location = new System.Drawing.Point(535, 778);
            this.btnregistration.Name = "btnregistration";
            this.btnregistration.Size = new System.Drawing.Size(56, 30);
            this.btnregistration.TabIndex = 17;
            this.btnregistration.TabStop = false;
            this.btnregistration.Text = "등록";
            this.btnregistration.UseVisualStyleBackColor = false;
            this.btnregistration.Click += new System.EventHandler(this.btnregistration_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(1147, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(85, 78);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 20;
            this.Logo.TabStop = false;
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1244, 849);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.page5);
            this.Controls.Add(this.page4);
            this.Controls.Add(this.page3);
            this.Controls.Add(this.page2);
            this.Controls.Add(this.page1);
            this.Controls.Add(this.btnregistration);
            this.Controls.Add(this.btnnextPage);
            this.Controls.Add(this.btnprevPage);
            this.Controls.Add(this.WorkerList);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.WorkersMenu);
            this.Controls.Add(this.ManagementL);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeManagement";
            this.Text = "EmployeeManagement";
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ManagementL;
        private System.Windows.Forms.ComboBox WorkersMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ListView WorkerList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnprevPage;
        private System.Windows.Forms.Label page1;
        private System.Windows.Forms.Label page2;
        private System.Windows.Forms.Label page3;
        private System.Windows.Forms.Label page4;
        private System.Windows.Forms.Label page5;
        private System.Windows.Forms.Button btnnextPage;
        private System.Windows.Forms.Button btnregistration;
        private System.Windows.Forms.PictureBox Logo;
    }
}