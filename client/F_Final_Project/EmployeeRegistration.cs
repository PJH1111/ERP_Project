using Microsoft.VisualBasic.Logging;
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
using System.Xml.Linq;

namespace F_Final_Project
{
    public partial class EmployeeRegistration : Form
    {
        string file_path="";
        string save_birth="";
        string save_DoE="";

        public EmployeeRegistration()
        {
            InitializeComponent();
        }

        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {
            foreach(string name in LoginApp.RDs.team_dic.Values)
            {
                combo_team.Items.Add(name);
            }
            save_birth = date_birth.Value.ToString();
            save_birth = Regex.Replace(save_birth, @"\D", "");
            save_birth = save_birth.Substring(0, 8);  // ex) 981111
            save_DoE = date_DoE.Value.ToString();
            save_DoE = Regex.Replace(save_DoE, @"\D", "");
            save_DoE = save_DoE.Substring(0, 8); // ex) 20230505
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            if(text_ID.Text == "" || !int.TryParse(text_ID.Text, out int id))
            {
                MessageBox.Show("잘못된 형식의 사원 번호입니다");
                return;
            }
            else if(text_name.Text=="")
            {
                MessageBox.Show("잘못된 형식의 이름입니다");
                return;
            }
            else if (text_PW.Text == "" || !int.TryParse(text_PW.Text,out int pw))
            {
                MessageBox.Show("잘못된 형식의 비밀번호입니다");
                return;
            }
            else if (combo_auth.Text == "" ||   !combo_auth.Items.Contains(combo_auth.Text) )
            {
                MessageBox.Show("권한 부여가 필요합니다");
                return;
            }
            else if (combo_team.Text == "" || !combo_team.Items.Contains(combo_team.Text))
            {
                MessageBox.Show("부서 배치가 필요합니다");
                return;
            }
            else if (combo_jg.Text == "" || !combo_jg.Items.Contains(combo_jg.Text))
            {
                MessageBox.Show("직급 부여가 필요합니다");
                return;
            }
            else if (text_addr.Text == "")
            {
                MessageBox.Show("잘못된 형식의 주소입니다");
                return;
            }
            else if(text_tel.Text == "")
            {
                MessageBox.Show("잘못된 형식의 전화번호입니다");
                return;
            }
            else if(text_mail.Text == "")
            {
                MessageBox.Show("잘못된 형식의 메일입니다");
                return;
            }



            List<object> userdata = new List<object>()
            {   text_ID.Text,
                text_name.Text,
                Convert.ToInt32(text_PW.Text),
                LoginApp.RDs.authority_dic.FirstOrDefault(x=>x.Value==combo_auth.Text).Key,
                LoginApp.RDs.team_dic.FirstOrDefault(x=>x.Value==combo_team.Text).Key,
                LoginApp.RDs.JG_dic.FirstOrDefault(x=>x.Value==combo_jg.Text).Key,
                save_birth,
                text_addr.Text,
                text_tel.Text,
                text_mail.Text,
                save_DoE
            };

            LoginApp.RDs.Create_database(userdata, "UserInfo");
            if(file_path != "")
            {
                FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.Read);  // file_path: 이미지 위치
                byte[] bImage = new byte[fs.Length];
                fs.Read(bImage, 0, (int)fs.Length);
                fs.Close();
                LoginApp.RDs.UpdateImage_database(Convert.ToInt32(userdata[0]), "UserInfo", "img", bImage);
            }


            MessageBox.Show("사원이 등록되었습니다.");
            this.Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("등록 취소되었습니다.");
            foreach (Control control in this.Controls)
            {
                control.Text = "";
            }
            this.Dispose();
        }

        private void btn_imageload_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                image.Load(file_path);
            }
        }

        private void btn_imagedelete_Click(object sender, EventArgs e)
        {
            this.image.Image = null;
            file_path = "";
        }

        private void date_birth_ValueChanged(object sender, EventArgs e)
        {
            save_birth = date_birth.Value.ToString();
            save_birth = Regex.Replace(save_birth, @"\D", "");
            save_birth = save_birth.Substring(0, 8);  // ex) 19981111
        }

        private void date_DoE_ValueChanged(object sender, EventArgs e)
        {
            save_DoE = date_DoE.Value.ToString();
            save_DoE = Regex.Replace(save_DoE, @"\D", "");
            save_DoE = save_DoE.Substring(0, 8); // ex) 20230505
        }

       
    }
}
