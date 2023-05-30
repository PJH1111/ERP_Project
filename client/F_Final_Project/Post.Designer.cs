namespace F_Final_Project
{
    partial class Post
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Post));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "A123",
            "title",
            "admin",
            "20230418",
            "긴급"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PostL = new System.Windows.Forms.Label();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.Btnregistration = new System.Windows.Forms.Button();
            this.Page5 = new System.Windows.Forms.Label();
            this.Page4 = new System.Windows.Forms.Label();
            this.Page3 = new System.Windows.Forms.Label();
            this.Page2 = new System.Windows.Forms.Label();
            this.Page1 = new System.Windows.Forms.Label();
            this.NextPage = new System.Windows.Forms.Button();
            this.PreviousPage = new System.Windows.Forms.Button();
            this.search_option = new System.Windows.Forms.ComboBox();
            this.PostList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(1147, 2);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(85, 78);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
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
            // PostL
            // 
            this.PostL.AutoSize = true;
            this.PostL.Font = new System.Drawing.Font("휴먼모음T", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PostL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PostL.Location = new System.Drawing.Point(12, 24);
            this.PostL.Name = "PostL";
            this.PostL.Size = new System.Drawing.Size(218, 53);
            this.PostL.TabIndex = 10;
            this.PostL.Text = "자유게시판";
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchTextbox.Location = new System.Drawing.Point(197, 100);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(909, 35);
            this.SearchTextbox.TabIndex = 12;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearch.BackgroundImage")));
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch.Location = new System.Drawing.Point(1130, 97);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(40, 40);
            this.BtnSearch.TabIndex = 14;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Btnregistration
            // 
            this.Btnregistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.Btnregistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnregistration.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btnregistration.ForeColor = System.Drawing.SystemColors.Window;
            this.Btnregistration.Location = new System.Drawing.Point(1095, 750);
            this.Btnregistration.Name = "Btnregistration";
            this.Btnregistration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btnregistration.Size = new System.Drawing.Size(75, 50);
            this.Btnregistration.TabIndex = 43;
            this.Btnregistration.Text = "등록";
            this.Btnregistration.UseVisualStyleBackColor = false;
            this.Btnregistration.Click += new System.EventHandler(this.Btnregistration_Click);
            // 
            // Page5
            // 
            this.Page5.AutoSize = true;
            this.Page5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Page5.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Page5.Location = new System.Drawing.Point(740, 762);
            this.Page5.Name = "Page5";
            this.Page5.Size = new System.Drawing.Size(25, 30);
            this.Page5.TabIndex = 38;
            this.Page5.Text = "5";
            this.Page5.Click += new System.EventHandler(this.PageClick);
            // 
            // Page4
            // 
            this.Page4.AutoSize = true;
            this.Page4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Page4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Page4.Location = new System.Drawing.Point(678, 762);
            this.Page4.Name = "Page4";
            this.Page4.Size = new System.Drawing.Size(25, 30);
            this.Page4.TabIndex = 39;
            this.Page4.Text = "4";
            this.Page4.Click += new System.EventHandler(this.PageClick);
            // 
            // Page3
            // 
            this.Page3.AutoSize = true;
            this.Page3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Page3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Page3.Location = new System.Drawing.Point(618, 762);
            this.Page3.Name = "Page3";
            this.Page3.Size = new System.Drawing.Size(25, 30);
            this.Page3.TabIndex = 40;
            this.Page3.Text = "3";
            this.Page3.Click += new System.EventHandler(this.PageClick);
            // 
            // Page2
            // 
            this.Page2.AutoSize = true;
            this.Page2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Page2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Page2.Location = new System.Drawing.Point(558, 762);
            this.Page2.Name = "Page2";
            this.Page2.Size = new System.Drawing.Size(25, 30);
            this.Page2.TabIndex = 41;
            this.Page2.Text = "2";
            this.Page2.Click += new System.EventHandler(this.PageClick);
            // 
            // Page1
            // 
            this.Page1.AutoSize = true;
            this.Page1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Page1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Page1.Location = new System.Drawing.Point(503, 762);
            this.Page1.Name = "Page1";
            this.Page1.Size = new System.Drawing.Size(25, 30);
            this.Page1.TabIndex = 42;
            this.Page1.Text = "1";
            this.Page1.Click += new System.EventHandler(this.PageClick);
            // 
            // NextPage
            // 
            this.NextPage.BackColor = System.Drawing.Color.Transparent;
            this.NextPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextPage.BackgroundImage")));
            this.NextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextPage.FlatAppearance.BorderSize = 0;
            this.NextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextPage.Location = new System.Drawing.Point(783, 750);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(50, 50);
            this.NextPage.TabIndex = 36;
            this.NextPage.UseVisualStyleBackColor = false;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // PreviousPage
            // 
            this.PreviousPage.BackColor = System.Drawing.Color.Transparent;
            this.PreviousPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PreviousPage.BackgroundImage")));
            this.PreviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PreviousPage.FlatAppearance.BorderSize = 0;
            this.PreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreviousPage.Location = new System.Drawing.Point(432, 750);
            this.PreviousPage.Name = "PreviousPage";
            this.PreviousPage.Size = new System.Drawing.Size(50, 50);
            this.PreviousPage.TabIndex = 37;
            this.PreviousPage.UseVisualStyleBackColor = false;
            this.PreviousPage.Click += new System.EventHandler(this.PreviousPage_Click);
            // 
            // search_option
            // 
            this.search_option.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_option.FormattingEnabled = true;
            this.search_option.Items.AddRange(new object[] {
            "전체",
            "제목",
            "작성자",
            "자유"});
            this.search_option.Location = new System.Drawing.Point(70, 97);
            this.search_option.Name = "search_option";
            this.search_option.Size = new System.Drawing.Size(121, 38);
            this.search_option.TabIndex = 44;
            this.search_option.SelectedIndexChanged += new System.EventHandler(this.search_option_SelectedIndexChanged);
            // 
            // PostList
            // 
            this.PostList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.PostList.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PostList.GridLines = true;
            this.PostList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PostList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.PostList.Location = new System.Drawing.Point(70, 169);
            this.PostList.MultiSelect = false;
            this.PostList.Name = "PostList";
            this.PostList.Scrollable = false;
            this.PostList.Size = new System.Drawing.Size(1100, 530);
            this.PostList.TabIndex = 10;
            this.PostList.TileSize = new System.Drawing.Size(10, 10);
            this.PostList.UseCompatibleStateImageBehavior = false;
            this.PostList.View = System.Windows.Forms.View.Details;
            this.PostList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PostList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "번호";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "제목";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 655;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "작성자";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "날짜";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "구분";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 110;
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1244, 849);
            this.Controls.Add(this.PostList);
            this.Controls.Add(this.search_option);
            this.Controls.Add(this.Btnregistration);
            this.Controls.Add(this.Page5);
            this.Controls.Add(this.Page4);
            this.Controls.Add(this.Page3);
            this.Controls.Add(this.Page2);
            this.Controls.Add(this.Page1);
            this.Controls.Add(this.NextPage);
            this.Controls.Add(this.PreviousPage);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.PostL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Logo);
            this.Name = "Post";
            this.Text = "Post";
            this.Load += new System.EventHandler(this.Post_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PostL;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button Btnregistration;
        private System.Windows.Forms.Label Page5;
        private System.Windows.Forms.Label Page4;
        private System.Windows.Forms.Label Page3;
        private System.Windows.Forms.Label Page2;
        private System.Windows.Forms.Label Page1;
        private System.Windows.Forms.Button NextPage;
        private System.Windows.Forms.Button PreviousPage;
        private System.Windows.Forms.ComboBox search_option;
        private System.Windows.Forms.ListView PostList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}