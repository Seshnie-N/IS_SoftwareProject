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
        static string _path = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ReposUni\IS_SoftwareProject\Stuport\bin\Debug\StuportDatabase.accdb";
        private OleDbConnection conn;
        private OleDbCommand dbCommand;

        private List<ServiceType> serviceTypesList;
        private List<PersonnelType> personnelTypesList;

        string strAppointmentID;


        public frmAppointmentAdmin()
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
                dgvAppointments.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex);
            }
        }

        private void frmAppointmentAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("Error occured! " + ex);
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

        private void dgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
                return;
            strAppointmentID = (string)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[0].Value;
            var serviceTypeName = (string)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[4].Value;
            var personnelId = (int)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[3].Value;
            var serviceType = serviceTypesList.FirstOrDefault(s => s.ServiceTypeName == serviceTypeName);
            var PersonnelName = personnelTypesList.FirstOrDefault(s => s.PersonnelId == personnelId);
            var GroupTime = (DateTime)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[2].Value;
            var GroupDate = (DateTime)dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[1].Value;
            cmbService.SelectedValue = serviceType.ServiceId;
            cmbStaff.SelectedValue = PersonnelName.PersonnelId;
            dtpTime.Value = GroupTime;
            dtpDate.Value = GroupDate;
        }
    }
}
