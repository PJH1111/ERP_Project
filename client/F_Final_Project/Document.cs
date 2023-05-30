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
    public partial class Document : Form
    {
        public Document()
        {
            InitializeComponent();
        }

        private void btnongoing_Click(object sender, EventArgs e)
        {
            loadlist(0, 1, false);

            btnongoing.BackColor = Color.DarkGray;
            btnfinish.BackColor = Color.WhiteSmoke;
            btnregistration.BackColor = Color.WhiteSmoke;
            btnongoingfile.BackColor = Color.WhiteSmoke;
            btnfinishedfile.BackColor = Color.WhiteSmoke;
        }

        private void btnregistration_Click(object sender, EventArgs e)
        {
            DocumentRegistration registration = new DocumentRegistration();

            panel.Controls.Clear();
            registration.TopLevel = false;
            panel.Controls.Add(registration);
            registration.Text = null;
            registration.ControlBox = false;
            registration.Parent = panel;
            registration.Show();

            btnongoing.BackColor = Color.WhiteSmoke;
            btnfinish.BackColor = Color.WhiteSmoke;
            btnregistration.BackColor = Color.DarkGray;
            btnongoingfile.BackColor = Color.WhiteSmoke;
            btnfinishedfile.BackColor = Color.WhiteSmoke;
        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            loadlist(1, 1, false);
            btnongoing.BackColor = Color.WhiteSmoke;
            btnfinish.BackColor = Color.DarkGray;
            btnregistration.BackColor = Color.WhiteSmoke;
            btnongoingfile.BackColor = Color.WhiteSmoke;
            btnfinishedfile.BackColor = Color.WhiteSmoke;
        }

        private void Document_Load(object sender, EventArgs e)
        {
            if (LoginApp.user.authority != 2)
            {                
                btnfinishedfile.Visible = true;
                btnongoingfile.Visible = true;
                manegersmenu.Visible = true;
            }
        }

        private void btnongoingfile_Click(object sender, EventArgs e)
        {
            loadlist(0, 2, true);

            btnongoing.BackColor = Color.WhiteSmoke;
            btnfinish.BackColor = Color.WhiteSmoke;
            btnregistration.BackColor = Color.WhiteSmoke;
            btnongoingfile.BackColor = Color.DarkGray;
            btnfinishedfile.BackColor = Color.WhiteSmoke;
        }

        private void btnfinishedfile_Click(object sender, EventArgs e)
        {

            loadlist(1, 2, false);

            btnongoing.BackColor = Color.WhiteSmoke;
            btnfinish.BackColor = Color.WhiteSmoke;
            btnregistration.BackColor = Color.WhiteSmoke;
            btnongoingfile.BackColor = Color.WhiteSmoke;
            btnfinishedfile.BackColor = Color.DarkGray;
        }

        private void loadlist(int state, int btn_num, bool approval)
        {
            Ongoingfile ongoingfile = new Ongoingfile(state, btn_num, approval);
            ongoingfile.page = 0;
            panel.Controls.Clear();
            ongoingfile.TopLevel = false;
            Controls.Add(ongoingfile);
            ongoingfile.Text = null;
            ongoingfile.ControlBox = false;
            ongoingfile.Parent = panel;
            ongoingfile.Show();
        }
    }
}
