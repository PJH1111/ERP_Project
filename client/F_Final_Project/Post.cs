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
    public partial class Post : Form
    {
        public Post()
        {
            List<JObject> AllList = LoginApp.RDs.Readdic_database("FreeBoard");
            foreach (JObject obj in AllList)
            {
                Free_id.Add(obj["id"].ToString());
            }
            InitializeComponent();
        }

        public static List<string> Free_id = new List<string>();
        List<JObject> list = new List<JObject>();
        List<Label> label_page = new List<Label>();
        string mode = "";
        int index = 1;

        void restart_form()
        {
            PostList.Items.Clear();
            list.Clear();
            if(LoginApp.user.authority==0)
            {
                if (mode == "title")
                {
                    list = LoginApp.RDs.Search_database("FreeBoard", "title", SearchTextbox.Text, index);
                }
                else if (mode == "team")
                {
                    list = LoginApp.RDs.Search_database("FreeBoard", "division", search_option.SelectedItem.ToString(), index);
                }
                else if(mode == "writer")
                {
                    list = LoginApp.RDs.Search_database("FreeBoard", "name", SearchTextbox.Text, index);
                }
                else
                {
                    list = LoginApp.RDs.Readdic_database("FreeBoard", index);
                }
            }
            else
            {
                if (mode == "title")
                {
                    list = LoginApp.RDs.Search_database("FreeBoard", "title", SearchTextbox.Text ,index, LoginApp.user.team);
                }
                else if (mode == "writer")
                {
                    list = LoginApp.RDs.Search_database("FreeBoard", "name", SearchTextbox.Text, index, LoginApp.user.team);
                }
                else if (mode == "team")
                {
                    list = LoginApp.RDs.Search_database("FreeBoard", "division", search_option.SelectedItem.ToString(), index, LoginApp.user.team);
                }
                else
                {
                    list = LoginApp.RDs.Readdic_database("FreeBoard",LoginApp.RDs.team_dic.FirstOrDefault(x=>x.Value==LoginApp.user.team).Key ,index);
                }
            }

            foreach (JObject item in list)
            {
                ListViewItem listItem = new ListViewItem(item["id"].ToString());
                listItem.SubItems.Add(item["title"].ToString());
                listItem.SubItems.Add(item["name"].ToString());
                listItem.SubItems.Add(item["wdate"].ToString());
                listItem.SubItems.Add(item["division"].ToString());
                PostList.Items.Add(listItem);
            }
        }

        private void Btnregistration_Click(object sender, EventArgs e)
        {
            PostCreate registration = new PostCreate();
            registration.ShowDialog();
            restart_form();
        }

        private void Post_Load(object sender, EventArgs e)
        {
            label_page.Add(Page1);
            label_page.Add(Page2);
            label_page.Add(Page3);
            label_page.Add(Page4);
            label_page.Add(Page5);
            label_page[0].ForeColor = Color.DodgerBlue;
            search_option.Items.Clear();
            search_option.Items.Add("전체");
            search_option.Items.Add("제목");
            search_option.Items.Add("작성자");
            search_option.Items.Add("자유");

            if(LoginApp.user.authority == 0)
            {
                foreach (string name in LoginApp.RDs.team_dic.Values)
                {
                    search_option.Items.Add(name);
                }
            }
            else
                search_option.Items.Add(LoginApp.user.team);

            search_option.SelectedIndex = 0;
            search_option.Text = "전체";

            restart_form();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            index = 1;
            for(int i=0;i<label_page.Count;i++)
            {
                label_page[i].ForeColor = Color.Black;
                label_page[i].Text = (index+i).ToString();
            }
            Page1.ForeColor= Color.Blue;

            if (search_option.SelectedItem.ToString() == "제목")
            {
                mode = "title";
            }
            else if (search_option.SelectedItem.ToString() == "작성자")
            {
                mode = "writer";
            }
            else if (search_option.SelectedItem.ToString() == "자유" || LoginApp.RDs.team_dic.ContainsValue(search_option.SelectedItem.ToString()))
            {
                mode = "team";
            }
            restart_form();
        }

        private void PostList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string id = PostList.SelectedItems[0].Text;

            PostBrowse browse = new PostBrowse(id);
            browse.ShowDialog();
            restart_form();
        }

        private void PreviousPage_Click(object sender, EventArgs e)
        {
            if (index != 1 && (index - 1) % 5 == 0)
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
                label_page[(index - 1) % 5].ForeColor = Color.DodgerBlue;
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
                label_page[(index - 1) % 5 - 1].ForeColor = Color.Black;
                label_page[(index - 1) % 5].ForeColor = Color.DodgerBlue;
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
