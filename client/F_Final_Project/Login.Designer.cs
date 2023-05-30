namespace F_Final_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TextL = new System.Windows.Forms.Label();
            this.Click_LogIN = new System.Windows.Forms.Button();
            this.InputPW = new System.Windows.Forms.TextBox();
            this.InputID = new System.Windows.Forms.TextBox();
            this.PW = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // TextL
            // 
            this.TextL.AutoSize = true;
            this.TextL.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextL.Location = new System.Drawing.Point(732, 132);
            this.TextL.Name = "TextL";
            this.TextL.Size = new System.Drawing.Size(0, 87);
            this.TextL.TabIndex = 27;
            // 
            // Click_LogIN
            // 
            this.Click_LogIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.Click_LogIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Click_LogIN.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Click_LogIN.ForeColor = System.Drawing.Color.White;
            this.Click_LogIN.Location = new System.Drawing.Point(517, 696);
            this.Click_LogIN.Name = "Click_LogIN";
            this.Click_LogIN.Size = new System.Drawing.Size(250, 50);
            this.Click_LogIN.TabIndex = 26;
            this.Click_LogIN.Text = "로그인";
            this.Click_LogIN.UseVisualStyleBackColor = false;
            this.Click_LogIN.Click += new System.EventHandler(this.Click_LogIN_Click);
            // 
            // InputPW
            // 
            this.InputPW.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InputPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputPW.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputPW.Location = new System.Drawing.Point(411, 584);
            this.InputPW.Name = "InputPW";
            this.InputPW.Size = new System.Drawing.Size(494, 36);
            this.InputPW.TabIndex = 25;
            this.InputPW.UseSystemPasswordChar = true;
            // 
            // InputID
            // 
            this.InputID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InputID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputID.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputID.Location = new System.Drawing.Point(411, 461);
            this.InputID.Name = "InputID";
            this.InputID.Size = new System.Drawing.Size(494, 36);
            this.InputID.TabIndex = 24;
            // 
            // PW
            // 
            this.PW.AutoSize = true;
            this.PW.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PW.Location = new System.Drawing.Point(328, 579);
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(72, 45);
            this.PW.TabIndex = 23;
            this.PW.Text = "PW";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(333, 456);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(54, 45);
            this.ID.TabIndex = 22;
            this.ID.Text = "ID";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(464, 46);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(350, 350);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 21;
            this.Logo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.TextL);
            this.Controls.Add(this.Click_LogIN);
            this.Controls.Add(this.InputPW);
            this.Controls.Add(this.InputID);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Logo);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextL;
        private System.Windows.Forms.Button Click_LogIN;
        private System.Windows.Forms.TextBox InputPW;
        private System.Windows.Forms.TextBox InputID;
        private System.Windows.Forms.Label PW;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.PictureBox Logo;
    }
}