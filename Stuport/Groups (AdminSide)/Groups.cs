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
using Stuport.Groups_Service.Model;
using Stuport.Groups_Personnel.Model;
using Stuport.AdminController;

namespace Stuport.Groups_Service
{
    public partial class Groups : Form
    {
        AdminController.AdminController AC = new AdminController.AdminController();
        int strGroupID;

        public Groups()
        {
            try
            {
                InitializeComponent();
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
                DataTable dt = new DataTable();
                AC.RefreshGridGroups(ref dt);
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
  
            //strGroupID = dgvGroups.Rows[e.RowIndex].Cells[0].Value;
            //strService = dgvGroups.Rows[e.RowIndex].Cells[1].Value.ToString();
            //strStaff = dgvGroups.Rows[e.RowIndex].Cells[2].Value.ToString();
            //strStatus = dgvGroups.Rows[e.RowIndex].Cells[6].Value.ToString();
            //strDate= dgvGroups.Rows[e.RowIndex].Cells[5].Value.ToString();
            //strVenue = dgvGroups.Rows[e.RowIndex].Cells[3].Value.ToString();
            //strTime = dgvGroups.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //bool confirm = comfirmMessage();
            //if (confirm == true)
            //{
            //    conn.Open();
            //    OleDbCommand cmd = new OleDbCommand("DELETE FROM [Group] WHERE Group_ID = @1", conn);
            //    cmd.Parameters.AddWithValue("@1", strGroupID);
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //    RefreshGrid();
            //    MessageBox.Show("Group has been removed");
            //}   
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
                AC.FillerService();

                cmbService.DisplayMember = "ServiceTypeName";
                cmbService.ValueMember = "ServiceId";
                cmbService.DataSource = AC.serviceTypesList;
                cmbService.DropDownStyle = ComboBoxStyle.DropDown;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! "+ ex);
            }
            try
            {
                AC.FillerPersonnel();

                cmbStaff.DisplayMember = "PersonnelFirstName";
                cmbStaff.ValueMember = "PersonnelId";
                cmbStaff.DataSource = AC.personnelTypesList;
                cmbStaff.DropDownStyle = ComboBoxStyle.DropDown;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!" + ex);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string strVenue;
            string strStatus;
            DateTime dtDate;
            DateTime dtTime;

            if (dgvGroups.CurrentRow == null)
                return;
            var serviceId = (string)dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[1].Value;
            var personnelId = (int)dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[2].Value;
            //var serviceID = serviceTypesList.FirstOrDefault(s => s.ServiceId == serviceId);
            //var PersonnelID = personnelTypesList.FirstOrDefault(s => s.PersonnelId == personnelId);

            strVenue = txtVenue.Text;
            strStatus = cmbStatus.SelectedItem.ToString();
            dtDate = dtpDate.Value;
            dtTime = dtpTime.Value;

            bool b = Validate(strVenue, strStatus, dtDate);
            if (b == false)
                return;

            //MessageBox.Show("service: " + strService);
            MessageBox.Show("Venue: " + strVenue);
            //MessageBox.Show("Staff: " + strStaff);
            MessageBox.Show("Time: " + dtTime.ToString());
            MessageBox.Show("Date: " + dtDate.ToString());
            MessageBox.Show("status: " + strStatus);

            bool confirm = comfirmMessage();
            if (confirm == false)
                return;

            //try
            //{
            //    conn.Open();
            //    OleDbCommand cmd = new OleDbCommand("UPDATE Group SET Service_ID = @1, Personel_ID = @2," +
            //        " Group_Venue = @3, Group_Time = @4, Group_Date = @5, Group_Status = @6  WHERE Group_ID = @7", conn); //Link foregin key
            //    cmd.Parameters.AddWithValue("@1", serviceId);
            //    cmd.Parameters.AddWithValue("@2", PersonnelID);
            //    cmd.Parameters.AddWithValue("@3", strVenue);
            //    cmd.Parameters.AddWithValue("@4", dtTime);
            //    cmd.Parameters.AddWithValue("@5", dtDate);
            //    cmd.Parameters.AddWithValue("@6", strStatus);
            //    cmd.Parameters.AddWithValue("@7", strGroupID);

            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //    RefreshGrid();
            //    MessageBox.Show("Update Successful");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("UpdateError! " + ex);
            //}
            

        }

        private void dgvGroups_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGroups.CurrentRow == null)
                return;
            strGroupID = (int)dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[0].Value;
            var serviceTypeName =  (string)dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[1].Value;
            var personnelId = (int)dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[2].Value;
            var serviceType = AC.serviceTypesList.FirstOrDefault(s => s.ServiceTypeName == serviceTypeName);
            var PersonnelName = AC.personnelTypesList.FirstOrDefault(s => s.PersonnelId == personnelId);
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

        private bool Validate(string strVenue, string strStatus, DateTime dtDate)
        {
            bool bValid = true;
            if (String.IsNullOrEmpty(strVenue))
            {
                bValid = false;
                MessageBox.Show("Venue cannot be empty","Input Error");
            }
            if (String.IsNullOrEmpty(strStatus))
            {
                bValid = false;
                MessageBox.Show("Select a meeting status","Input Error");
            }
            if (dtDate <= DateTime.Now)
            {
                bValid = false;
                MessageBox.Show("Date must be in the future","Input error");
            }
            if (cmbService.SelectedIndex == 0)
            {
                bValid = false;
                MessageBox.Show("Select a Servise Type", "Input error");
            }
            if (cmbStaff.SelectedIndex == 0)
            {
                bValid = false;
                MessageBox.Show("Select a Personnel Member", "Input error");
            }
            return (bValid);
        }
    
    }
}
