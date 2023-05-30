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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace F_Final_Project
{
    public partial class Notice : Form 
    {
        public Notice()
        {
            List<JObject> AllList = LoginApp.RDs.Readdic_database("NoticeBoard");
            foreach (JObject obj in AllList)
            {
                notice_id.Add(obj["id"].ToString());
            }
            InitializeComponent();
        }

        public static List<string> notice_id = new List<string>();
        List<JObject> list = new List<JObject>();
        List<Label> label_page = new List<Label>(); 
        string mode = "";
        int index = 1;

        void restart_form()
        {
            NoticeList.Items.Clear();
            list.Clear();
            if(mode == "title")
            {
                list = LoginApp.RDs.Search_database("NoticeBoard", "title", SearchTextbox.Text, index);
            }
            else if(mode == "division")
            {
                list = LoginApp.RDs.Search_database("NoticeBoard", "division", SearchTextbox.Text, index);
            }
            else
            {
                list = LoginApp.RDs.Readdic_database("NoticeBoard",index);
            }

            foreach (JObject item in list)
            {
                ListViewItem listItem = new ListViewItem();
                listItem = new ListViewItem(item["id"].ToString());
                listItem.SubItems.Add(item["title"].ToString());
                listItem.SubItems.Add(item["name"].ToString());
                listItem.SubItems.Add(item["wdate"].ToString());
                listItem.SubItems.Add(item["division"].ToString());
                NoticeList.Items.Add(listItem);
            }
            if (LoginApp.user.authority == 0)
                Btnregistration.Visible = true;
            else
                Btnregistration.Visible = false;
        }

        private void Btnregistration_Click(object sender, EventArgs e)
        {
            NoticeCreate registration = new NoticeCreate();
            registration.ShowDialog();
            restart_form();
        }

        private void Notice_Load(object sender, EventArgs e)
        {
            label_page.Add(Page1);
            label_page.Add(Page2);
            label_page.Add(Page3);
            label_page.Add(Page4);
            label_page.Add(Page5);
            label_page[0].ForeColor = Color.DodgerBlue;
            search_option.SelectedIndex= 0;
            search_option.Text = "전체";
            restart_form();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            index = 1;
            for (int i = 0; i < label_page.Count; i++)
            {
                label_page[i].ForeColor = Color.Black;
                label_page[i].Text = (index + i).ToString();
            }
            Page1.ForeColor = Color.Blue;

            if (search_option.SelectedItem.ToString() == "제목")
            {
                mode = "title";
            }
            else if (search_option.SelectedItem.ToString() == "구분" )
            {
                mode = "division";
            }
            restart_form();
        }

        private void NoticeList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string id = NoticeList.SelectedItems[0].Text;
           
            NoticeBrowse browse = new NoticeBrowse(id);
            browse.ShowDialog();
            restart_form();
        }
        
        private void PreviousPage_Click(object sender, EventArgs e)
        {
            if(index != 1 && (index-1)%5 == 0 )
            {
                index--;
                label_page[0].ForeColor = Color.Black;
                label_page[0].Text = Convert.ToString(Convert.ToInt32(label_page[0].Text) - 5);
                label_page[1].ForeColor = Color.Black;
                label_page[1].Text = Convert.ToString(Convert.ToInt32(label_page[1].Text) - 5);
                label_page[2].ForeColor = Color.Black;
                label_page[2].Text = Convert.ToString(Convert.ToInt32(label_page[2].Text) - 5);
                label_page[3].ForeColor = Color.Black;
                label_page[3].Text = Convert.ToString(Convert.ToInt32(label_page[3].Text) - 5);
                label_page[4].ForeColor = Color.DodgerBlue;
                label_page[4].Text = Convert.ToString(Convert.ToInt32(label_page[4].Text) - 5);
            }
            else
            {
                index--;
                if (index == 0)
                    index++;
                label_page[(index - 1) % 5 + 1].ForeColor = Color.Black;
                label_page[(index - 1) % 5].ForeColor = Color.Blue;
            }
            restart_form();
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
             if ((index + 1) % 5 == 1)
            {
                index++;
                label_page[0].ForeColor = Color.DodgerBlue;
                label_page[0].Text = Convert.ToString(Convert.ToInt32(label_page[0].Text) + 5);
                label_page[1].ForeColor = Color.Black;
                label_page[1].Text = Convert.ToString(Convert.ToInt32(label_page[1].Text) + 5);
                label_page[2].ForeColor = Color.Black;
                label_page[2].Text = Convert.ToString(Convert.ToInt32(label_page[2].Text) + 5);
                label_page[3].ForeColor = Color.Black;
                label_page[3].Text = Convert.ToString(Convert.ToInt32(label_page[3].Text) + 5);
                label_page[4].ForeColor = Color.Black;
                label_page[4].Text = Convert.ToString(Convert.ToInt32(label_page[4].Text) + 5);
            }
            else
            {
                index++;
                label_page[(index - 1) % 5 -1].ForeColor= Color.Black;
                label_page[(index-1)%5].ForeColor= Color.DodgerBlue;
            }
            restart_form();
        }

        private void PageClick(object sender, EventArgs e)
        {
            Label label = sender as Label;
            Page1.ForeColor = Color.Black;
            Page2.ForeColor = Color.Black;
            Page3.ForeColor = Color.Black;
            Page4.ForeColor = Color.Black;
            Page5.ForeColor = Color.Black;
            label.ForeColor = Color.DodgerBlue;
            
            index = Convert.ToInt32(label.Text);
            restart_form();
        }

        private void search_option_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (search_option.SelectedItem.ToString() == "전체")
            {
                index = 1;
                for (int i = 0; i < label_page.Count; i++)
                {
                    label_page[i].ForeColor = Color.Black;
                    label_page[i].Text = (index + i).ToString();
                }
                Page1.ForeColor = Color.DodgerBlue;
                SearchTextbox.Text = "";
                mode = "";
                restart_form();
            }
        }
    }
}
