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
<<<<<<< HEAD
        static string _path = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\StuportDatabase.accdb";
=======
        static string _path = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+AppDomain.CurrentDomain.BaseDirectory+"StuportDatabase.accdb";
>>>>>>> main
        OleDbConnection conn = new OleDbConnection(_path);
        

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
<<<<<<< HEAD

=======
            
>>>>>>> main
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stuportDatabaseDataSet.Student' table. You can move, or remove it, as needed.
            string strStuNumber = txtStudentNumber.Text;
            string strFName = txtFName.Text;
            string strLName = txtLName.Text;
            string strPassword = txtPassword.Text;
            string strEmail = txtEmail.Text;
            string strContactNo = txtPhoneNo.Text;

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
            string strStuNumber = txtStudentNumber.Text;
            string strFName = txtFName.Text;
            string strLName = txtLName.Text;
            string strPassword = txtPassword.Text;
            string strEmail = txtEmail.Text;
            string strContactNo = txtPhoneNo.Text;

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
