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
    public partial class AddStaff : Form
    {
        StaffPage sp = (StaffPage)Application.OpenForms["StaffPage"];
        public AddStaff()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AddStaff_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private bool comfirmMessage(string message)
        {
            string caption = "Warning!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {

          

            bool Validation = true;
            bool EmailValidation = true;
            bool PhoneValidation = true;
            bool PresenceCheckValidation = true;
            StaffController SC = new StaffController();
            String Fname = txtFirstName.Text;
            String Lname = txtLastName.Text;
            String Email = txtEmail.Text;
            String Phone = txtPhone.Text;
            String Type = cmbxType.Text;

            //Validation

            if (SC.EmailExists(Email))
            {
                Validation = false;
                EmailValidation = false;
            }

            if (!SC.PhoneNumberLengthCheck(Phone))
            {
                Validation = false;
                PhoneValidation = false;
            }

            //Add Validation For Empty Boxes

            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                Validation = false;
                PresenceCheckValidation = false;
            }
            if (String.IsNullOrEmpty(txtLastName.Text))
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

            if (String.IsNullOrEmpty(cmbxType.Text))
            {
                Validation = false;
                PresenceCheckValidation = false;
            }

            //Add Student;
            if (Validation)
            {
                bool confirm = comfirmMessage("Are you sure you want to add this person?");
                if (confirm)
                {
                SC.AddStaff(Fname, Lname, Email, Phone, Type);
                MessageBox.Show("Added Staff Successfully");
                sp.loaddata();
                Close();
                }

            }
            else
            {
                if (!PresenceCheckValidation)
                {
                    MessageBox.Show("All fields must be populated.");
                }
                if (!EmailValidation)
                {
                    MessageBox.Show("An Account With This Email Address Already Exists");
                }
                if (!PhoneValidation)
                {
                    MessageBox.Show("Phone Number must be 10 Digits");
                }

            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
