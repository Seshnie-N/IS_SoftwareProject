using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Stuport
{
    public partial class StudentProfile : Form
    {
        public StudentProfile()
        {
            InitializeComponent();
        }

        StudentController SC = new StudentController();
        String stdNum = "";
        String stdFname = "";
        String stdLname = "";
        String stdEmail = "";
        String stdPhone = "";

        static string _path = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "StuportDatabase.accdb";
        OleDbConnection conn = new OleDbConnection(_path);

        private void StudentProfile_Load(object sender, EventArgs e)
        {

            stdNum = SC.getStdNum();
            stdnumtb.Text = stdNum;

            stdFname = SC.getFname();
            fntb.Text = stdFname;

            stdLname = SC.getLname();
            lntb.Text = stdLname;

            stdEmail = SC.getEmail();
            emailtb.Text = stdEmail;

            stdPhone = SC.getPhone();
            phnumtb.Text = stdPhone;

            refreshGrid();


        }

        private void refreshGrid()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT Student_ID, Student_FirstName,Student_LastName,Student_Email, Student_Phone FROM Student", conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void backbtn_Click(object sender, EventArgs e)
        {
            StudentMenu stdmenu = new StudentMenu();
            stdmenu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String stdNumTemp = stdnumtb.Text;
            String stdFnameTemp = fntb.Text;
            String stdLnameTemp = lntb.Text;
            String stdEmailTemp = emailtb.Text;
            String stdPhoneTemp = phnumtb.Text;

            conn.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE Student SET Student_FirstName = @1, Student_LastName = @2," +
                " Student_Email = @3, Student_Phone = @4 WHERE Student_ID = @5", conn);
            cmd.Parameters.AddWithValue("@1", stdFnameTemp);
            cmd.Parameters.AddWithValue("@2", stdLnameTemp);
            cmd.Parameters.AddWithValue("@3", stdEmailTemp);
            cmd.Parameters.AddWithValue("@4", stdPhoneTemp);
            cmd.Parameters.AddWithValue("@5", stdNumTemp);

            cmd.ExecuteNonQuery();
            conn.Close();
            refreshGrid();
            MessageBox.Show("Update Successful");


        }
    }
}
