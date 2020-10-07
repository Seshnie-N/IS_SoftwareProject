using StuportApp;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "s")
            {
                this.Hide();
                StudentMenu studentMenu = new StudentMenu();
                studentMenu.Show();

            }
            else
            {
                this.Hide();
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();
            }
        }
    }
}
