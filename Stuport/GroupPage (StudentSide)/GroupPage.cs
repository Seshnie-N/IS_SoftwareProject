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
    public partial class GroupPage : Form
    {
        string username =Global.Token;

        static string _path = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        OleDbConnection conn = new OleDbConnection(_path);

        String activeGroupName;
        String groupID1;
        String groupID2;
        String groupCounter;
        int counter;
        String updatedCounter;
        String groupID3;
        String GroupName;

        public GroupPage()
        {
            InitializeComponent();
            GetGroupInfo();
            activeGroups();
            inactiveGroups();

        }

        private bool confirmMessage()
        {
            string message = "Are you sure you want join the " + activeGroupName + " group";
            string caption = "Confirmation";
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

        private bool confirmMessage2()
        {
            string message = "Are you sure you want leave the " + GroupName + " group";
            string caption = "Confirmation";
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

        private bool warningMessage()
        {
            string message = "You have already joined this group";
            string caption = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1,
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

        public void GetGroupInfo()
        {
            try
            {
                DataTable dt = new DataTable();

                string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
                OleDbConnection con = new OleDbConnection(connectionString);
                OleDbCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "SELECT StudentGroup.Group_ID AS [Group Number], Service_Description AS [Group Topic], Personnel_FirstName & ' ' & Personnel_LastName as Iinvigilator,Group_Venue as Venue,Group_Time & '  ' & Group_Date AS[Date - Time] FROM [Group], Service, Personnel, StudentGroup WHERE Group.Service_ID = Service.Service_ID And Group.Personnel_ID = Personnel.Personnel_ID And Group.Group_ID = StudentGroup.Group_ID And StudentGroup.Student_ID =?";
                cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = username });

                OleDbDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                // always call Close when done reading.
                reader.Close();

                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                con.Close();
                dgvGroups.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void activeGroups()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();

                OleDbDataAdapter da = new OleDbDataAdapter("select Group_ID as [Group Number], Service_Description AS [Group Topic] from[Group], Service where Group.Service_ID = Service.Service_ID and Group_Status ='Active'", conn);
                da.Fill(dt);
                dgvActiveGroups.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void inactiveGroups()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select Group_ID as [Group Number], Service_Description AS [Group Topic] from[Group], Service where Group.Service_ID = Service.Service_ID and Group_Status ='Inactive'", conn);
                da.Fill(dt);
                dgvRequestGroup.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void GroupPage_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StudentAppointmentsHome sth = new StudentAppointmentsHome();
            sth.Show();
            this.Close();
        }


        private void dgvGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            groupID3 = dgvGroups.Rows[e.RowIndex].Cells[0].Value.ToString();
            GroupName = dgvGroups.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnJoinGroup_Click(object sender, EventArgs e)
        {
            try
            {
                bool cfnmsg = confirmMessage();
                if (cfnmsg == true)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
                    OleDbConnection con = new OleDbConnection(connectionString); OleDbCommand cmd = con.CreateCommand();

                    int gID = Convert.ToInt32(groupID1);

                    cmd.CommandText = "Insert into StudentGroup" +
                        "([Student_ID],[Group_ID])" +
                        "Values(?,?)";
                    cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = username });
                    cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 50) { Value = gID });

                    con.Open();
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                warningMessage();
            }
        }

        private void bntRequestGroup_Click(object sender, EventArgs e)
        {
            bool cfnmsg = confirmMessage();
            bool requestchk = true;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
                OleDbConnection con = new OleDbConnection(connectionString);
                OleDbCommand cmd = con.CreateCommand();

                int gID = Convert.ToInt32(groupID2);

                cmd.CommandText = "Insert into StudentRequest" +
                    "([Student_ID],[Group_ID])" +
                    "Values(?,?)";
                cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = username });
                cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 50) { Value = gID });

                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception exc)
            {
                requestchk = false;
                MessageBox.Show("You Have Already Requested for this group");
            }

            if (requestchk == true)
            {
                if (cfnmsg == true)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
                    OleDbConnection con = new OleDbConnection(connectionString);
                    OleDbCommand cmd = con.CreateCommand();

                    int gID = Convert.ToInt32(groupID2);

                    cmd.CommandText = "UPDATE [Group] SET[Std_Counter] = [Std_Counter] + 1 WHERE Group_ID = ?";
                    cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 50) { Value = gID });

                    con.Open();
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Your request was sent successfully");
                }
            }

            //request sent message box

            //Admin side
            //view Group table like student does but all groups
            //changes active or inactive 
            //changes description,venue,time,date
            //update group table

        }

        private void dgvActiveGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            groupID1 = dgvActiveGroups.Rows[e.RowIndex].Cells[0].Value.ToString();
            activeGroupName = dgvActiveGroups.Rows[e.RowIndex].Cells[1].Value.ToString();
            //Console.WriteLine(groupID);
            Globe.activeGroupID = groupID1;
        }

        private void dgvRequestGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            groupID2 = dgvRequestGroup.Rows[e.RowIndex].Cells[0].Value.ToString();
            Console.WriteLine(groupID2);
        }

        private void BtnGroupDetails_Click(object sender, EventArgs e)
        {
            StudentGroupDetails sgd = new StudentGroupDetails();
            sgd.Show();
        }

        private void minimizelbl_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitlbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void leaveGroupbtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool cfnmsg = confirmMessage2();
                if (cfnmsg == true)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
                    OleDbConnection con = new OleDbConnection(connectionString); OleDbCommand cmd = con.CreateCommand();

                    int gID = Convert.ToInt32(groupID3);

                    cmd.CommandText = "Delete from StudentGroup Where Student_ID =? AND Group_ID =?";
                    cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = username });
                    cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 50) { Value = gID });

                    con.Open();
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
