using Google.Protobuf.WellKnownTypes;
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
    public partial class Attendance_Manager : Form
    {
        Attendance f1;
        public Attendance_Manager(Attendance f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        List<JObject> list;

        private void Attendance_Manager_Load(object sender, EventArgs e)
        {
            Restart();
        }

        private void Restart()
        {
            WorkerList.Items.Clear();
            SelectTeam.Items.Clear();
            int num = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));

            if (LoginApp.user.authority == 0)
            {
                SelectTeam.Items.Add("연차일수");
                foreach (string str in LoginApp.RDs.team_dic.Values)
                {
                    SelectTeam.Items.Add(str);
                }
                list = LoginApp.RDs.Readdic_database("Qrcode", 1, num);

                foreach (JObject item in list)
                {
                    JObject info = LoginApp.RDs.Read_database2("UserInfo", item["employeeNumber"].ToString());

                    ListViewItem view = new ListViewItem(item["date"].ToString());
                    view.SubItems.Add(item["employeeNumber"].ToString());
                    view.SubItems.Add(info["name"].ToString());
                    string str = item["start_time"].ToString();
                    string str2 = item["end_time"].ToString();
                    if(str != null || str !="")
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
                    if(str2 != null || str2 != "")
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
                    view.SubItems.Add(str);
                    view.SubItems.Add(str2);
                    WorkerList.Items.Add(view);
                }

            }
            else if (LoginApp.user.authority == 1)
            {
                SelectTeam.Items.Add("연차일수");
                SelectTeam.Items.Add(LoginApp.user.team);

                list = LoginApp.RDs.Readdic_database("Qrcode", 1, num);

                foreach (JObject item in list)
                {
                    JObject info = LoginApp.RDs.Read_database2("UserInfo", item["employeeNumber"].ToString());
                    if (LoginApp.RDs.team_dic[Convert.ToInt32(info["team"].ToString())] != LoginApp.user.team || info["authority"].ToString() == "0")
                    {
                        continue;
                    }

                    ListViewItem view = new ListViewItem(item["date"].ToString());
                    view.SubItems.Add(item["employeeNumber"].ToString());
                    view.SubItems.Add(info["name"].ToString());
                    string str = item["start_time"].ToString();
                    string str2 = item["end_time"].ToString();
                    if (str != null || str != "")
                    {
                        if (str.Length < 6)
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
                        if (str2.Length < 6)
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
                    view.SubItems.Add(str);
                    view.SubItems.Add(str2);
                    WorkerList.Items.Add(view);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(SelectTeam.Text=="연차일수")
            {
                Attendance_Workers workers = new Attendance_Workers(LoginApp.user.id.ToString());
                f1.panel2.Controls.Clear();
                workers.TopLevel = false;
                f1.panel2.Controls.Add(workers);
                workers.ControlBox = false;
                workers.Text = null;
                workers.Parent = f1.panel2;
                workers.Show();
            }
            else
            {
                string str = SelectTeam.Text;
                WorkerList.Items.Clear();
                list = LoginApp.RDs.Readdic_database("Qrcode", 1, Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd")));
                if (LoginApp.user.authority == 0)
                {
                    foreach (JObject item in list)
                    {
                        JObject info = LoginApp.RDs.Read_database2("UserInfo", item["employeeNumber"].ToString());

                        if (LoginApp.RDs.team_dic[Convert.ToInt32(info["team"].ToString())] != str)
                        {
                            continue;
                        }
                        ListViewItem view = new ListViewItem(item["date"].ToString());
                        view.SubItems.Add(item["employeeNumber"].ToString());
                        view.SubItems.Add(info["name"].ToString());
                        string str1 = item["start_time"].ToString();
                        string str2 = item["end_time"].ToString();
                        if (str1 != null || str1 != "")
                        {
                            if (str1.Length < 6)
                            {
                                for (int i = 1; i < str1.Length; i += 3)
                                {
                                    str1 = str1.Insert(i, ":");
                                }
                            }
                            else
                            {
                                for (int i = 2; i < str1.Length; i += 3)
                                {
                                    str1 = str1.Insert(i, ":");
                                }
                            }
                        }
                        if (str2 != null || str2 != "")
                        {
                            if (str2.Length < 6)
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
                        view.SubItems.Add(str1);
                        view.SubItems.Add(str2);
                        WorkerList.Items.Add(view);

                    }
                }
                if (LoginApp.user.authority == 1)
                {
                    foreach (JObject item in list)
                    {
                        JObject info = LoginApp.RDs.Read_database2("UserInfo", item["employeeNumber"].ToString());

                        if (LoginApp.RDs.team_dic[Convert.ToInt32(info["team"].ToString())] != str || info["authority"].ToString() == "0")
                        {
                            continue;
                        }
                        ListViewItem view = new ListViewItem(item["date"].ToString());
                        view.SubItems.Add(item["employeeNumber"].ToString());
                        view.SubItems.Add(info["name"].ToString());
                        string str1 = item["start_time"].ToString();
                        string str2 = item["end_time"].ToString();
                        if (str1 != null || str1 != "")
                        {
                            if (str1.Length < 6)
                            {
                                for (int i = 1; i < str1.Length; i += 3)
                                {
                                    str1 = str1.Insert(i, ":");
                                }
                            }
                            else
                            {
                                for (int i = 2; i < str1.Length; i += 3)
                                {
                                    str1 = str1.Insert(i, ":");
                                }
                            }
                        }
                        if (str2 != null || str2 != "")
                        {
                            if (str2.Length < 6)
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
                        view.SubItems.Add(str1);
                        view.SubItems.Add(str2);
                        WorkerList.Items.Add(view);

                    }
                }
            }
        }

        private void WorkerList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string id = WorkerList.SelectedItems[0].SubItems[1].Text;

            AttendanceBrowse showWorker = new AttendanceBrowse(id);
            f1.panel2.Controls.Clear();
            showWorker.TopLevel = false;
            f1.panel2.Controls.Add(showWorker);
            showWorker.Text = null;
            showWorker.ControlBox = false;
            showWorker.Parent = f1.panel2;
            showWorker.Show();
        }

        private void WorkerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
