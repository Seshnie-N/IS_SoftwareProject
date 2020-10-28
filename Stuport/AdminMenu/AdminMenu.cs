using Stuport.Groups_Service;
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
using Stuport.Appointment__AdminSide_;

namespace Stuport
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateStudent updateStudent = new UpdateStudent();
            updateStudent.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.Login login = new Login.Login();
            login.Show();
        }

        private void btnManageGroups_Click(object sender, EventArgs e)
        {
            this.Hide();
            Groups_Service.Groups groups = new Groups_Service.Groups();
            groups.Show();
        }

        private void btnManageAppointments_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointment__AdminSide_.frmAppointmentAdmin Appointments = new Appointment__AdminSide_.frmAppointmentAdmin();
            Appointments.Show();
        }

        private void BtnManageStaff_Click(object sender, EventArgs e)
        {

            this.Hide();
            StaffPage staffPage = new StaffPage();
            staffPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StuportReport report = new StuportReport();
            report.Show();
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
