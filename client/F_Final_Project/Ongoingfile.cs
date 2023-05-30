using Microsoft.VisualBasic.Logging;
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

namespace F_Final_Project
{
    public partial class Ongoingfile : Form
    {
        int state;
        public int page;
        int btn_num;
        bool approval;
        public Ongoingfile(int state, int btn_num, bool approval)
        {
            InitializeComponent();
            this.state = state;
            this.btn_num = btn_num;
            this.approval = approval;
        }

        private void Ongoingfile_Load(object sender, EventArgs e)
        {
            page = 1;
            readFile(state,page);
            pageColor(page);
        }

        private void PreviousPage_Click(object sender, EventArgs e)
        {
            if (page == 1)
                page = 1;
            else
            {
                --page;
                pageColor(page, 1);
            }
            readFile(state, page);
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            ++page;
            readFile(state, page);
            pageColor(page, 2);
        }
        public void readFile(int state, int page) //오류
        {
            DocumentList.Items.Clear();
            List<JObject> list = new List<JObject>();
            ListViewItem listViewItem;
            if (LoginApp.user.authority == 0)
            {
                if (btn_num == 1)// 다불러와
                    list = LoginApp.RDs.Readdic_database("ApplicationForLeave", LoginApp.user.name, state, "writer", page);
                else if (btn_num == 2)// 다불러와
                    list = LoginApp.RDs.Readdic_database("ApplicationForLeave", state,0, page);
            }
            else if (LoginApp.user.authority == 1) // 권한 1 부장 -> 자기가 쓴것만 보면 됨 state 통해서 승인 미승인 바꾸면 됨
            {
                if (btn_num == 1)             
                    list = LoginApp.RDs.Readdic_database("ApplicationForLeave", LoginApp.user.name, state, "writer", page); 
                else if (btn_num == 2) // 권한 1 부장 -> 자기팀꺼 불러오기 state 통해서 승인 미승인 바꾸면 됨   
                    list = LoginApp.RDs.Readdic_database("ApplicationForLeave", LoginApp.user.team, state, "team", page);
            }
            else
            {
                if (btn_num == 1)  // 권한 2 일반 사원 -> 자기가 쓴것만 보면 됨
                    list = LoginApp.RDs.Readdic_database("ApplicationForLeave", LoginApp.user.name, state, "writer", page);
            }

            for (int i = 0; i < list.Count; i++)
            {
                JObject obj = list[i];
                listViewItem = new ListViewItem(obj["id"].ToString());
                listViewItem.SubItems.Add(obj["writer"].ToString());
                listViewItem.SubItems.Add(obj["title"].ToString());
                listViewItem.SubItems.Add(Convert.ToInt32(obj["date"]).ToString());
                listViewItem.SubItems.Add(typeReturn(Convert.ToInt32(obj["type"])));
                DocumentList.Items.Add(listViewItem);
            }
        }

        public void pageColor(int page, int next=0)
        {
            List<Label> labels = new List<Label>() { Page1, Page2,Page3,Page4,Page5 };
            int pageNum = (page - 1) / 5;   
            for(int i = 0; i < 5; i++)
            {
                labels[i].Text = (i + 1 + pageNum * 5).ToString();
                labels[i].ForeColor = Color.Black;
            }           
            labels[(page - 1) % 5].ForeColor = Color.DodgerBlue;
        }

        public string typeReturn(int type)
        {
            string result = "";
            if (type == 1)
                result = "휴가신청서";
            else if (type == 2)
                result = "일일 업무 보고서";
            else if (type == 3)
                result = "기안서";
            return result;
        }

        private void DocumentList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BusinessWorkReport report = new BusinessWorkReport(true, DocumentList.FocusedItem.SubItems[0].Text, approval) ;
            Draft draft = new Draft(true, DocumentList.FocusedItem.SubItems[0].Text, approval);
            ApplicationForLeave applicationForLeave = new ApplicationForLeave(true, DocumentList.FocusedItem.SubItems[0].Text, approval);
            char type = DocumentList.FocusedItem.SubItems[0].Text[0];
            JObject obj = new JObject();
            if (type == 'X')
            {
                applicationForLeave.ShowDialog();
            }
            else if (type == 'Y')
            {
                report.ShowDialog();
            }
            else
            {
                draft.ShowDialog();
            }
        }
    }
}
