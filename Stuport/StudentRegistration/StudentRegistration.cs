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
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword2_Click(object sender, EventArgs e)
        {

        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            StudentController SC = new StudentController();
            String StudNum = txtStudNum.Text;
            String Fname = txtFName.Text;
            String Lname = txtLName.Text;
            String Email = txtEmail.Text;
            String Phone = txtEmail.Text;
            String Password = txtPassword.Text;
            //Validation


            //Add Student;
            SC.AddStudent(StudNum,Fname, Lname, Email, Phone, Password);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TtHints_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
