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
    public partial class MainForm : Form
    {        
        LoginApp app;
        MyPage myPage = new MyPage();
        Notice notice = new Notice();
        Post post = new Post();
        Document document = new Document();
        Attendance attendance = new Attendance();
        EmployeeManagement employee = new EmployeeManagement();
        TeamManagement team = new TeamManagement();

        public MainForm(LoginApp loginApp)
        {
            InitializeComponent();
            this.app = loginApp;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (LoginApp.user.authority != 0)
            {
                EmployeeHome.Text = "사원조회";
                TeamHome.Visible = false;
            }
            panel1.Controls.Clear();
            MyPageHome.ForeColor = Color.DarkOrange;
            NoticeHome.ForeColor = Color.White;
            PostHome.ForeColor = Color.White;
            DocumentHome.ForeColor = Color.White;
            AttendanceHome.ForeColor = Color.White;
            EmployeeHome.ForeColor = Color.White;
            TeamHome.ForeColor = Color.White;
            myPage.TopLevel = false;
            Controls.Add(myPage);
            myPage.Text = null;
            myPage.ControlBox = false;
            myPage.Parent = panel1;
            myPage.Show();
        }

        private void MyPageHome_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MyPageHome.ForeColor = Color.DarkOrange;
            NoticeHome.ForeColor = Color.White;
            PostHome.ForeColor = Color.White;
            DocumentHome.ForeColor = Color.White;
            AttendanceHome.ForeColor = Color.White;
            EmployeeHome.ForeColor = Color.White;
            TeamHome.ForeColor = Color.White;
            myPage.TopLevel = false;
            Controls.Add(myPage);
            myPage.Text = null;
            myPage.ControlBox = false;
            myPage.Parent = panel1;
            myPage.Show();
        }

        private void NoticeHome_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MyPageHome.ForeColor = Color.White;
            NoticeHome.ForeColor = Color.DarkOrange;
            PostHome.ForeColor = Color.White;
            DocumentHome.ForeColor = Color.White;
            AttendanceHome.ForeColor = Color.White;
            EmployeeHome.ForeColor = Color.White;
            TeamHome.ForeColor = Color.White;
            notice.TopLevel = false;
            Controls.Add(notice);
            notice.Text = null;
            notice.ControlBox = false;
            notice.Parent = panel1;
            notice.Show();
        }

        private void PostHome_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MyPageHome.ForeColor = Color.White;
            NoticeHome.ForeColor = Color.White;
            PostHome.ForeColor = Color.DarkOrange;
            DocumentHome.ForeColor = Color.White;
            AttendanceHome.ForeColor = Color.White;
            EmployeeHome.ForeColor = Color.White;
            TeamHome.ForeColor = Color.White;
            post.TopLevel = false;
            Controls.Add(post);
            post.Text = null;
            post.ControlBox = false;
            post.Parent = panel1;
            post.Show();
        }

        private void DocumentHome_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MyPageHome.ForeColor = Color.White;
            NoticeHome.ForeColor = Color.White;
            PostHome.ForeColor = Color.White;
            DocumentHome.ForeColor = Color.DarkOrange;
            AttendanceHome.ForeColor = Color.White;
            EmployeeHome.ForeColor = Color.White;
            TeamHome.ForeColor = Color.White;
            document.TopLevel = false;
            Controls.Add(document);
            document.Text = null;
            document.ControlBox = false;
            document.Parent = panel1;
            document.Show();
        }

        private void AttendanceHome_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MyPageHome.ForeColor = Color.White;
            NoticeHome.ForeColor = Color.White;
            PostHome.ForeColor = Color.White;
            DocumentHome.ForeColor = Color.White;
            AttendanceHome.ForeColor = Color.DarkOrange;
            EmployeeHome.ForeColor = Color.White;
            TeamHome.ForeColor = Color.White;
            attendance.TopLevel = false;
            Controls.Add(attendance);
            attendance.Text = null;
            attendance.ControlBox = false;
            attendance.Parent = panel1;
            attendance.Show();
        }

        private void EmployeeHome_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MyPageHome.ForeColor = Color.White;
            NoticeHome.ForeColor = Color.White;
            PostHome.ForeColor = Color.White;
            DocumentHome.ForeColor = Color.White;
            AttendanceHome.ForeColor = Color.White;
            EmployeeHome.ForeColor = Color.DarkOrange;
            TeamHome.ForeColor = Color.White;
            employee.TopLevel = false;
            Controls.Add(employee);
            employee.Text = null;
            employee.ControlBox = false;
            employee.Parent = panel1;
            employee.Show();
        }

        private void TeamHome_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MyPageHome.ForeColor = Color.White;
            NoticeHome.ForeColor = Color.White;
            PostHome.ForeColor = Color.White;
            DocumentHome.ForeColor = Color.White;
            AttendanceHome.ForeColor = Color.White;
            EmployeeHome.ForeColor = Color.White;
            TeamHome.ForeColor = Color.DarkOrange;
            team.TopLevel = false;
            Controls.Add(team);
            team.Text = null;
            team.ControlBox = false;
            team.Parent = panel1;
            team.Show();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login(app);
            DialogResult dia = MessageBox.Show("로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.OKCancel);

            if (dia == DialogResult.OK)
            {
                app.panel1.Controls.Clear();
                login.TopLevel = false;
                login.ControlBox = false;
                login.Text = null;
                login.Parent = app.panel1;
                login.Show();
            }
        }
    }
}
