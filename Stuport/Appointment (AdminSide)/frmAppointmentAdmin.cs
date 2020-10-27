﻿using System;
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

        string strAppointmentID;

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

        } //TODO

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

        private void dgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
                return;
            strAppointmentID = (string)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[0].Value;
            var serviceTypeName = (string)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[1].Value;
            var personnelId = (int)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[2].Value;
            var serviceType = AC.serviceTypesList.FirstOrDefault(s => s.ServiceTypeName == serviceTypeName);
            var PersonnelName = AC.personnelTypesList.FirstOrDefault(s => s.PersonnelId == personnelId);
            var StudentNumber = (string)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[1].Value;
            var GroupTime = (DateTime)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[5].Value;
            var GroupDate = (DateTime)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[4].Value;
            var GroupStaus = (string)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[6].Value;
            cmbService.SelectedValue = serviceType.ServiceId;
            cmbStaff.SelectedValue = PersonnelName.PersonnelId;
            dtpTime.Value = GroupTime;
            dtpDate.Value = GroupDate;
            txtStatus.Text = GroupStaus;
            txtStudent.Text = StudentNumber;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool confirm = comfirmMessage();
            if (confirm == true)
            {
                var AppointmentID = (int)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[0].Value;
                AC.removeAppointment(AppointmentID);
                RefreshGrid();
                MessageBox.Show("Appointment has been removed");
            }
        } 

        private bool Validate()
        {
            return false;
        } //TODO

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

    }
}
