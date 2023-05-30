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
    public partial class BusinessWorkReport : Form
    {
        bool listViewClick;
        string docId;
        bool approval;
        RDSserver rds = new RDSserver();
        public BusinessWorkReport(bool listViewClick, string docId, bool approval)
        {
            InitializeComponent();
            this.listViewClick = listViewClick;
            this.docId = docId;
            this.approval = approval;
        }
        public BusinessWorkReport()
        {
            InitializeComponent();
        }

        private void BusinessWorkReport_Load(object sender, EventArgs e)
        {
            JObject obj = new JObject();
            if (listViewClick)
            {
                obj = rds.Read_database2("journal", docId);
                textBox1.Text = obj["title"].ToString();
                label3.Text = obj["writer"].ToString();
                label11.Text = obj["team"].ToString();
                label12.Text = obj["JG"].ToString();
                label13.Text = Convert.ToInt32(obj["date"]).ToString();
                richTextBox3.Text = obj["morning"].ToString();
                richTextBox4.Text = obj["afternoon"].ToString();
                richTextBox1.Text = obj["significant"].ToString();
                richTextBox5.Text = obj["untreated"].ToString();
                textBox1.Enabled = false;
                label3.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                richTextBox3.Enabled = false;
                richTextBox4.Enabled = false;
                richTextBox1.Enabled = false;
                richTextBox5.Enabled = false;
                if (approval)
                {
                    button1.Visible = true;
                    button2.Visible = true;
                }
                if (Convert.ToInt32(obj["state"]) == 1)
                {
                    label15.Visible = true;
                    label15.Text = "승인";
                    label15.ForeColor = Color.Blue;
                }
                else if (Convert.ToInt32(obj["state"]) == 2)
                {
                    label15.Visible = true;
                    label15.Text = "반려";
                    label15.ForeColor = Color.Red;
                }
            }
            else
            {
                label3.Text = LoginApp.user.name;
                label11.Text = LoginApp.user.team;
                label12.Text = LoginApp.user.JG;
                label13.Text = DateTime.Now.ToString("yyyyMMdd");
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("승인 되었습니다");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rds.Updatestate("journal", 2, docId);
            MessageBox.Show("반려 되었습니다");
            this.Close();
        }
    }
}
