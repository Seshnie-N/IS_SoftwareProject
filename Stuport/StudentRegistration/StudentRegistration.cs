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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword2_Click(object sender, EventArgs e)
        {

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
            StudentController SC = new StudentController();
            String StudNum = txtStudNum.Text;
            String Fname = txtFName.Text;
            String Lname = txtLName.Text;
            String Email = txtEmail.Text;
            String Phone = txtPhone.Text;
            String Password = txtPassword.Text;
            String ConfirmPassword = txtPasswordConf.Text;
            Console.WriteLine(Phone.Length + Phone);

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

            //Add Student;
            if (Validation)
            {
                SC.AddStudent(StudNum, Fname, Lname, Email, Phone, Password);
                MessageBox.Show("Registered Successfully");
            }
            else
            {
                if (!EmailValidation)
                {
                    MessageBox.Show("An Account With This Email Address Already Exists");
                }
                if (!StudNumValidation)
                {
                    MessageBox.Show("An Account With This Student Number Already Exists");
                }
                if (!ConfirmPasswordValidation)
                {
                    MessageBox.Show("Please Re-enter Your Password");
                }
                if (!PasswordValidation)
                {
                    MessageBox.Show("Password must be atleast 8 characters");
                }
                if (!PhoneValidation)
                {
                    MessageBox.Show("Phone Number must be 10 Digits");
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

        private void TxtPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
