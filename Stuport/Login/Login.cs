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

            string username = txtUsername.Text;
            string password = txtPassword.Text.Trim();
            StudentController SC = new StudentController();

            //Admin Login
            if (cbxAdmin.Checked)
            {
                if ((username.Equals("admin"))&&(password.Equals("0000")))
                {
                    this.Hide();
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Admin Login Details");
                }

            }
            else
            {
                //Student Login
                if (SC.StudNumExists(username))
                {
                    if (SC.ValidLogin(username, password))
                    {
                        this.Hide();
                        StudentMenu studentMenu = new StudentMenu();
                        studentMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password Entered. Try Again");
                    }

                }
                else
                {
                    MessageBox.Show("Username/Student number not found. Try Again or create an account.");
                }
            }
        }


    }
}
