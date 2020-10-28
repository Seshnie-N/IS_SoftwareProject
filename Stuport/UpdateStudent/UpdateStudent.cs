using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stuport
{
    public partial class UpdateStudent : DevExpress.XtraEditors.XtraForm
    {
        AdminController.AdminController AC = new AdminController.AdminController();

        string strStuNumber;
        string strFName;
        string strLName;
        string strPassword;
        string strEmail;
        string strContactNo;

        public UpdateStudent()
        {
            InitializeComponent();
            refreshGrid();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            strStuNumber = txtStudentNumber.Text;
            strFName = txtFName.Text;
            strLName = txtLName.Text;
            strPassword = txtPassword.Text;
            strEmail = txtEmail.Text;
            strContactNo = txtPhoneNo.Text;

            bool bVailid = validate();
            if (bVailid == false)
                return;
            if (AC.StudentExist(strStuNumber))
            {
                MessageBox.Show("Student Already Exists", "Error");
                return;
            }
            if (!comfirmMessage("Add this student?")) { return; }
            AC.addStudent(strStuNumber,strFName,strLName,strPassword,strEmail,strContactNo);

            refreshGrid();
            MessageBox.Show("Student Added");

        }

        private bool validate()
        {
            bool bValid = true;
            if (String.IsNullOrEmpty(strStuNumber))
            {
                bValid = false;
                MessageBox.Show("Student Number Cannot be Empty", "Input Error");
            }
            if (String.IsNullOrEmpty(strFName))
            {
                bValid = false;
                MessageBox.Show("First Name Cannot be Empty", "Input Error");
            }
            if (String.IsNullOrEmpty(strLName))
            {
                bValid = false;
                MessageBox.Show("Last Name Cannot be Empty", "Input Error");
            }
            if (String.IsNullOrEmpty(strEmail))
            {
                bValid = false;
                MessageBox.Show("Email Cannot be Empty", "Input Error");
            }
            if (String.IsNullOrEmpty(strContactNo))
            {
                bValid = false;
                MessageBox.Show("Contact number Cannot be Empty", "Input Error");
            }
            if (String.IsNullOrEmpty(strPassword))
            {
                bValid = false;
                MessageBox.Show("Password Cannot be Empty", "Input Error");
            }
            if (!IsDigitsOnly(strContactNo) || strContactNo.Length!=10)
            {
                bValid = false;
                MessageBox.Show("Contact number must be 10 digits from 0-9  ", "Input Error");
            }
            return bValid;
        }

        private void refreshGrid()
        {
            try
            {
                DataTable dt = new DataTable();
                AC.RefreshGridStudent(ref dt);
                dgvStudentUpdate.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Error Message: " + ex);
            }
        }

        private void dgvStudentUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentNumber.Text = dgvStudentUpdate.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFName.Text = dgvStudentUpdate.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLName.Text = dgvStudentUpdate.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvStudentUpdate.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPhoneNo.Text = dgvStudentUpdate.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPassword.Text = dgvStudentUpdate.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdateStudenr_Click(object sender, EventArgs e)
        {
            strStuNumber = txtStudentNumber.Text;
            strFName = txtFName.Text;
            strLName = txtLName.Text;
            strPassword = txtPassword.Text;
            strEmail = txtEmail.Text;
            strContactNo = txtPhoneNo.Text;

            bool bVailid = validate();
            if (bVailid == false)
                return;
            if (!(AC.StudentExist(strStuNumber)))
            {
                MessageBox.Show("Student Does not exsist", "Error");
                return;
            }
            if (!comfirmMessage("Update this student?")){ return; }

            AC.updateStudent(strStuNumber, strFName, strLName, strPassword, strEmail, strContactNo);
            refreshGrid();

            MessageBox.Show("Update Successful");
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
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

        private void dgvStudentUpdate_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
