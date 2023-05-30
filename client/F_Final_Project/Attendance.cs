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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
           
            if (LoginApp.user.authority == 2)
            {
                Attendance_Workers workers = new Attendance_Workers(LoginApp.user.id.ToString());
                workers.TopLevel = false;
                workers.ControlBox = false;
                workers.Text = null;
                workers.Parent = panel3;
                workers.Show();

                AttendanceBrowse showWorker = new AttendanceBrowse(LoginApp.user.id.ToString());
                panel2.Controls.Clear();
                showWorker.TopLevel = false;
                panel2.Controls.Add(showWorker);
                showWorker.Text = null;
                showWorker.ControlBox = false;
                showWorker.Parent = panel2;
                showWorker.Show();
            }

            else if(LoginApp.user.authority == 1)
            {
                Attendance_Manager amod = new Attendance_Manager(this);
                amod.Owner= this;
                amod.TopLevel = false;
                amod.ControlBox = false;
                amod.Text = null;
                amod.Parent = panel3;
                amod.Show();
            }

            else if(LoginApp.user.authority == 0)
            {
                Attendance_Manager manager = new Attendance_Manager(this);
                manager.Owner= this;
                manager.TopLevel = false;
                manager.ControlBox = false;
                manager.Text = null;
                manager.Parent = panel3;
                manager.Show();
            }
        }

    }
}
