using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using Google.Protobuf.WellKnownTypes;

namespace F_Final_Project
{
    public partial class LoginApp : Form
    {       
        public static RDSserver RDs = new RDSserver();
        public static User user = new User();
        public LoginApp()
        {
            InitializeComponent();
        }

        private void LoginApp_Load(object sender, EventArgs e)
        {
            Login login = new Login(this);
            panel1.Controls.Clear();
            login.TopLevel = false;
            login.ControlBox = false;
            login.Text = null;
            login.Parent = panel1;
            login.Show();
        }
    }
}
