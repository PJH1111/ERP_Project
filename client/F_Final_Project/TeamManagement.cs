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
using System.Net;
using System.IO;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;


namespace F_Final_Project
{
    public partial class TeamManagement : Form
    {
        public TeamManagement()
        {
            InitializeComponent();
        }

        string team_change_name="";
        

        private void TeamManagement_Load(object sender, EventArgs e)
        {
            TeamList.Items.Clear();
            teamName.Visible = false;
            TeamWorkerList.Visible = false;
            WorkersL.Visible = false;
            WorkersTeamChange.Visible = false;

            foreach (var item in LoginApp.RDs.team_dic.Values)
            {
                TeamList.Items.Add(item);
            }

        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            if(LoginApp.RDs.team_dic.Values.Contains(TextTeam.Text))
            {
                MessageBox.Show("중복된 부서입니다.");
            }
            else if(TextTeam.Text == "" || TextTeam.Text == null)
            {
                MessageBox.Show("잘못된 부서명입니다.");
            }
            else
            {
                TeamList.Items.Add(TextTeam.Text);
                string name = TextTeam.Text;
                var str = "abcdefghijklmnopqrstuvwxyz";
                string doc;
                Random random= new Random();
                while (true)
                {
                    doc = str[random.Next(str.Length)].ToString();
                    if (LoginApp.RDs.teamDoc_dic.Values.Contains(doc))
                        continue;
                    else
                        break;
                }
                List<object> list = new List<object>() { LoginApp.RDs.team_dic.Count, name,doc };
                LoginApp.RDs.teamDoc_dic.Add(name, doc);
                LoginApp.RDs.team_dic.Add(LoginApp.RDs.team_dic.Count,name);
                LoginApp.RDs.Create_database(list, "Team");
                MessageBox.Show("부서 추가 완료했습니다.");
            }
            
            TextTeam.Text = string.Empty;
        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {

            LoginApp.RDs.Delete_database(LoginApp.RDs.team_dic.FirstOrDefault(x=>x.Value== TeamList.SelectedItem.ToString()).Key , "Team");
            LoginApp.RDs.teamDoc_dic.Remove(TeamList.SelectedItem.ToString());
            LoginApp.RDs.team_dic.Remove(LoginApp.RDs.team_dic.FirstOrDefault(x => x.Value == TeamList.SelectedItem.ToString()).Key);
            TeamList.Items.RemoveAt(TeamList.SelectedIndex);
            MessageBox.Show("부서가 삭제되었습니다.");
            
        }

        private void btnConfirmTeam_Click(object sender, EventArgs e)
        {
            if (TextTeam.Text == "" || TextTeam.Text == null)
            {
                MessageBox.Show("잘못된 부서명입니다.");
            }
            else
            {
                LoginApp.RDs.UpdateTeam_database(team_change_name, TextTeam.Text);
                LoginApp.RDs.teamDoc_dic.Add(TextTeam.Text, LoginApp.RDs.teamDoc_dic[TeamList.Items[TeamList.SelectedIndex].ToString()]);
                LoginApp.RDs.teamDoc_dic.Remove(TeamList.Items[TeamList.SelectedIndex].ToString());
                LoginApp.RDs.team_dic[LoginApp.RDs.team_dic.FirstOrDefault(x => x.Value == TeamList.Items[TeamList.SelectedIndex].ToString()).Key] = TextTeam.Text;
                TeamList.Items[TeamList.SelectedIndex] = TextTeam.Text;
                MessageBox.Show("부서 수정 완료했습니다.");
            }
        }

        private void WorkersTeamChange_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }
        
        private void TeamWorkerList_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void WorkersTeamChange_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void TeamWorkerList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void WorkersTeamChange_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                var item = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;
                WorkersTeamChange.Items.Add(item.Clone() as ListViewItem);
                TeamWorkerList.Items.Remove(item);
            }
        }

        private void TeamWorkerList_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                var item = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;
                TeamWorkerList.Items.Add(item.Clone() as ListViewItem);
                WorkersTeamChange.Items.Remove(item);
                LoginApp.RDs.Update_database(Convert.ToInt32(item.Text), "UserInfo", "team", LoginApp.RDs.team_dic.FirstOrDefault(x => x.Value == team_change_name).Key.ToString());
            }
        }

        private void TeamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TeamList.Items.Count > 0 && TeamList.SelectedItem != null)
            {
                string item = TeamList.SelectedItem.ToString();
                team_change_name = item;
                teamName.Visible = true;
                TeamWorkerList.Visible = true;
                WorkersL.Visible = true;
                WorkersTeamChange.Visible = true;
                teamName.Text = item;
                TeamWorkerList.Items.Clear();
                ListViewItem listitem = new ListViewItem();
                List<JObject> list = new List<JObject>();
                list = LoginApp.RDs.Readdic_database("UserInfo");

                foreach (JObject worker in list)
                {
                    if (LoginApp.RDs.team_dic[Convert.ToInt32(worker["team"])].Contains(teamName.Text))
                    {
                        listitem = new ListViewItem(worker["employeeNumber"].ToString());
                        listitem.SubItems.Add(worker["name"].ToString());
                        listitem.SubItems.Add(LoginApp.RDs.JG_dic[Convert.ToInt32(worker["JG"])]);
                        TeamWorkerList.Items.Add(listitem);
                    }
                }
            }
        }
    }
}
