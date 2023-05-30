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
    public partial class NoticeCreate : Form
    {
        public NoticeCreate()
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

            while(true)
            {
                if(introduction.SelectedItem.ToString() == "일반")
                {
                    str += "B"+Convert.ToString(random.Next()%1000000);
                }
                else if(introduction.SelectedItem.ToString() == "긴급")
                {
                    str += "A"+ Convert.ToString(random.Next() % 1000000);
                }
                else if(introduction.SelectedItem.ToString() == "안내")
                {
                    str += "C"+ Convert.ToString(random.Next() % 1000000);
                }
                if (Notice.notice_id.Contains(str))
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
                    Notice.notice_id.Add(str);
                    LoginApp.RDs.Create_database(list,"NoticeBoard");
                    break;
                }
            }
            this.Dispose();
        }
    }
}
