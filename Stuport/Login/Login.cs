using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stuport.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form RegisterForm = new StudentRegistration();
            RegisterForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentMenu studentMenu = new StudentMenu();
            studentMenu.Show();
            
            if (cbxAdmin.Checked)
            {
                this.Hide();
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();
            }
        }
    }
}
