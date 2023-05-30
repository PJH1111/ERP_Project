using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace F_Final_Project
{
    public partial class ShowWorker : Form
    {
        TextBox name = new TextBox();
        TextBox employeeNumber = new TextBox();
        TextBox tel = new TextBox();
        TextBox mail = new TextBox();
        TextBox birth = new TextBox();
        TextBox addr = new TextBox();
        TextBox DoE = new TextBox();
        ComboBox team = new ComboBox();
        ComboBox JG = new ComboBox();
        ComboBox authority = new ComboBox();

        List<object> list = new List<object>();
        string file_path;

        public ShowWorker(int id) // id == employeeNumber
        {
            InitializeComponent();

            list = LoginApp.RDs.Read_database("UserInfo", id);

            if (list != null)
            {
                workersprofile.Image = new Bitmap(new MemoryStream(LoginApp.RDs.ReadImage_database("UserInfo", id)));
            }
        }

        void modify()
        {
            // employeeNumber - text
            employeeNumber.Text = workers_id.Text;
            employeeNumber.Anchor = AnchorStyles.Left;
            employeeNumber.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            employeeNumber.Size = new Size(261, 33);
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 0));
            tableLayoutPanel1.Controls.Add(employeeNumber, 1, 0);

            // name - text
            name.Text = workers_name.Text;
            name.Anchor = AnchorStyles.Left;
            name.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            name.Size = new Size(261, 33);
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 1));
            tableLayoutPanel1.Controls.Add(name, 1, 1);

            // Tel - text
            tel.Text = workers_telnum.Text;
            tel.Anchor = AnchorStyles.Left;
            tel.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tel.Size = new Size(261, 33);
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 2));
            tableLayoutPanel1.Controls.Add(tel, 1, 2);
            // Mail - text
            mail.Text = workers_mail.Text;
            mail.Anchor = AnchorStyles.Left;
            mail.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            mail.Size = new Size(261, 33);
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 3));
            tableLayoutPanel1.Controls.Add(mail, 1, 3);
            // birth - text
            birth.Text = workers_birth.Text;
            birth.Anchor = AnchorStyles.Left;
            birth.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            birth.Size = new Size(261, 33);
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 4));
            tableLayoutPanel1.Controls.Add(birth, 1, 4);
            // addr - text
            addr.Text = workers_addr.Text;
            addr.Anchor = AnchorStyles.Left;
            addr.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addr.Size = new Size(261, 33);
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 5));
            tableLayoutPanel1.Controls.Add(addr, 1, 5);
           
            // DoE - text
            DoE.Text = workers_DoE.Text;
            DoE.Anchor = AnchorStyles.Left;
            DoE.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DoE.Size = new Size(261, 33);
            tableLayoutPanel3.Controls.Remove(tableLayoutPanel3.GetControlFromPosition(1, 0));
            tableLayoutPanel3.Controls.Add(DoE, 1, 0);

            // Team - combo
            team.Text = workers_team.Text;
            team.Items.Clear();
            foreach(string str in LoginApp.RDs.team_dic.Values)
            {
                team.Items.Add(str);
            }
            tableLayoutPanel2.Controls.Remove(tableLayoutPanel2.GetControlFromPosition(0, 1));
            tableLayoutPanel2.Controls.Add(team, 0, 1);
            
            // JG - combo
            JG.Text = workers_JG.Text;
            JG.Items.Clear();
            foreach (string str in LoginApp.RDs.JG_dic.Values)
            {
                JG.Items.Add(str);
            }
            tableLayoutPanel2.Controls.Remove(tableLayoutPanel2.GetControlFromPosition(1, 1));
            tableLayoutPanel2.Controls.Add(JG, 1, 1);
            // authority - combo
            authority.Text = workers_authority.Text;
            authority.Items.Clear();
            foreach (string str in LoginApp.RDs.authority_dic.Values)
            {
                authority.Items.Add(str);
            }
            tableLayoutPanel2.Controls.Remove(tableLayoutPanel2.GetControlFromPosition(2, 1));
            tableLayoutPanel2.Controls.Add(authority, 2, 1);
        }

        void save()
        {
            // employeeNumber - text
            workers_id.Text = employeeNumber.Text;
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 0));
            tableLayoutPanel1.Controls.Add(workers_id, 1, 0);

            // name - text
            workers_name.Text = name.Text;
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 1));
            tableLayoutPanel1.Controls.Add(workers_name, 1, 1);

            // Tel - text
            workers_telnum.Text = tel.Text;
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 2));
            tableLayoutPanel1.Controls.Add(workers_telnum, 1, 2);
            // Mail - text
            workers_mail.Text = mail.Text;
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 3));
            tableLayoutPanel1.Controls.Add(workers_mail, 1, 3);
            // birth - date
            workers_birth.Text = birth.Text;
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 4));
            tableLayoutPanel1.Controls.Add(workers_birth, 1, 4);
            // addr - text
            workers_addr.Text = addr.Text;
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 5));
            tableLayoutPanel1.Controls.Add(workers_addr, 1, 5);
            // DoE - date
            workers_DoE.Text = DoE.Text;
            tableLayoutPanel3.Controls.Remove(tableLayoutPanel3.GetControlFromPosition(1, 0));
            tableLayoutPanel3.Controls.Add(workers_DoE, 1, 0);

            // Team - combo
            workers_team.Text = team.Text;
            tableLayoutPanel2.Controls.Remove(tableLayoutPanel2.GetControlFromPosition(0, 1));
            tableLayoutPanel2.Controls.Add(workers_team, 0, 1);

            // JG - combo
            workers_JG.Text = JG.Text;
            tableLayoutPanel2.Controls.Remove(tableLayoutPanel2.GetControlFromPosition(1, 1));
            tableLayoutPanel2.Controls.Add(workers_JG, 1, 1);
            // authority - combo
            workers_authority.Text = authority.Text;
            tableLayoutPanel2.Controls.Remove(tableLayoutPanel2.GetControlFromPosition(2, 1));
            tableLayoutPanel2.Controls.Add(workers_authority, 2, 1);

            List<object> save = new List<object>() 
            {
                workers_id.Text,
                workers_name.Text,
                Convert.ToInt32(list[2]),
                LoginApp.RDs.authority_dic.FirstOrDefault(x=>x.Value==workers_authority.Text).Key,
                LoginApp.RDs.team_dic.FirstOrDefault(x=>x.Value==workers_team.Text).Key,
                LoginApp.RDs.JG_dic.FirstOrDefault(x=>x.Value==workers_JG.Text).Key,
                Convert.ToInt32(workers_birth.Text),
                workers_addr.Text,
                workers_telnum.Text,
                workers_mail.Text,
                Convert.ToInt32(workers_DoE.Text)
            };
            LoginApp.RDs.Delete_database(workers_id.Text, "UserInfo");
            LoginApp.RDs.Create_database(save, "UserInfo");

            System.Drawing.Image img = workersprofile.Image;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png); 
                byte[] bImage = ms.ToArray();
                LoginApp.RDs.UpdateImage_database(Convert.ToInt32(list[0]), "UserInfo", "img", bImage);
            }


            MessageBox.Show("수정 완료되었습니다.");
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            if (btnmodify.Text == "수정")
            {
                btnmodify.Text = "저장";
                btn_imagefind.Visible = true;
                btn_imagedelete.Visible = true;
                modify();
            }
            else
            {
                btnmodify.Text = "수정";
                btn_imagefind.Visible = false;
                btn_imagedelete.Visible = false;
                save();
            }
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ShowWorker_Load(object sender, EventArgs e)
        {
            workers_id.Text = Convert.ToString(list[0]);
            workers_name.Text = Convert.ToString(list[1]);
            workers_authority.Text = Convert.ToString(LoginApp.RDs.authority_dic[Convert.ToInt32(list[3])]);
            workers_team.Text = Convert.ToString(list[4]);
            workers_JG.Text = Convert.ToString(list[5]);
            workers_birth.Text = Convert.ToString(list[6]);
            workers_addr.Text = Convert.ToString(list[7]);
            workers_telnum.Text = Convert.ToString(list[8]);
            workers_mail.Text = Convert.ToString(list[9]);
            workers_DoE.Text = Convert.ToString(list[10]);
        }

        private void btn_imagefind_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                workersprofile.Load(file_path);
            }
        }

        private void btn_imagedelete_Click(object sender, EventArgs e)
        {
            workersprofile.Image = null;
            file_path = "";
        }
    }
}
