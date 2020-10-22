using Stuport.Groups;
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
            Groups.Groups groups = new Groups.Groups();
            groups.Show();
        }
    }
}
