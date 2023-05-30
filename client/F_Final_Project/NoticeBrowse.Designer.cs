namespace F_Final_Project
{
    partial class NoticeBrowse
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
            this.btnmodify = new System.Windows.Forms.Button();
            this.Substance = new System.Windows.Forms.RichTextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncheck = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.labeldump = new System.Windows.Forms.Label();
            this.label_wdate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_division = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.introduction = new System.Windows.Forms.ComboBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnmodify
            // 
            this.btnmodify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btnmodify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmodify.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmodify.ForeColor = System.Drawing.SystemColors.Window;
            this.btnmodify.Location = new System.Drawing.Point(120, 12);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(48, 23);
            this.btnmodify.TabIndex = 1;
            this.btnmodify.Text = "수정";
            this.btnmodify.UseVisualStyleBackColor = false;
            this.btnmodify.Visible = false;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // Substance
            // 
            this.Substance.BackColor = System.Drawing.SystemColors.Window;
            this.Substance.Location = new System.Drawing.Point(12, 142);
            this.Substance.Name = "Substance";
            this.Substance.ReadOnly = true;
            this.Substance.Size = new System.Drawing.Size(510, 507);
            this.Substance.TabIndex = 3;
            this.Substance.Text = "";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(505, 142);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 507);
            this.vScrollBar1.TabIndex = 4;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btndelete.Location = new System.Drawing.Point(66, 12);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(48, 23);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "삭제";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Visible = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btncheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncheck.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncheck.ForeColor = System.Drawing.SystemColors.Window;
            this.btncheck.Location = new System.Drawing.Point(12, 12);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(48, 23);
            this.btncheck.TabIndex = 1;
            this.btncheck.Text = "확인";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_id, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labeldump, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_wdate, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_division, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 61);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "작성자";
            // 
            // label_name
            // 
            this.label_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(148, 7);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(34, 15);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "OOO";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "문서ID";
            // 
            // label_id
            // 
            this.label_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(402, 7);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(34, 15);
            this.label_id.TabIndex = 5;
            this.label_id.Text = "OOO";
            // 
            // labeldump
            // 
            this.labeldump.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeldump.AutoSize = true;
            this.labeldump.Location = new System.Drawing.Point(264, 37);
            this.labeldump.Name = "labeldump";
            this.labeldump.Size = new System.Drawing.Size(55, 15);
            this.labeldump.TabIndex = 6;
            this.labeldump.Text = "작성날짜";
            // 
            // label_wdate
            // 
            this.label_wdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_wdate.AutoSize = true;
            this.label_wdate.Location = new System.Drawing.Point(388, 37);
            this.label_wdate.Name = "label_wdate";
            this.label_wdate.Size = new System.Drawing.Size(63, 15);
            this.label_wdate.TabIndex = 7;
            this.label_wdate.Text = "20000000";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "작성구분";
            // 
            // label_division
            // 
            this.label_division.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_division.AutoSize = true;
            this.label_division.Location = new System.Drawing.Point(143, 37);
            this.label_division.Name = "label_division";
            this.label_division.Size = new System.Drawing.Size(43, 15);
            this.label_division.TabIndex = 9;
            this.label_division.Text = "OOOO";
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(225, 12);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(135, 15);
            this.label_title.TabIndex = 11;
            this.label_title.Text = "제목은 자동으로 뜹니다";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "제목";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.90196F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.09804F));
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_title, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 100);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(510, 39);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // introduction
            // 
            this.introduction.FormattingEnabled = true;
            this.introduction.Items.AddRange(new object[] {
            "일반",
            "긴급",
            "안내"});
            this.introduction.Location = new System.Drawing.Point(160, 238);
            this.introduction.Name = "introduction";
            this.introduction.Size = new System.Drawing.Size(121, 23);
            this.introduction.TabIndex = 13;
            this.introduction.Visible = false;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(66, 189);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(408, 23);
            this.txt_title.TabIndex = 14;
            this.txt_title.Visible = false;
            // 
            // NoticeBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(534, 661);
            this.Controls.Add(this.Substance);
            this.Controls.Add(this.introduction);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.btnmodify);
            this.Controls.Add(this.txt_title);
            this.Name = "NoticeBrowse";
            this.Text = "NoticeBrowse";
            this.Load += new System.EventHandler(this.NoticeBrowse_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnmodify;
        private System.Windows.Forms.RichTextBox Substance;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label labeldump;
        private System.Windows.Forms.Label label_wdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_division;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox introduction;
        private System.Windows.Forms.TextBox txt_title;
    }
}