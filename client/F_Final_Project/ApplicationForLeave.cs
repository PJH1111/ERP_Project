using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_Final_Project
{
    public partial class ApplicationForLeave : Form
    {
        bool listViewClick;
        bool approval;
        string docId;
        RDSserver rds = new RDSserver();
        public ApplicationForLeave(bool listViewClick, string docId, bool approval)
        {
            InitializeComponent();
            this.listViewClick = listViewClick;
            this.docId = docId;
            this.approval = approval;
        }
        public ApplicationForLeave()
        {
            InitializeComponent();
        }
        private void ApplicationForLeave_Load(object sender, EventArgs e)
        {
            JObject obj = new JObject();
            if (listViewClick)
            {
                obj = rds.Read_database2("ApplicationForLeave", docId);
                WorkersName.Text = obj["writer"].ToString();
                WorkersTeam.Text = obj["team"].ToString();
                textBox1.Text = obj["title"].ToString();
                comboBox1.Text = obj["startdate"].ToString().Substring(0, 4);
                comboBox2.Text = obj["startdate"].ToString().Substring(4, 2);
                comboBox3.Text = obj["startdate"].ToString().Substring(6, 2);
                comboBox4.Text = obj["endDate"].ToString().Substring(0, 4);
                comboBox5.Text = obj["endDate"].ToString().Substring(4, 2);
                comboBox6.Text = obj["endDate"].ToString().Substring(6, 2);
                textBox2.Text = obj["emergencyTel"].ToString();
                richTextBox1.Text = obj["reason"].ToString();
                if(approval)
                {
                    button1.Visible = true;
                    button2.Visible = true;
                }
                if (Convert.ToInt32(obj["state"]) == 1)
                {
                    label14.Visible = true;
                    label14.Text = "승인";
                    label14.ForeColor = Color.Blue;
                }
                else if (Convert.ToInt32(obj["state"]) == 2)
                {
                    label14.Visible = true;
                    label14.Text = "반려";
                    label14.ForeColor = Color.Red;
                }
                WorkersName.Enabled = false;
                WorkersTeam.Enabled = false;
                textBox1.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                textBox2.Enabled = false;
                richTextBox1.Enabled = false;               
            }
            else
            {
                WorkersName.Text = LoginApp.user.name;
                WorkersTeam.Text = LoginApp.user.team;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JObject obj = new JObject();
            JObject obj2 = new JObject();
            List<object> list = new List<object>();
            obj = rds.Read_database2("ApplicationForLeave", docId);
            obj2 = rds.ReademployeeNumber(obj["writer"].ToString());
            list.Add(obj2["employeeNumber"]);
            list.Add(obj["startdate"]);
            list.Add(obj["endDate"]);
            rds.Create_database(list, "AnnualLeave");
            rds.Updatestate("ApplicationForLeave", 1, docId);
            //rds.올라가는거 휴가
            MessageBox.Show("승인 되었습니다");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rds.Updatestate("ApplicationForLeave", 2, docId);
            MessageBox.Show("반려 되었습니다");
            this.Close();
        }
    }
}
