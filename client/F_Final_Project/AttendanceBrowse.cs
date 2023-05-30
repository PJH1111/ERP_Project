using MySqlX.XDevAPI.Relational;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_Final_Project
{
    public partial class AttendanceBrowse : Form
    {
        public AttendanceBrowse()
        {
            InitializeComponent();

        }
        string num;
        JObject info = new JObject();
        List<JObject> list2 = new List<JObject>();
        
        public AttendanceBrowse(string id)
        {
            InitializeComponent();
            num = id;
            info = LoginApp.RDs.Read_database2("UserInfo", id);
            labelWorksName.Text = info["name"].ToString();
        }

        void restart()
        {
            listView1.Items.Clear();
            List<JObject> list = new List<JObject>();
            list = LoginApp.RDs.Readdic_database("Qrcode", 0, Convert.ToInt32(num));
            list2 = list.OrderByDescending(item => item["date"]).ToList();

            foreach (JObject item in list2)
            {
                ListViewItem item2 = new ListViewItem(item["date"].ToString());
                string str = item["start_time"].ToString();
                string str2 = item["end_time"].ToString();
                if (str != null || str != "")
                {
                    if(str.Length < 6)
                    {
                        for (int i = 1; i < str.Length; i += 3)
                        {
                            str = str.Insert(i, ":");
                        }
                    }
                    else
                    {
                        for (int i = 2; i < str.Length; i += 3)
                        {
                            str = str.Insert(i, ":");
                        }
                    }
                }
                if (str2 != null || str2 != "")
                {
                    if(str2.Length < 6)
                    {
                        for (int i = 1; i < str2.Length; i += 3)
                        {
                            str2 = str2.Insert(i, ":");
                        }
                    }
                    else
                    {
                        for (int i = 2; i < str2.Length; i += 3)
                        {
                            str2 = str2.Insert(i, ":");
                        }
                    }
                }
                item2.SubItems.Add(str);
                item2.SubItems.Add(str2);
                listView1.Items.Add(item2);
            }

        }
        private void AttendanceBrowse_Load(object sender, EventArgs e)
        {
            restart();
            if(LoginApp.user.authority<2)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text_start.Text = text_start.Text.Trim();
            text_end.Text = text_end.Text.Trim();
            if (button1.Text == "수정" && listView1.SelectedItems.Count != 0)
            {
                button1.Text = "저장";
                text_start.Visible = true;
                text_end.Visible=true;
                label_end.Visible = true;
                label_start.Visible = true;
                text_start.Text = listView1.SelectedItems[0].SubItems[1].Text;
                text_end.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
            else if(button1.Text=="저장"&& text_check(text_start.Text)&& text_check(text_end.Text))
            {
                button1.Text = "수정";
                text_start.Visible = false;
                text_end.Visible = false;
                label_end.Visible = false;
                label_start.Visible = false;
                List<object> list = new List<object>();
                list.Add(Convert.ToInt32(num));
                list.Add(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
                List<object> list2 = new List<object>();
                list2.Add(Convert.ToInt32(num));
                list2.Add(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
                list2.Add(text_start.Text!=""?Convert.ToInt32(text_start.Text.Replace(":", "")):null);
                list2.Add(text_end.Text!=""?Convert.ToInt32(text_end.Text.Replace(":", "")):null);
                LoginApp.RDs.Delete_database(list, "Qrcode");
                LoginApp.RDs.Create_database(list2, "Qrcode");
                text_start.Text = "";
                text_end.Text = "";
                restart();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        bool text_check(string time)
        {
            if (time == "")
                return true;
            try
            {
                string[] str = time.Split(":");
                if (Convert.ToInt32(str[0]) < 0 || Convert.ToInt32(str[0]) > 24)
                {
                    MessageBox.Show("잘못된 형식입니다.");
                    return false;
                }
                if(Convert.ToInt32(str[1])<0 || Convert.ToInt32(str[1])>59)
                {
                    MessageBox.Show("잘못된 형식입니다.");
                    return false;
                }
                if(Convert.ToInt32(str[2])<0 || Convert.ToInt32(str[2])>59)
                {
                    MessageBox.Show("잘못된 형식입니다.");
                    return false;
                }
                return true;
            }
            catch 
            {
                MessageBox.Show("잘못된 형식입니다.");
                return false;
            }
        }

    }
}
