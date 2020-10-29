using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stuport
{
    public partial class StudentGroupDetails : Form
    {

        String groupID = Globe.activeGroupID;

        public StudentGroupDetails()
        {
            InitializeComponent();
        }

        public void GetGroupInfo()
        {
            try
            {
                DataTable dt = new DataTable();

                string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
                OleDbConnection con = new OleDbConnection(connectionString);
                OleDbCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "SELECT Service_Description AS [Group Topic], Personnel_FirstName & ' ' & Personnel_LastName as Iinvigilator,Group_Venue as Venue,Group_Time & '  ' & Group_Date AS[Date - Time] FROM [Group], Service, Personnel WHERE Group.Service_ID = Service.Service_ID And Group.Personnel_ID = Personnel.Personnel_ID And Group_Status ='Active' AND Group.Group_ID = ?";
                int gID = Convert.ToInt32(groupID);
                cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = gID });

                OleDbDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                // always call Close when done reading.
                reader.Close();

                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                con.Close();
                dgvGroupDetails.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void StudentGroupDetails_Load(object sender, EventArgs e)
        {
            GetGroupInfo();
        }

        private void exitlbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizelbl_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
