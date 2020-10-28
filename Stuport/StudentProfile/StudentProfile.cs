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
    public partial class StudentProfile : DevExpress.XtraEditors.XtraForm
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
        String username = Global.Token;

        static string _path = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "StuportDatabase.accdb";
        OleDbConnection conn = new OleDbConnection(_path);

        private void StudentProfile_Load(object sender, EventArgs e)
        {

            stdNum = SC.getStdNum();
            stdnumtb.Text = stdNum;

            stdFname = SC.getFname(username);
            fntb.Text = stdFname;

            stdLname = SC.getLname(username);
            lntb.Text = stdLname;

            stdEmail = SC.getEmail(username);
            emailtb.Text = stdEmail;

            stdPhone = SC.getPhone(username);
            phnumtb.Text = stdPhone;

        }


        private void backbtn_Click(object sender, EventArgs e)
        {   this.Hide();
            StudentMenu stdmenu = new StudentMenu();
            stdmenu.Show();
         
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
            MessageBox.Show("Update Successful");


        }
    }
}
