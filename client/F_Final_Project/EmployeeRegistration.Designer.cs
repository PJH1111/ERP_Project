namespace F_Final_Project
{
    partial class EmployeeRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeRegistration));
            this.image = new System.Windows.Forms.PictureBox();
            this.btn_imageload = new System.Windows.Forms.Button();
            this.btn_imagedelete = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label_birth = new System.Windows.Forms.Label();
            this.date_birth = new System.Windows.Forms.DateTimePicker();
            this.label_tel = new System.Windows.Forms.Label();
            this.text_tel = new System.Windows.Forms.TextBox();
            this.label_addr = new System.Windows.Forms.Label();
            this.text_addr = new System.Windows.Forms.TextBox();
            this.label_mail = new System.Windows.Forms.Label();
            this.text_mail = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.label_PW = new System.Windows.Forms.Label();
            this.text_PW = new System.Windows.Forms.TextBox();
            this.label_jg = new System.Windows.Forms.Label();
            this.label_auth = new System.Windows.Forms.Label();
            this.combo_team = new System.Windows.Forms.ComboBox();
            this.combo_jg = new System.Windows.Forms.ComboBox();
            this.combo_auth = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_team = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.date_DoE = new System.Windows.Forms.DateTimePicker();
            this.label_DoE = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.Location = new System.Drawing.Point(12, 100);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(225, 218);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 30;
            this.image.TabStop = false;
            // 
            // btn_imageload
            // 
            this.btn_imageload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btn_imageload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_imageload.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_imageload.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_imageload.Location = new System.Drawing.Point(32, 324);
            this.btn_imageload.Name = "btn_imageload";
            this.btn_imageload.Size = new System.Drawing.Size(85, 35);
            this.btn_imageload.TabIndex = 31;
            this.btn_imageload.Text = "찾기";
            this.btn_imageload.UseVisualStyleBackColor = false;
            this.btn_imageload.Click += new System.EventHandler(this.btn_imageload_Click);
            // 
            // btn_imagedelete
            // 
            this.btn_imagedelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btn_imagedelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_imagedelete.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_imagedelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_imagedelete.Location = new System.Drawing.Point(131, 324);
            this.btn_imagedelete.Name = "btn_imagedelete";
            this.btn_imagedelete.Size = new System.Drawing.Size(85, 35);
            this.btn_imagedelete.TabIndex = 31;
            this.btn_imagedelete.Text = "제거";
            this.btn_imagedelete.UseVisualStyleBackColor = false;
            this.btn_imagedelete.Click += new System.EventHandler(this.btn_imagedelete_Click);
            // 
            // label_name
            // 
            this.label_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(14, 16);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(39, 20);
            this.label_name.TabIndex = 32;
            this.label_name.Text = "이름";
            // 
            // text_name
            // 
            this.text_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_name.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_name.Location = new System.Drawing.Point(71, 9);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(258, 33);
            this.text_name.TabIndex = 33;
            // 
            // label_birth
            // 
            this.label_birth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_birth.AutoSize = true;
            this.label_birth.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_birth.Location = new System.Drawing.Point(14, 67);
            this.label_birth.Name = "label_birth";
            this.label_birth.Size = new System.Drawing.Size(39, 20);
            this.label_birth.TabIndex = 32;
            this.label_birth.Text = "생일";
            // 
            // date_birth
            // 
            this.date_birth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.date_birth.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_birth.Location = new System.Drawing.Point(71, 63);
            this.date_birth.Name = "date_birth";
            this.date_birth.Size = new System.Drawing.Size(258, 27);
            this.date_birth.TabIndex = 34;
            this.date_birth.ValueChanged += new System.EventHandler(this.date_birth_ValueChanged);
            // 
            // label_tel
            // 
            this.label_tel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_tel.AutoSize = true;
            this.label_tel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_tel.Location = new System.Drawing.Point(17, 118);
            this.label_tel.Name = "label_tel";
            this.label_tel.Size = new System.Drawing.Size(34, 20);
            this.label_tel.TabIndex = 32;
            this.label_tel.Text = "Tel.";
            // 
            // text_tel
            // 
            this.text_tel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_tel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_tel.Location = new System.Drawing.Point(71, 111);
            this.text_tel.Name = "text_tel";
            this.text_tel.Size = new System.Drawing.Size(258, 33);
            this.text_tel.TabIndex = 33;
            // 
            // label_addr
            // 
            this.label_addr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_addr.AutoSize = true;
            this.label_addr.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_addr.Location = new System.Drawing.Point(14, 169);
            this.label_addr.Name = "label_addr";
            this.label_addr.Size = new System.Drawing.Size(39, 20);
            this.label_addr.TabIndex = 32;
            this.label_addr.Text = "주소";
            // 
            // text_addr
            // 
            this.text_addr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_addr.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_addr.Location = new System.Drawing.Point(71, 162);
            this.text_addr.Name = "text_addr";
            this.text_addr.Size = new System.Drawing.Size(258, 33);
            this.text_addr.TabIndex = 33;
            // 
            // label_mail
            // 
            this.label_mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_mail.AutoSize = true;
            this.label_mail.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_mail.Location = new System.Drawing.Point(14, 221);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(39, 20);
            this.label_mail.TabIndex = 32;
            this.label_mail.Text = "Mail";
            // 
            // text_mail
            // 
            this.text_mail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_mail.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_mail.Location = new System.Drawing.Point(71, 215);
            this.text_mail.Name = "text_mail";
            this.text_mail.Size = new System.Drawing.Size(258, 33);
            this.text_mail.TabIndex = 33;
            // 
            // label_ID
            // 
            this.label_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ID.Location = new System.Drawing.Point(11, 11);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(94, 20);
            this.label_ID.TabIndex = 32;
            this.label_ID.Text = "사원번호(ID)";
            // 
            // text_ID
            // 
            this.text_ID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_ID.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_ID.Location = new System.Drawing.Point(120, 8);
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(162, 27);
            this.text_ID.TabIndex = 33;
            // 
            // label_PW
            // 
            this.label_PW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_PW.AutoSize = true;
            this.label_PW.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_PW.Location = new System.Drawing.Point(313, 11);
            this.label_PW.Name = "label_PW";
            this.label_PW.Size = new System.Drawing.Size(69, 20);
            this.label_PW.TabIndex = 32;
            this.label_PW.Text = "패스워드";
            // 
            // text_PW
            // 
            this.text_PW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_PW.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_PW.Location = new System.Drawing.Point(409, 8);
            this.text_PW.Name = "text_PW";
            this.text_PW.Size = new System.Drawing.Size(162, 27);
            this.text_PW.TabIndex = 33;
            // 
            // label_jg
            // 
            this.label_jg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_jg.AutoSize = true;
            this.label_jg.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_jg.Location = new System.Drawing.Point(37, 67);
            this.label_jg.Name = "label_jg";
            this.label_jg.Size = new System.Drawing.Size(39, 20);
            this.label_jg.TabIndex = 32;
            this.label_jg.Text = "직급";
            // 
            // label_auth
            // 
            this.label_auth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_auth.AutoSize = true;
            this.label_auth.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_auth.Location = new System.Drawing.Point(37, 119);
            this.label_auth.Name = "label_auth";
            this.label_auth.Size = new System.Drawing.Size(39, 20);
            this.label_auth.TabIndex = 32;
            this.label_auth.Text = "권한";
            // 
            // combo_team
            // 
            this.combo_team.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combo_team.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combo_team.FormattingEnabled = true;
            this.combo_team.Location = new System.Drawing.Point(116, 9);
            this.combo_team.Name = "combo_team";
            this.combo_team.Size = new System.Drawing.Size(161, 33);
            this.combo_team.TabIndex = 35;
            // 
            // combo_jg
            // 
            this.combo_jg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combo_jg.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combo_jg.FormattingEnabled = true;
            this.combo_jg.Items.AddRange(new object[] {
            "사장",
            "상무",
            "이사",
            "부장",
            "차장",
            "과장",
            "대리",
            "사원"});
            this.combo_jg.Location = new System.Drawing.Point(116, 60);
            this.combo_jg.Name = "combo_jg";
            this.combo_jg.Size = new System.Drawing.Size(161, 33);
            this.combo_jg.TabIndex = 35;
            // 
            // combo_auth
            // 
            this.combo_auth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combo_auth.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combo_auth.FormattingEnabled = true;
            this.combo_auth.Items.AddRange(new object[] {
            "관리자",
            "팀장급",
            "사원"});
            this.combo_auth.Location = new System.Drawing.Point(116, 113);
            this.combo_auth.Name = "combo_auth";
            this.combo_auth.Size = new System.Drawing.Size(161, 33);
            this.combo_auth.TabIndex = 35;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_cancel.Location = new System.Drawing.Point(407, 624);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(85, 35);
            this.btn_cancel.TabIndex = 31;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_end
            // 
            this.btn_end.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btn_end.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_end.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_end.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_end.Location = new System.Drawing.Point(507, 624);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(85, 35);
            this.btn_end.TabIndex = 31;
            this.btn_end.Text = "완료";
            this.btn_end.UseVisualStyleBackColor = false;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.label_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_birth, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_tel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_addr, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.text_mail, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.date_birth, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.text_addr, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_mail, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.text_tel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.text_name, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(259, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 259);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.label_ID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.text_ID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_PW, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.text_PW, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 433);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(580, 43);
            this.tableLayoutPanel2.TabIndex = 37;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.label_team, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_jg, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label_auth, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.combo_auth, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.combo_jg, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.combo_team, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 504);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(281, 157);
            this.tableLayoutPanel3.TabIndex = 38;
            // 
            // label_team
            // 
            this.label_team.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_team.AutoSize = true;
            this.label_team.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_team.Location = new System.Drawing.Point(37, 16);
            this.label_team.Name = "label_team";
            this.label_team.Size = new System.Drawing.Size(39, 20);
            this.label_team.TabIndex = 32;
            this.label_team.Text = "부서";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Controls.Add(this.date_DoE, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label_DoE, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(299, 504);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(293, 40);
            this.tableLayoutPanel4.TabIndex = 39;
            // 
            // date_DoE
            // 
            this.date_DoE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.date_DoE.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_DoE.Location = new System.Drawing.Point(92, 6);
            this.date_DoE.Name = "date_DoE";
            this.date_DoE.Size = new System.Drawing.Size(197, 27);
            this.date_DoE.TabIndex = 34;
            this.date_DoE.ValueChanged += new System.EventHandler(this.date_DoE_ValueChanged);
            // 
            // label_DoE
            // 
            this.label_DoE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_DoE.AutoSize = true;
            this.label_DoE.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DoE.Location = new System.Drawing.Point(17, 10);
            this.label_DoE.Name = "label_DoE";
            this.label_DoE.Size = new System.Drawing.Size(54, 20);
            this.label_DoE.TabIndex = 32;
            this.label_DoE.Text = "입사일";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EmployeeRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(604, 701);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_imagedelete);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_imageload);
            this.Controls.Add(this.image);
            this.Name = "EmployeeRegistration";
            this.Text = "EmployeeRegistration";
            this.Load += new System.EventHandler(this.EmployeeRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button btn_imageload;
        private System.Windows.Forms.Button btn_imagedelete;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label_birth;
        private System.Windows.Forms.DateTimePicker date_birth;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.TextBox text_tel;
        private System.Windows.Forms.Label label_addr;
        private System.Windows.Forms.TextBox text_addr;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.TextBox text_mail;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox text_ID;
        private System.Windows.Forms.Label label_PW;
        private System.Windows.Forms.TextBox text_PW;
        private System.Windows.Forms.Label label_jg;
        private System.Windows.Forms.Label label_auth;
        private System.Windows.Forms.ComboBox combo_team;
        private System.Windows.Forms.ComboBox combo_jg;
        private System.Windows.Forms.ComboBox combo_auth;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label_team;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DateTimePicker date_DoE;
        private System.Windows.Forms.Label label_DoE;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}