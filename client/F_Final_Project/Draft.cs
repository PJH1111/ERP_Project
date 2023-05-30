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
    public partial class Draft : Form
    {
        bool listViewClick;
        string docId;
        bool approval;
        RDSserver rds = new RDSserver();

        public Draft(bool listViewClick, string docId, bool approval)
        {
            InitializeComponent();
            this.listViewClick = listViewClick;
            this.docId = docId;
            this.approval = approval;
        }
        public Draft()
        {
            InitializeComponent();
        }

        private void Draft_Load(object sender, EventArgs e)
        {
            JObject obj = new JObject();
            if (listViewClick)
            {
                obj = rds.Read_database2("Draft", docId);
                label4.Text = Convert.ToInt32(obj["number"]).ToString();
                label8.Text = obj["team"].ToString();
                label7.Text = obj["JG"].ToString();
                label10.Text = obj["writer"].ToString();
                label13.Text = Convert.ToInt32(obj["date"]).ToString();
                textBox1.Text = obj["title"].ToString();
                richTextBox1.Text = obj["remarks"].ToString();
                richTextBox2.Text = obj["detail"].ToString();
                label4.Enabled = false;
                label8.Enabled = false;
                label7.Enabled = false;
                label10.Enabled = false;
                label13.Enabled = false;
                textBox1.Enabled = false;
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
            }
            else
            {
                label4.Text = LoginApp.user.id.ToString();
                label8.Text = LoginApp.user.team;
                label7.Text = LoginApp.user.JG.ToString(); //rds.JG_dic.FirstOrDefault(x => x.Value == LoginApp.user.JG).;
                label10.Text = LoginApp.user.name;
                label13.Text = DateTime.Now.ToString("yyyyMMdd");
            }
            if (approval)
            {
                button1.Visible = true;
                button2.Visible = true;
            }
            if (Convert.ToInt32(obj["state"]) == 1)
            {
                label16.Visible = true;
                label16.Text = "승인";
                label16.ForeColor = Color.Blue;
            }
            else if (Convert.ToInt32(obj["state"]) == 2)
            {
                label16.Visible = true;
                label16.Text = "반려";
                label16.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rds.Updatestate("Draft", 1, docId);
            MessageBox.Show("승인 되었습니다");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rds.Updatestate("Draft", 2, docId);
            MessageBox.Show("반려 되었습니다");
            this.Close();
        }
    }
}
