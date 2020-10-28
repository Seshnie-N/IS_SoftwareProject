using Stuport.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stuport
{
    public partial class StudentMenu : Form
    {
        public StudentMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            StudentProfile stdprofile = new StudentProfile();
            stdprofile.Show();
            this.Hide();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAppointmentsHome appointmentsHome = new StudentAppointmentsHome();
            appointmentsHome.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.Login login = new Login.Login();
            login.Show();
        }

        private void BtnOtherServices_Click(object sender, EventArgs e)
        {
            this.Hide();
            Other_Services os = new Other_Services();
            os.Show();
        }

        private void exitlbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizelbl_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
