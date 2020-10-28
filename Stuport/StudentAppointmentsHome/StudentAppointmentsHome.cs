using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stuport
{

    public partial class StudentAppointmentsHome : DevExpress.XtraEditors.XtraForm
    {

        StudentController sC = new StudentController();
        int AppointmentID = 0;
        public StudentAppointmentsHome()
        {
            InitializeComponent();
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            try
            {
                DataTable dt = new DataTable();
                sC.RefreshGridAppointment(ref dt);
                dgvAppointment.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentMenu studentMenu = new StudentMenu();
            studentMenu.Show();
        }

        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            MakeAppointment makeAppointment = new MakeAppointment();
            makeAppointment.ShowDialog();
        }

        private void btnGroupSessions_Click(object sender, EventArgs e)
        {
            GroupPage groupPage = new GroupPage();
            this.Hide();
            groupPage.Show();
        }

        private void StudentAppointmentsHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stuportDatabaseDataSet3.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.stuportDatabaseDataSet3.Appointment);

        }

        private void DgvAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BntCancelAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointment.SelectedRows.Count == 1)
            {
                DataGridViewSelectedRowCollection row =dgvAppointment.SelectedRows;
                AppointmentID = (int)row[0].Cells[0].Value;
            }
            else
            {
                MessageBox.Show("Please Select A Single Row");
            }

            if (AppointmentID > 0)
            {

                bool confirm = comfirmMessage("Are you sure you want to cancel your appointment?");
                if (confirm)
                {
                    sC.CancelAppointment(AppointmentID);
                RefreshGrid();
                    MessageBox.Show("Appointment Cancelled", "Cancelled");
                }

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

    }



}
