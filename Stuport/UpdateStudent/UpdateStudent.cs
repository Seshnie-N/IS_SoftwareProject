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
        static string _path = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+AppDomain.CurrentDomain.BaseDirectory+"StuportDatabase.accdb";

        OleDbConnection conn = new OleDbConnection(_path);

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

        private void lblLName_Click(object sender, EventArgs e)
        {

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

            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Student (Student_ID, Student_FirstName, Student_LastName," +
                " Student_Email, Student_Phone, Student_Password) VALUES (@6,@1,@2,@3,@4,@5)", conn);
            cmd.Parameters.AddWithValue("@1", strFName);
            cmd.Parameters.AddWithValue("@2", strLName);
            cmd.Parameters.AddWithValue("@3", strEmail);
            cmd.Parameters.AddWithValue("@4", strContactNo);
            cmd.Parameters.AddWithValue("@5", strPassword);
            cmd.Parameters.AddWithValue("@6", strStuNumber);

            cmd.ExecuteNonQuery();
            conn.Close();
            refreshGrid();
            MessageBox.Show("Update Successful");
        }

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
        }

        private void refreshGrid()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Student", conn);
                da.Fill(dt);
                dgvStudentUpdate.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Error Message: " + ex);
            }
            finally
            {
                conn.Close();
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
        }

        private void btnUpdateStudenr_Click(object sender, EventArgs e)
        {
            strStuNumber = txtStudentNumber.Text;
            strFName = txtFName.Text;
            strLName = txtLName.Text;
            strPassword = txtPassword.Text;
            strEmail = txtEmail.Text;
            strContactNo = txtPhoneNo.Text;

            conn.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE Student SET Student_FirstName = @1, Student_LastName = @2," +
                " Student_Email = @3, Student_Phone = @4, Student_Password = @5  WHERE Student_ID = @6", conn);
            cmd.Parameters.AddWithValue("@1", strFName);
            cmd.Parameters.AddWithValue("@2", strLName);
            cmd.Parameters.AddWithValue("@3", strEmail);
            cmd.Parameters.AddWithValue("@4", strContactNo);
            cmd.Parameters.AddWithValue("@5", strPassword);
            cmd.Parameters.AddWithValue("@6", strStuNumber);

            cmd.ExecuteNonQuery();
            conn.Close();
            refreshGrid();
            MessageBox.Show("Update Successful");
        }
    }
}
