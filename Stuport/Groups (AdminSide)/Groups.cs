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
        int intGroupID;
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool confirm = comfirmMessage("Are you sure you want to delete this group");
            if (confirm == true)
            {
                intGroupID = (int)dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[0].Value;
                AC.removeGroup(intGroupID);
                RefreshGrid();
                MessageBox.Show("Group has been removed");
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
            var serviceType = (string)dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[1].Value;
            var personnelId = (int)dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[2].Value;
            var ServiceType = AC.serviceTypesList.FirstOrDefault(s => s.ServiceTypeName == serviceType);
            var Serviceid = (int)ServiceType.ServiceId;
            
            strVenue = txtVenue.Text;
            strStatus = txtStatus.Text;
            dtDate = dtpDate.Value;
            dtTime = dtpTime.Value;

            bool b = Validate(strVenue, strStatus, dtDate);
            if (b == false)
                return;

            bool confirm = comfirmMessage("Are you sure you want to update this group!");
            if (confirm == false)
                return;

            AC.updateGroup(intGroupID, Serviceid, personnelId, dtDate, dtTime, strStatus, strVenue);
            RefreshGrid();
            MessageBox.Show("Group Updated Successfully", "Success");

        } //TODO

        private void dgvGroups_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGroups.CurrentRow == null)
                return;
            intGroupID = (int)dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[0].Value;
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
            txtStatus.Text = GroupStaus;
            txtVenue.Text = GroupVenue;  
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

        private void DgvGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Groups_Load(object sender, EventArgs e)
        {

        }
    }
}
