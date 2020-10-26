using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stuport.Groups.Model;
using Stuport.Groups__AdminSide_.Model;

namespace Stuport.Groups
{
    public partial class Groups : Form
    {
        static string _path = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ReposUni\IS_SoftwareProject\Stuport\bin\Debug\StuportDatabase.accdb";
        private OleDbConnection conn;
        private OleDbCommand dbCommand;
        private List<ServiceType> serviceTypesList;
        private List<PersonnelType> personnelTypesList;



        //private robsDatabase controller;
        string strGroupID;


        public Groups()
        {
            try
            {
                InitializeComponent();
                conn = new OleDbConnection(_path);
                conn.Open();
                dbCommand = conn.CreateCommand();

                RefreshGrid();
                Filler();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Technical Failure :{ex.Message}");
            }
        }

        public void RefreshGrid()
        {
            try
            {
                var dt = new DataTable();
                //string query = $"SELECT Group_ID,Service_Type,[Personnel].[Personnel_FirstName] , [Personnel].[Personnel_LastName]," +
                //    " Group_Venue, Group_Time, Group_Date, Group_Status" +
                //   "FROM(([Group]  LEFT OUTER JOIN[Service] on[Group].[Service_ID] =[Service].[Service_ID])" +
                //    "LEFT OUTER JOIN[Personnel] on[Group].[Personnel_ID] =[Personnel].[Personnel_ID]) " +
                //    "ORDER BY Group_ID";
                string query = $"SELECT [Group_ID], [Service_Type], [Personnel_ID], [Group_Venue], [Group_Time], [Group_Date], [Group_Status]" +
                   "FROM[Group]  LEFT OUTER JOIN [Service] on [Group].[Service_ID] =[Service].[Service_ID]" +
                    "ORDER BY Group_ID";
                var da = new OleDbDataAdapter(query, conn);
                da.Fill(dt);
                dgvGroups.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex);
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
            //strService = dgvGroups.Rows[e.RowIndex].Cells[1].Value.ToString();
            //strStaff = dgvGroups.Rows[e.RowIndex].Cells[2].Value.ToString();
            //strStatus = dgvGroups.Rows[e.RowIndex].Cells[6].Value.ToString();
            //strDate= dgvGroups.Rows[e.RowIndex].Cells[5].Value.ToString();
            //strVenue = dgvGroups.Rows[e.RowIndex].Cells[3].Value.ToString();
            //strTime = dgvGroups.Rows[e.RowIndex].Cells[4].Value.ToString();
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
                serviceTypesList = new List<ServiceType>();

                string query = "SELECT Service_ID, Service_Type FROM Service ORDER BY Service_Type";
                dbCommand.Parameters.Clear();
                dbCommand.CommandText = query;

                var reader = dbCommand.ExecuteReader();

                while (reader.Read())
                {
                    var serviceType = new ServiceType()
                    {
                        ServiceId = (int)reader["Service_ID"],
                    };
                    if (!reader["Service_Type"].Equals(DBNull.Value))
                        serviceType.ServiceTypeName = (string)reader["Service_Type"];
                    serviceTypesList.Add(serviceType);
                }
                reader.Close();

                cmbService.DisplayMember = "ServiceTypeName";
                cmbService.ValueMember = "ServiceId";
                cmbService.DataSource = serviceTypesList;
                cmbService.DropDownStyle = ComboBoxStyle.DropDown;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! "+ ex);
            }
            try
            {
                personnelTypesList = new List<PersonnelType>();

                string query = "SELECT [Personnel_ID], [Personnel_FirstName], [Personnel_LastName] FROM [Personnel] ORDER BY [Personnel_FirstName]";
                dbCommand.Parameters.Clear();
                dbCommand.CommandText = query;

                var reader = dbCommand.ExecuteReader();

                while (reader.Read())
                {
                    var personnelType = new PersonnelType()
                    {
                        PersonnelId = (int)reader["Personnel_ID"],
                    };
                    if (!reader["Personnel_FirstName"].Equals(DBNull.Value))
                        personnelType.PersonnelFirstName = (string)reader["Personnel_FirstName"];
                    personnelTypesList.Add(personnelType);
                }
                reader.Close();

                cmbStaff.DisplayMember = "PersonnelFirstName";
                cmbStaff.ValueMember = "PersonnelId";
                cmbStaff.DataSource = personnelTypesList;
                cmbStaff.DropDownStyle = ComboBoxStyle.DropDown;
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string strService;
            string strVenue;
            string strStaff;
            string strStatus;
            DateTime dtDate;
            DateTime dtTime;

            strService = cmbService.SelectedItem.ToString();
            strVenue = txtVenue.Text;
            strStaff = cmbStaff.SelectedItem.ToString();
            strStatus = cmbStatus.SelectedItem.ToString();
            dtDate = dtpDate.Value;
            dtTime = dtpTime.Value;

            MessageBox.Show("service: " + strService);
            MessageBox.Show("Venue: " + strVenue);
            MessageBox.Show("Staff: " + strStaff);
            MessageBox.Show("Time: " + dtTime.ToString());
            MessageBox.Show("Date: " + dtDate.ToString());
            MessageBox.Show("status: " + strStatus);

            conn.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE Group SET Service_ID = @1, Personel_ID = @2," +
                " Group_Venue = @3, Group_Time = @4, Group_Date = @5, Group_Status = @6  WHERE Group_ID = @7", conn);
            cmd.Parameters.AddWithValue("@1", strService);
            cmd.Parameters.AddWithValue("@2", strStaff);
            cmd.Parameters.AddWithValue("@3", strVenue);
            cmd.Parameters.AddWithValue("@4", dtTime);
            cmd.Parameters.AddWithValue("@5", dtDate);
            cmd.Parameters.AddWithValue("@6", strStatus);
            cmd.Parameters.AddWithValue("@7", strGroupID);

            cmd.ExecuteNonQuery();
            conn.Close();
            RefreshGrid();
            MessageBox.Show("Update Successful");

        }

        private void dgvGroups_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGroups.CurrentRow == null)
                return;
            strGroupID = (string)dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[0].Value;
            var serviceTypeName =  (string)dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[1].Value;
            var personnelId = (int)dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[2].Value;
            var serviceType = serviceTypesList.FirstOrDefault(s => s.ServiceTypeName == serviceTypeName);
            var PersonnelName = personnelTypesList.FirstOrDefault(s => s.PersonnelId == personnelId);
            var GroupVenue = (string)dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[3].Value;
            var GroupTime = (DateTime)dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[4].Value;
            var GroupDate = (DateTime)dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[5].Value;
            var GroupStaus = (string)dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[6].Value;
            cmbService.SelectedValue = serviceType.ServiceId;
            cmbStaff.SelectedValue = PersonnelName.PersonnelId;
            dtpTime.Value = GroupTime;
            dtpDate.Value = GroupDate;
            StatusSetter(GroupStaus);
            txtVenue.Text = GroupVenue;

            
        }

        private void StatusSetter(String status)
        {
            if (status == "Active") { cmbStatus.SelectedValue = "Active"; }
            else if (status == "Inactive") { cmbStatus.SelectedValue = "Inactive"; }
            else if (status == "Full") { cmbStatus.SelectedValue = "Full"; }
            else if (status == "Closed") { cmbStatus.SelectedValue = "Closed"; }
        }
    
    }
}
