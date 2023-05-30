using K4os.Compression.LZ4.Internal;
using MySqlX.XDevAPI.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Mysqlx.Datatypes.Scalar.Types;
using static System.Net.WebRequestMethods;

namespace F_Final_Project
{
    public partial class DocumentRegistration : Form
    {
        ApplicationForLeave applicationForLeave = new ApplicationForLeave();
        BusinessWorkReport businessWorkReport = new BusinessWorkReport();
        Draft draft = new Draft();
        RDSserver rds = new RDSserver();
        string ip = "http://13.209.6.6:8080";
        List<string> idList = new List<string>();
        public DocumentRegistration()
        {
            InitializeComponent();
        }

        private void DocumentRegistration_Load(object sender, EventArgs e)
        {
            //id 값 가져오는거 해야됨
        }

        private void btnforLeave_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            applicationForLeave.TopLevel = false;
            panel1.Controls.Add(applicationForLeave);
            applicationForLeave.Text = null;
            applicationForLeave.ControlBox = false;
            applicationForLeave.Parent = panel1;
            applicationForLeave.Show();
        }

        private void btnforWork_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            businessWorkReport.TopLevel = false;
            panel1.Controls.Add(businessWorkReport);
            businessWorkReport.Text = null;
            businessWorkReport.ControlBox = false;
            businessWorkReport.Parent = panel1;
            businessWorkReport.Show();
        }

        private void btnforPurchase_Click(object sender, EventArgs e)
        {          
            panel1.Controls.Clear();
            draft.TopLevel = false;
            panel1.Controls.Add(draft);
            draft.Text = null;
            draft.ControlBox = false;
            draft.Parent = panel1;
            draft.Show();
        }

        private void SelectMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectMenu.SelectedIndex == 0)
            {
                panel1.Controls.Clear();
                applicationForLeave.TopLevel = false;
                panel1.Controls.Add(applicationForLeave);
                applicationForLeave.Text = null;
                applicationForLeave.ControlBox = false;
                applicationForLeave.Parent = panel1;
                applicationForLeave.Show();
            }

            else if (SelectMenu.SelectedIndex == 1)
            {
                panel1.Controls.Clear();
                businessWorkReport.TopLevel = false;
                panel1.Controls.Add(businessWorkReport);
                businessWorkReport.Text = null;
                businessWorkReport.ControlBox = false;
                businessWorkReport.Parent = panel1;
                businessWorkReport.Show();
            }

            else if (SelectMenu.SelectedIndex == 2)
            {
                panel1.Controls.Clear();
                draft.TopLevel = false;
                panel1.Controls.Add(draft);
                draft.Text = null;
                draft.ControlBox = false;
                draft.Parent = panel1;
                draft.Show();
            }
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            if (SelectMenu.SelectedItem.ToString() == "휴가신청서")
            {
                string name = applicationForLeave.WorkersName.Text;
                string tName = applicationForLeave.WorkersTeam.Text;
                string Title = applicationForLeave.textBox1.Text;
                int Startdate = Int32.Parse(applicationForLeave.comboBox1.SelectedItem.ToString() + applicationForLeave.comboBox2.SelectedItem.ToString() + applicationForLeave.comboBox3.SelectedItem.ToString());
                int EndDate = Int32.Parse(applicationForLeave.comboBox4.SelectedItem.ToString() + applicationForLeave.comboBox5.SelectedItem.ToString() + applicationForLeave.comboBox6.SelectedItem.ToString());
                string EmergencyTel = applicationForLeave.textBox2.Text.ToString();
                string Reason = applicationForLeave.richTextBox1.Text;
                string id = randomID("X");
                int state = 0;
                int type = 1;
                int date = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                CreateApplicationForLeave(name, tName, Title, Startdate, EndDate, EmergencyTel, Reason, id, state, type,date);
                applicationForLeave.Refresh();
            }
            else if (SelectMenu.SelectedItem.ToString() == "일일업무보고서")
            {
                string title = businessWorkReport.textBox1.Text;
                string Writer = businessWorkReport.label3.Text;
                string team = businessWorkReport.label11.Text;
                string JG = businessWorkReport.label12.Text;
                int date = int.Parse(businessWorkReport.label13.Text);
                string Morning = businessWorkReport.richTextBox3.Text;
                string Afternoon = businessWorkReport.richTextBox4.Text;
                string Significan = businessWorkReport.richTextBox1.Text;
                string Untreated = businessWorkReport.richTextBox5.Text;
                string id = randomID("Y");
                int state = 0;
                int type = 2;
                CreateJournal(title,Writer, team , JG, date,Morning, Afternoon, Significan, Untreated, id, state, type);
            }
            else if (SelectMenu.SelectedItem.ToString() == "기안서")
            {
                int  number = int.Parse(draft.label4.Text);
                string team = draft.label8.Text;
                string JG = draft.label7.Text;
                string writer= draft.label10.Text;
                int date = int.Parse(draft.label13.Text);
                string title = draft.textBox1.Text;
                string remarks = draft.richTextBox1.Text;
                string detail = draft.richTextBox2.Text;
                string id = randomID("Z");
                int state = 0;
                int type = 3;
                CreateDraft(number, team, JG , writer, date, title, remarks, detail, id,state , type);
            }
            MessageBox.Show("작성이 완료되었습니다");
        }

        public void CreateApplicationForLeave(string name, string tName, string Title, int Startdate, int EndDate, string EmergencyTel, string Reason, string Id, int State,
            int Type, int Date)
        {
            string url = string.Format("{0}/AddApplicationForLeave", ip);

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";

                var data = new
                {
                    writer = name,
                    team = tName,
                    title = Title,
                    startdate = Startdate,
                    endDate = EndDate,
                    emergencyTel = EmergencyTel,
                    reason = Reason,
                    id = Id,
                    state = State,
                    type = Type,
                    date = Date                
                };

                string json = JsonConvert.SerializeObject(data);
                string result = client.UploadString(url, json);
            }               
        }

        public void CreateJournal(string Title, string Writer, string Team, string jg, int Date, string Morning, string Afternoon, string Significant,
            string Untreated, string Id, int State, int Type)
        {
            string url = string.Format("{0}/AddJournal", ip);
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                var data = new {title = Title, writer = Writer, team = Team, JG = jg, date = Date, morning = Morning, afternoon = Afternoon, significant = Significant
                    , untreated = Untreated, id = Id, state = State, type = Type};
                string json = JsonConvert.SerializeObject(data);
                string result = client.UploadString(url, json);
            }
        }

        public void CreateDraft(int Number, string Team, string jg, string Writer,int date, string Title, string Remarks, string Detail, string Id, int State, int Type)
        {
            string url = string.Format("{0}/AddDraft", ip);
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                var data = new { number=Number, team = Team, JG=jg, writer = Writer, Date = date, title = Title, remarks = Remarks, detail = Detail, id = Id,state=State , type = Type};
                string json = JsonConvert.SerializeObject(data);
                string result = client.UploadString(url, json);
            }
        }
        public string randomID(string type)
        {
            RDSserver rds = new RDSserver();
            List<JObject> list = new List<JObject>();
            List<string> listID = new List<string>();
            string id;
            if (type == "X")
            {
                list = rds.Readdic_database("ApplicationForLeave", -1);
            }
            else if(type == "Y")
            {
                list = rds.Readdic_database("journal", -1);
               
            }
            else if(type == "Z")
            {
                list = rds.Readdic_database("Draft", -1);
            }
            foreach (JObject i in list)
            {
                listID.Add(i["id"].ToString());
            }
            return duplicateInspection(listID, type);
        }

        public string duplicateInspection(List<string> strings, string type)
        {
            Random rand = new Random();
            string id = "";
            while (true)
            {
                id = "";          
                id = type + rand.Next(1000, 10000).ToString();
                if (strings.Contains(id))
                    continue;
                else
                    break;
            }
            return id;
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
