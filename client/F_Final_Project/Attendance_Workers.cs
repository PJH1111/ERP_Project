using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_Final_Project
{
    public partial class Attendance_Workers : Form
    {
        public Attendance_Workers(string id)
        {
            InitializeComponent();
            info = LoginApp.RDs.Read_database2("UserInfo", id);
        }
        private int dayToInt(string day)
        {
            int num;
            if (day.Equals("Sunday"))
                num = 1;
            else if (day.Equals("Monday"))
                num = 2;
            else if (day.Equals("Tuesday"))
                num = 3;
            else if (day.Equals("Wednesday"))
                num = 4;
            else if (day.Equals("Thursday"))
                num = 5;
            else if (day.Equals("Friday"))
                num = 6;
            else
                num = 7;
            return num;
        }

        JObject info;
        JObject cnt;
        List<JObject> leave;
        
        private void Attendance_Workers_Load(object sender, EventArgs e)
        {
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();
            DateTime datetime = new DateTime(Int32.Parse(year), Int32.Parse(month), 1, new GregorianCalendar());
            KoreanCalendar myCal = new KoreanCalendar();

            List<Button> days = new List<Button> { Day1, Day2, Day3, Day4, Day5, Day6, Day7,
                Day8, Day9, Day10, Day11, Day12, Day13, Day14, Day15, Day16,
                Day17, Day18, Day19, Day20, Day21, Day22, Day23, Day24, Day25, Day26,
                Day27, Day28, Day29, Day30, Day31, Day32, Day33, Day34, Day35, Day36,
                Day37, Day38, Day39, Day40, Day41, Day42
            };

            int DaysInMonth = myCal.GetDaysInMonth(myCal.GetYear(datetime), Int32.Parse(month));

            int num = dayToInt(myCal.GetDayOfWeek(datetime).ToString());
            for (int i = 0; i < 42; i++)
            {
                days[i].Visible = false;
            }

            int day_num = 1;
            for (int i = num - 1; i < DaysInMonth + num - 1; i++)
            {
                days[i].Visible = true;

                if (day_num < 10)
                    days[i].Text = " " + day_num.ToString();
                else
                    days[i].Text = day_num.ToString();
                day_num++;
            }

            cnt = LoginApp.RDs.Read_database2("LeaveCount", info["employeeNumber"].ToString());
            leave = LoginApp.RDs.Readdic_database("AnnualLeave", 0, Convert.ToInt32(info["employeeNumber"].ToString()));

            foreach (JObject item in leave)
            {
                if (Convert.ToInt32(item["employeeNumber"].ToString())==LoginApp.user.id )
                {
                    string str = item["start"].ToString();
                    string subyear = str.Substring(0, 4); // year 2023
                    string submonth = str.Substring(4, 2); // month 05
                    string subday = str.Substring(6, 2); // day 03

                    string str2 = item["end"].ToString();
                    string subyear2 = str2.Substring(0, 4); // year 2023
                    string submonth2 = str2.Substring(4, 2); // month 05
                    string subday2 = str2.Substring(6, 2); // day 03

                    int gap = Convert.ToInt32(str2) - Convert.ToInt32(str);
                    if (subyear == DateTime.Now.ToString("yyyy") && submonth == DateTime.Now.ToString("MM"))
                    {
                        for (int i = Convert.ToInt32(subday); i <= Convert.ToInt32(subday) + gap; i++)
                        {
                            if (i + 1 < days.Count)
                            {
                                days[i].BackColor = Color.Yellow;

                            }

                        }

                    }
                }
            }
            labelWorkersName.Text = info["name"].ToString();

            if (cnt != null)
            {
                JToken value = cnt["count"];
                if (value != null)
                {
                    label_leavecount.Text = cnt["count"].ToString();
                }
                
            }
            else
            {
                label_leavecount.Text = "0";
            }

        }
    }
}
