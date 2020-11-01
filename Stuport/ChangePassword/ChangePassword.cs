using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stuport.ChangePassword
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string currentPass = txtCurrent.Text.Trim();
            string newPass = txtNew.Text.Trim();
            StudentController SC = new StudentController();
            string studNo = Global.Token;

            if (SC.ValidLogin(studNo, currentPass))
            {
                if (SC.PasswordLengthCheck(newPass))
                {
                    bool confirm = comfirmMessage("Are you sure you want to change your password?");
                    if (confirm)
                    {
                        SC.ChangePassword(studNo,newPass);
                        txtCurrent.Clear();
                        txtNew.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("New Password is invalid. Password must be 8 or more characters");
                }
            }
            else
            {
                MessageBox.Show("Incorrect password entered. Please ensure you are entering the correct current password.");
            }

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

        private void exitlbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
