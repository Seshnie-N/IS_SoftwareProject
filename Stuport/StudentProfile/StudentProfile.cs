using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stuport.StudentMenu
{
    public partial class StudentProfile : Form
    {
        public StudentProfile()
        {
            InitializeComponent();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            StudentController SC = new StudentController();
            String stdNum = stdNumtb.Text;
            stdNum = SC.getStudentNum();
            stdNumtb.Text = stdNum;

        }

        private void stdNumtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
