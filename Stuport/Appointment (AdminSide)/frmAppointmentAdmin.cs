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
using Stuport.Appointment_Service.Model;
using Stuport.Appointment_personnel.Model;

namespace Stuport.Appointment__AdminSide_
{
    public partial class frmAppointmentAdmin : Form
    {
        AdminController.AdminController AC = new AdminController.AdminController();

        int intAppointmentID;

        public frmAppointmentAdmin()
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
                AC.RefreshGridAppointment(ref dt);
                dgvAppointments.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex);
            }
        }

        private void frmAppointmentAdmin_Load(object sender, EventArgs e)
        {

        } //DO NOT TOUCH

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string strStudent;
            string strStatus;
            DateTime dtDate;
            string strTime;

            if (dgvAppointments.CurrentRow == null)
                return;
            var serviceType = (string)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[1].Value;
            var personnelId = (int)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[2].Value;
            var ServiceType = AC.serviceTypesList.FirstOrDefault(s => s.ServiceTypeName == serviceType);
            var id = (int)ServiceType.ServiceId;


            strStudent = txtStudent.Text;
            strStatus = txtStatus.Text;
            dtDate = dtpDate.Value;
            strTime = txtTime.Text;

            bool b = Validate(strStatus, dtDate);
            if (b == false)
                return;

            bool confirm = comfirmMessage("Are you sure you want to update this group!");
            if (confirm == false)
                return;

            AC.updateAppointment(intAppointmentID, id, personnelId, dtDate, strTime, strStatus, strStudent);
            RefreshGrid();

            MessageBox.Show("Appointment Updated", "Success!");
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
                MessageBox.Show("Error occured! " + ex);
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
                // write exception info to log or anything else
                MessageBox.Show("Error occured!" + ex);
            }
        }

        //private void dgvAppointments_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dgvAppointments.CurrentRow == null)
        //        return;
        //    intAppointmentID = (int)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[0].Value;
        //    var serviceTypeName = (string)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[1].Value;
        //    var personnelId = (int)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[2].Value;
        //    var serviceType = AC.serviceTypesList.FirstOrDefault(s => s.ServiceTypeName == serviceTypeName);
        //    var PersonnelName = AC.personnelTypesList.FirstOrDefault(s => s.PersonnelId == personnelId);
        //    var StudentNumber = (string)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[3].Value;
        //    var GroupTime = (string)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[5].Value;
        //    var GroupDate = (DateTime)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[4].Value;
        //    var GroupStaus = (string)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[6].Value;
        //    cmbService.SelectedValue = serviceType.ServiceId;
        //    cmbStaff.SelectedValue = PersonnelName.PersonnelId;
        //    txtTime.Text = GroupTime;
        //    dtpDate.Value = GroupDate;
        //    txtStatus.Text = GroupStaus;
        //    txtStudent.Text = StudentNumber;
        //}

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool confirm = comfirmMessage("Are you sure you want to delete this Appointment");
            if (confirm == true)
            {
                var AppointmentID = (int)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[0].Value;
                AC.removeAppointment(AppointmentID);
                RefreshGrid();
                MessageBox.Show("Appointment has been removed");
            }
        } 

        private bool Validate( string strStatus, DateTime dtDate)
        {
            bool bValid = true;
            if (String.IsNullOrEmpty(strStatus))
            {
                bValid = false;
                MessageBox.Show("Select a meeting status", "Input Error");
            }
            if (dtDate <= DateTime.Now)
            {
                bValid = false;
                MessageBox.Show("Date must be in the future", "Input error");
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }

        private void dgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
                return;
            intAppointmentID = (int)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[0].Value;
            var serviceTypeName = (string)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[1].Value;
            var personnelId = (int)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[2].Value;
            var serviceType = AC.serviceTypesList.FirstOrDefault(s => s.ServiceTypeName == serviceTypeName);
            var PersonnelName = AC.personnelTypesList.FirstOrDefault(s => s.PersonnelId == personnelId);
            var StudentNumber = (string)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[3].Value;
            var GroupTime = (string)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[5].Value;
            var GroupDate = (DateTime)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[4].Value;
            var GroupStaus = (string)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[6].Value;
            cmbService.SelectedValue = serviceType.ServiceId;
            cmbStaff.SelectedValue = PersonnelName.PersonnelId;
            txtTime.Text = GroupTime;
            dtpDate.Value = GroupDate;
            txtStatus.Text = GroupStaus;
            txtStudent.Text = StudentNumber;
        }
    }
}
