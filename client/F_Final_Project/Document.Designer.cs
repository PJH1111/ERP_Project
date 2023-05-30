namespace F_Final_Project
{
    partial class Document
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Document));
            Logo = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            DocumentL = new System.Windows.Forms.Label();
            SelectPanel = new System.Windows.Forms.Panel();
            btnfinishedfile = new System.Windows.Forms.Button();
            btnongoingfile = new System.Windows.Forms.Button();
            btnregistration = new System.Windows.Forms.Button();
            btnfinish = new System.Windows.Forms.Button();
            btnongoing = new System.Windows.Forms.Button();
            manegersmenu = new System.Windows.Forms.Label();
            workersmenu = new System.Windows.Forms.Label();
            panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SelectPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.BackgroundImage = (System.Drawing.Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Logo.Image = (System.Drawing.Image)resources.GetObject("Logo.Image");
            Logo.Location = new System.Drawing.Point(1147, 2);
            Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Logo.Name = "Logo";
            Logo.Size = new System.Drawing.Size(85, 78);
            Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 7;
            Logo.TabStop = false;
            // 
            // panel1
            // 
            panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            panel1.BackColor = System.Drawing.SystemColors.WindowText;
            panel1.Location = new System.Drawing.Point(12, 82);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1225, 1);
            panel1.TabIndex = 9;
            // 
            // DocumentL
            // 
            DocumentL.AutoSize = true;
            DocumentL.Font = new System.Drawing.Font("휴먼모음T", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DocumentL.ForeColor = System.Drawing.SystemColors.WindowText;
            DocumentL.Location = new System.Drawing.Point(12, 24);
            DocumentL.Name = "DocumentL";
            DocumentL.Size = new System.Drawing.Size(179, 53);
            DocumentL.TabIndex = 11;
            DocumentL.Text = "전자결재";
            // 
            // SelectPanel
            // 
            SelectPanel.BackColor = System.Drawing.Color.FromArgb(33, 40, 45);
            SelectPanel.Controls.Add(btnfinishedfile);
            SelectPanel.Controls.Add(btnongoingfile);
            SelectPanel.Controls.Add(btnregistration);
            SelectPanel.Controls.Add(btnfinish);
            SelectPanel.Controls.Add(btnongoing);
            SelectPanel.Controls.Add(manegersmenu);
            SelectPanel.Controls.Add(workersmenu);
            SelectPanel.Location = new System.Drawing.Point(12, 89);
            SelectPanel.Name = "SelectPanel";
            SelectPanel.Size = new System.Drawing.Size(180, 750);
            SelectPanel.TabIndex = 12;
            // 
            // btnfinishedfile
            // 
            btnfinishedfile.BackColor = System.Drawing.Color.WhiteSmoke;
            btnfinishedfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnfinishedfile.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnfinishedfile.Location = new System.Drawing.Point(23, 335);
            btnfinishedfile.Name = "btnfinishedfile";
            btnfinishedfile.Size = new System.Drawing.Size(130, 30);
            btnfinishedfile.TabIndex = 1;
            btnfinishedfile.Text = "완료된 문서";
            btnfinishedfile.UseVisualStyleBackColor = false;
            btnfinishedfile.Visible = false;
            btnfinishedfile.Click += btnfinishedfile_Click;
            // 
            // btnongoingfile
            // 
            btnongoingfile.BackColor = System.Drawing.Color.WhiteSmoke;
            btnongoingfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnongoingfile.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnongoingfile.Location = new System.Drawing.Point(23, 293);
            btnongoingfile.Name = "btnongoingfile";
            btnongoingfile.Size = new System.Drawing.Size(130, 30);
            btnongoingfile.TabIndex = 1;
            btnongoingfile.Text = "진행중인 문서";
            btnongoingfile.UseVisualStyleBackColor = false;
            btnongoingfile.Visible = false;
            btnongoingfile.Click += btnongoingfile_Click;
            // 
            // btnregistration
            // 
            btnregistration.BackColor = System.Drawing.Color.WhiteSmoke;
            btnregistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnregistration.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnregistration.Location = new System.Drawing.Point(23, 157);
            btnregistration.Name = "btnregistration";
            btnregistration.Size = new System.Drawing.Size(130, 30);
            btnregistration.TabIndex = 1;
            btnregistration.Text = "작성";
            btnregistration.UseVisualStyleBackColor = false;
            btnregistration.Click += btnregistration_Click;
            // 
            // btnfinish
            // 
            btnfinish.BackColor = System.Drawing.Color.WhiteSmoke;
            btnfinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnfinish.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnfinish.Location = new System.Drawing.Point(23, 115);
            btnfinish.Name = "btnfinish";
            btnfinish.Size = new System.Drawing.Size(130, 30);
            btnfinish.TabIndex = 1;
            btnfinish.Text = "완료";
            btnfinish.UseVisualStyleBackColor = false;
            btnfinish.Click += btnfinish_Click;
            // 
            // btnongoing
            // 
            btnongoing.BackColor = System.Drawing.Color.WhiteSmoke;
            btnongoing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnongoing.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnongoing.Location = new System.Drawing.Point(23, 72);
            btnongoing.Name = "btnongoing";
            btnongoing.Size = new System.Drawing.Size(130, 30);
            btnongoing.TabIndex = 1;
            btnongoing.Text = "진행중";
            btnongoing.UseVisualStyleBackColor = false;
            btnongoing.Click += btnongoing_Click;
            // 
            // manegersmenu
            // 
            manegersmenu.AutoSize = true;
            manegersmenu.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            manegersmenu.ForeColor = System.Drawing.SystemColors.HighlightText;
            manegersmenu.Location = new System.Drawing.Point(66, 255);
            manegersmenu.Name = "manegersmenu";
            manegersmenu.Size = new System.Drawing.Size(39, 20);
            manegersmenu.TabIndex = 0;
            manegersmenu.Text = "승인";
            manegersmenu.Visible = false;
            // 
            // workersmenu
            // 
            workersmenu.AutoSize = true;
            workersmenu.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            workersmenu.ForeColor = System.Drawing.SystemColors.HighlightText;
            workersmenu.Location = new System.Drawing.Point(66, 37);
            workersmenu.Name = "workersmenu";
            workersmenu.Size = new System.Drawing.Size(42, 21);
            workersmenu.TabIndex = 0;
            workersmenu.Text = "결재";
            // 
            // panel
            // 
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel.Location = new System.Drawing.Point(197, 89);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(1040, 750);
            panel.TabIndex = 13;
            // 
            // Document
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Window;
            ClientSize = new System.Drawing.Size(1244, 849);
            Controls.Add(panel);
            Controls.Add(SelectPanel);
            Controls.Add(DocumentL);
            Controls.Add(panel1);
            Controls.Add(Logo);
            Name = "Document";
            Text = "Document";
            Load += Document_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            SelectPanel.ResumeLayout(false);
            SelectPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DocumentL;
        private System.Windows.Forms.Panel SelectPanel;
        private System.Windows.Forms.Label workersmenu;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnfinishedfile;
        private System.Windows.Forms.Button btnongoingfile;
        private System.Windows.Forms.Button btnregistration;
        private System.Windows.Forms.Button btnfinish;
        private System.Windows.Forms.Button btnongoing;
        private System.Windows.Forms.Label manegersmenu;
    }
}