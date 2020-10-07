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

namespace StuportApp
{
    public partial class UpdateStudent : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\StuportDatabase.accdb");
        

        public UpdateStudent()
        {
            InitializeComponent();
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Student", conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error","Error Message: " + ex);
            }
            
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
            string strStuNumber = txtStudentNumber.Text;
            string strFName = txtFName.Text;
            string strLName = txtLName.Text;
            string strPassword = txtPassword.Text;
            string strEmail = txtEmail.Text;
            string strContactNo = txtPhoneNo.Text;

            
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stuportDatabaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.stuportDatabaseDataSet.Student);

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPhoneNo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtStudentNumber.ReadOnly = true;
        }

    }
}
