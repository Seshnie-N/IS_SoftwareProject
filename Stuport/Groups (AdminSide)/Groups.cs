using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stuport.Groups
{
    public partial class Groups : Form
    {
        static string _path = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =| DataDirectory |\bin\Debug\StuportDatabase.accdb";
        OleDbConnection conn = new OleDbConnection(_path);

        string strGroupID;
        string strService;
        string strVenue;
        string strStaff;
        string strStatus;
        string strDate;
        string strTime;

        public Groups()
        {
            InitializeComponent();
            RefreshGrid();
            Filler();
        }

        public void RefreshGrid()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                string query = "SELECT * FROM [Group]";
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                da.Fill(dt);
                dgvGroups.DataSource = dt;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }

        private void dgvGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
            strGroupID = dgvGroups.Rows[e.RowIndex].Cells[0].Value.ToString();
            strService = dgvGroups.Rows[e.RowIndex].Cells[1].Value.ToString();
            strStaff = dgvGroups.Rows[e.RowIndex].Cells[2].Value.ToString();
            strStatus = dgvGroups.Rows[e.RowIndex].Cells[6].Value.ToString();
            strDate= dgvGroups.Rows[e.RowIndex].Cells[5].Value.ToString();
            strVenue = dgvGroups.Rows[e.RowIndex].Cells[3].Value.ToString();
            strTime = dgvGroups.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool confirm = comfirmMessage();
            if (confirm == true)
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE FROM [Group] WHERE Group_ID = @1", conn);
                cmd.Parameters.AddWithValue("@1", strGroupID);
                cmd.ExecuteNonQuery();
                conn.Close();
                RefreshGrid();
                MessageBox.Show("Group has been removed");
            }   
        }

        private bool comfirmMessage()
        {
         
            string message = "Are you sure you want to delete this group";
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

        public void Filler()
        {
            try
            {
                string query = "SELECT Service_ID, Service_Type FROM Service";
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Service");
                cmbService.DisplayMember = "Service_Type";
                cmbService.ValueMember = "Service_ID";
                cmbService.DataSource = ds.Tables["Service"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! "+ ex);
            }
            finally
            {
                conn.Close();
            }
            try
            {
                string query = "SELECT Personnel_ID, Personnel_FirstName, Personnel_LastName FROM Personnel";
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Personnel");
                cmbStaff.DisplayMember = "Personnel_FirstName + ' ' + Personnel_LastName";
                cmbStaff.ValueMember = "Personnel_ID";
                cmbStaff.DataSource = ds.Tables["Personnel"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //put in buttons
        }
    }
}
