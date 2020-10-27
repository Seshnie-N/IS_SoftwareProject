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
    public partial class UpdateStudent : Form
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
            {
                MessageBox.Show("Error");
                return;
            }

            AC.addStudent(strStuNumber,strFName,strLName,strPassword,strEmail,strContactNo);

            MessageBox.Show("Update Successful");
        } //VALUES

        private bool validate()
        {
            bool bValid = true;
            if (String.IsNullOrEmpty(strStuNumber))
            {
                bValid = false;
            }
            if (String.IsNullOrEmpty(strFName))
            {
                bValid = false;
            }
            if (String.IsNullOrEmpty(strLName))
            {
                bValid = false;
            }
            if (String.IsNullOrEmpty(strEmail))
            {
                bValid = false;
            }
            if (String.IsNullOrEmpty(strContactNo))
            {
                bValid = false;
            }
            return bValid;
        } //TODO

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
            txtStudentNumber.ReadOnly = true;
        } //CELLS

        private void btnUpdateStudenr_Click(object sender, EventArgs e)
        {
            strStuNumber = txtStudentNumber.Text;
            strFName = txtFName.Text;
            strLName = txtLName.Text;
            strPassword = txtPassword.Text;
            strEmail = txtEmail.Text;
            strContactNo = txtPhoneNo.Text;

            AC.updateStudent(strStuNumber, strFName, strLName, strPassword, strEmail, strContactNo);

            MessageBox.Show("Update Successful");
        } //VALUES
    }
}
