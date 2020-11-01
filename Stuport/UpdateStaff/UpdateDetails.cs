using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace Stuport
{

    public partial class UpdateDetails : Form
    {
        public int staffID;
        String staffFName = "";
        String staffLName = "";
        String staffPhone = "";
        String staffEmail = "";
        String staffType = "";
        StaffPage sp = (StaffPage)Application.OpenForms["StaffPage"];
        StaffController sc = new StaffController();
        public UpdateDetails(int sID)
        {
            InitializeComponent();
            staffID = sID;
            PopulateDetails();
            
        }

        private void PopulateDetails()
        {
            staffFName = sc.getFname(staffID);
            txtFirstName.Text = staffFName;
         

            staffLName = sc.getLname(staffID);
            txtLastName.Text = staffLName;
           

            staffPhone = sc.getPhone(staffID);
            txtPhone.Text = staffPhone;
          

            staffEmail = sc.getEmail(staffID);
            txtEmail.Text = staffEmail;

            staffType = sc.getType(staffID);
            cmbxType.Text = staffType;
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            String staffFNameCMP, staffLNameCMP, staffPhoneCMP, staffEmailCMP, staffTypeCMP;
            bool Validation = true;
            //bool EmailValidation = true;
            //bool PhoneValidation = true;
            bool PresenceCheckValidation = true;
            staffFNameCMP = txtFirstName.Text;
            staffLNameCMP = txtLastName.Text;
            staffPhoneCMP = txtPhone.Text;
            staffEmailCMP = txtEmail.Text;
            staffTypeCMP = cmbxType.Text;

            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
               
                PresenceCheckValidation = false;
            }
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
               
                PresenceCheckValidation = false;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
               
                PresenceCheckValidation = false;
            }
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
               
                PresenceCheckValidation = false;
            }
            if (String.IsNullOrEmpty(cmbxType.Text))
            {
              
                PresenceCheckValidation = false;
            }






            if (PresenceCheckValidation)
            {

                if (!staffFName.Equals(staffFNameCMP))
                {
                    sc.UpdateFName(staffID, staffFNameCMP);
                }

                if (!staffLName.Equals(staffLNameCMP))
                {
                    sc.UpdateLName(staffID, staffLNameCMP);
                }

                if (!staffEmail.Equals(staffEmailCMP))
                {
                    if (!sc.EmailExists(staffEmailCMP))
                    {
                        sc.UpdateEmail(staffID, staffEmailCMP);
                    }
                    else
                    {
                        MessageBox.Show("A Staff Member With That Email Address Already Exists");
                        Validation = false;
                    }
                }

                if (!staffPhone.Equals(staffPhoneCMP))
                {
                    if (sc.PhoneNumberLengthCheck(staffPhoneCMP))
                    {
                        if (!sc.PhoneExists(staffPhoneCMP))
                        {
                            sc.UpdatePhone(staffID, staffPhoneCMP);
                        }
                        else
                        {
                            MessageBox.Show("A Staff Member With That Phone Number Already Exists");
                            Validation = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Phone Number must be 10 Digits");
                        Validation = false;
                    }
                }

                if (!staffType.Equals(staffTypeCMP))
                {
                    sc.UpdateType(staffID, staffTypeCMP);
                }



            }
            else
            {
                MessageBox.Show("All fields must be populated.");
                Validation = false;
            }

            if (Validation)
            {

                bool confirm = comfirmMessage("Are you sure?");
                if (confirm)
                {
                    MessageBox.Show("Update Successful");
                sp.loaddata();
                Close();
                }

            }


            

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

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateDetails_Load(object sender, EventArgs e)
        {

        }

        private void exitlbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizelbl_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
