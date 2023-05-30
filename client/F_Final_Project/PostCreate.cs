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
    public partial class PostCreate : Form
    {
        public PostCreate()
        {
            InitializeComponent();
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btnregistration_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToString("yyyy") + dateTime.ToString("MM") + dateTime.ToString("dd");
            Random random = new Random();
            string str = "";

            while (true)
            {
                if (introduction.SelectedItem.ToString() == "자유")
                {
                    str += "F" + Convert.ToString(random.Next() % 1000000);
                }
                else  
                {
                    str += LoginApp.RDs.teamDoc_dic[introduction.SelectedItem.ToString()]+ Convert.ToString(random.Next() % 1000000);
                }

                if (Post.Free_id.Contains(str))
                {
                    str = "";
                    continue;
                }
                else
                {
                    List<object> list = new List<object>()
                    {
                        LoginApp.user.id,
                        LoginApp.user.name,
                        txtTitle.Text,
                        Substance.Text,
                        Convert.ToInt32(date),
                        introduction.SelectedItem.ToString(),
                        str
                    };
                    Post.Free_id.Add(str);
                    LoginApp.RDs.Create_database(list, "FreeBoard");
                    break;
                }
            }
            this.Dispose();
        }

        private void PostCreate_Load(object sender, EventArgs e)
        {
            introduction.Items.Add("자유");
            if(LoginApp.user.authority == 0)
            {
                foreach(string item in LoginApp.RDs.team_dic.Values)
                {
                    introduction.Items.Add(item);
                }
            }
            else
                introduction.Items.Add(LoginApp.user.team);
        }
    }
}
