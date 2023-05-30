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
    public partial class PostBrowse : Form
    {
        List<object> board_data;
        string Free_id;

        public PostBrowse(string id)
        {
            this.Free_id= id;
            InitializeComponent();
        }

        void save_Board_Data()
        {
            DateTime dateTime = DateTime.Now;
            board_data[2] = label_title.Text;
            board_data[3] = Substance.Text;
            board_data[4] = Convert.ToInt32(dateTime.ToString("yyyy") + dateTime.ToString("MM") + dateTime.ToString("dd"));
            board_data[5] = introduction.Text;
            if (board_data[5]!=label_division.Text)
            {
                while (true)
                {
                    string str = "";
                    Random random = new Random();
                    if (introduction.Text == "자유")
                    {
                        str += "F" + Convert.ToString(random.Next() % 1000000);
                    }
                    else
                    {
                        str += LoginApp.RDs.teamDoc_dic[introduction.Text] + Convert.ToString(random.Next() % 1000000);
                    }
                    if (Post.Free_id.Contains(str))
                    {
                        str = "";
                        continue;
                    }
                    else
                    {
                        Post.Free_id.Add(str);
                        board_data[6] = str;
                        break;
                    }
                }
            }
        }

        private void PostBrowse_Load(object sender, EventArgs e)
        {
            Substance.BackColor = SystemColors.Window;
            board_data = LoginApp.RDs.Read_database("FreeBoard", Free_id);
            label_name.Text = board_data[1].ToString();
            label_title.Text = board_data[2].ToString();
            Substance.Text = board_data[3].ToString();
            label_wdate.Text = board_data[4].ToString();
            label_division.Text = board_data[5].ToString();
            label_id.Text = board_data[6].ToString();

            if (LoginApp.user.id == Convert.ToInt32(board_data[0]) || LoginApp.user.authority == 0)
            {
                btndelete.Visible = true;
                btnmodify.Visible = true;
            }
            else
            {
                btndelete.Visible = false;
                btnmodify.Visible = false;
            }
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            LoginApp.RDs.Delete_database(label_id.Text, "FreeBoard");
            MessageBox.Show("삭제 완료");
            this.Dispose();
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            if (btnmodify.Text == "수정")
            {
                btnmodify.Text = "저장";
                Substance.ReadOnly = false;
                Substance.BackColor = SystemColors.Window;
                introduction.Visible = true;
                txt_title.Visible = true;
                label_title.Visible = false;
                label_division.Visible = false;
                introduction.Text = label_division.Text;
                txt_title.Text = label_title.Text;
                tableLayoutPanel1.Controls.Add(introduction, 1, 1);
                tableLayoutPanel2.Controls.Add(txt_title, 1, 0);
                introduction.Items.Add("자유");
                if(LoginApp.user.authority==0)
                {
                    foreach(string str in LoginApp.RDs.team_dic.Values)
                    {
                        introduction.Items.Add(str);
                    }
                }
                else
                {
                    introduction.Items.Add(LoginApp.user.team);
                }
            }
            else
            {
                btnmodify.Text = "수정";
                Substance.BackColor = SystemColors.Window;
                Substance.ReadOnly = true;
                introduction.Visible = false;
                txt_title.Visible = false;
                label_title.Visible = true;
                label_division.Visible = true;
                save_Board_Data();
                string beforeID = label_id.Text;
                label_division.Text = introduction.Text;
                label_title.Text = txt_title.Text;
                label_wdate.Text = board_data[4].ToString();
                label_id.Text = board_data[6].ToString();
                Post.Free_id.Remove(beforeID);
                LoginApp.RDs.Delete_database(beforeID, "FreeBoard");
                LoginApp.RDs.Create_database(board_data, "FreeBoard");
                MessageBox.Show("수정 완료");
                introduction.Items.Clear();
                tableLayoutPanel1.Controls.Add(label_division, 1, 1);
                tableLayoutPanel2.Controls.Add(label_title, 1, 0);
            }
        }
    }
}
