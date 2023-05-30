using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Login : Form
    {
        LoginApp loginApp;

        public Login(LoginApp loginApp)
        {
            this.loginApp = loginApp;
            InitializeComponent();
        }

        private void Click_LogIN_Click(object sender, EventArgs e)
        {
            List<object> list = new List<object>(); //List<object> 데이터 선언

            if (InputID.Text != "")
            {

                list = LoginApp.RDs.Read_database("UserInfo", Convert.ToInt32(InputID.Text));

                if (list.Count != 0 && Convert.ToString(list[0]) == (InputID.Text)) //InputID TextBox에 입력한 사원번호가 있다는 조건 선언
                {
                    LoginApp.user.id = Convert.ToInt32(list[0]);
                    LoginApp.user.name = Convert.ToString(list[1]);
                    LoginApp.user.pw = Convert.ToString(list[2]);
                    LoginApp.user.authority = Convert.ToInt32(list[3]);
                    LoginApp.user.team = Convert.ToString(list[4]);
                    LoginApp.user.JG = Convert.ToString(list[5]);
                    LoginApp.user.birth = Convert.ToInt32(list[6]);
                    LoginApp.user.addr = Convert.ToString(list[7]);
                    LoginApp.user.tel = Convert.ToString(list[8]);
                    LoginApp.user.mail = Convert.ToString(list[9]);
                    LoginApp.user.DoE = Convert.ToInt32(list[10]);

                    MainForm mainForm = new MainForm(loginApp);

                    if (list[2].ToString() == (InputPW.Text)) //위 조건을 걸었을 때 패스워드가 일치한다는 조건 선언
                    {
                        MessageBox.Show("로그인에 성공했습니다.");
                        loginApp.panel1.Controls.Clear();
                        mainForm.TopLevel = false;
                        mainForm.ControlBox = false;
                        mainForm.Text = null;
                        mainForm.Parent = loginApp.panel1;
                        mainForm.Show();
                    } //로그인에 성공했다는 MessageBox가 뜨고 확인 버튼을 누르면 바로 메인폼 화면이 뜨고 로그인 창은 사라진다.
                    else if ((InputPW.Text) == "") //패스워드를 입력하지 않았을 때
                    {
                        MessageBox.Show("패스워드를 입력하세요.");
                    }
                    else
                    {
                        MessageBox.Show("로그인에 실패했습니다."); //그 외, 패스워드를 입력했지만 일치하지 않을 때
                        InputPW.Text = null;
                    }

                }
                else //그 외, 입력한 사원번호가 데이터에 없을 때
                {
                    MessageBox.Show("없는 사원번호입니다.");
                    InputID.Text = null;
                    InputPW.Text = null;
                }

            }
            else //사원번호를 입력하지 않았을 때
            {
                MessageBox.Show("사원번호를 입력하세요");
            }
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Click_LogIN.PerformClick();
            }
        }
    }
}
