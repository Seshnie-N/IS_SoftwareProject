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
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();
        }

                private void StudentRegistration_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            bool Validation = true;
            bool StudNumValidation = true;
            bool EmailValidation = true;
            bool PasswordValidation = true;
            bool ConfirmPasswordValidation = true;
            bool PhoneValidation = true;
            bool PresenceCheckValidation = true;
            StudentController SC = new StudentController();
            String StudNum = txtStudNum.Text;
            String Fname = txtFName.Text;
            String Lname = txtLName.Text;
            String Email = txtEmail.Text;
            String Phone = txtPhone.Text;
            String Password = txtPassword.Text;
            String ConfirmPassword = txtPasswordConf.Text;

            //Validation
            if (SC.StudNumExists(StudNum))
            {
                Validation = false;
                StudNumValidation = false;
            }
            if (!ConfirmPassword.Equals(Password))
            {
                Validation = false;
                ConfirmPasswordValidation = false;
            }
            if (SC.EmailExists(Email))
            {
                Validation = false;
                EmailValidation = false;
            }
            if (!SC.PasswordLengthCheck(Password))
            {
                Validation = false;
                PasswordValidation = false;
            }
            if (!SC.PhoneNumberLengthCheck(Phone))
            {
                Validation = false;
                PhoneValidation = false;
            }

            //Add Validation For Empty Boxes
            if (String.IsNullOrEmpty(txtStudNum.Text))
            {
                Validation = false;
                PresenceCheckValidation = false;
            }
            if (String.IsNullOrEmpty(txtFName.Text))
            {
                Validation = false;
                PresenceCheckValidation = false;
            }
            if (String.IsNullOrEmpty(txtLName.Text))
            {
                Validation = false;
                PresenceCheckValidation = false;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                Validation = false;
                PresenceCheckValidation = false;
            }
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                Validation = false;
                PresenceCheckValidation = false;
            }

            //Add Student;
            if (Validation)
            {
                SC.AddStudent(StudNum, Fname, Lname, Email, Phone, Password);
                MessageBox.Show("Registered Successfully");
            }
            else
            {
                if(!PresenceCheckValidation)
                {
                    MessageBox.Show("All fields must be populated.");
                }
                if (!StudNumValidation)
                {
                    MessageBox.Show("An Account With This Student Number Already Exists");
                }
                if (!EmailValidation)
                {
                    MessageBox.Show("An Account With This Email Address Already Exists");
                }
                if (!PhoneValidation)
                {
                    MessageBox.Show("Phone Number must be 10 Digits");
                }
                if (!ConfirmPasswordValidation)
                {
                    MessageBox.Show("Please Re-enter Your Password");
                }
                if (!PasswordValidation)
                {
                    MessageBox.Show("Password must be atleast 8 characters");
               }
                          
            }
    
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TtHints_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
