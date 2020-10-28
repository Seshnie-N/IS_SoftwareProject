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
    public partial class Other_Services : DevExpress.XtraEditors.XtraForm
    {
        public Other_Services()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void financialbtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Follow link?", "Visit", MessageBoxButtons.YesNo, MessageBoxIcon.Information)== DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.wits.ac.za/study-at-wits/fees-and-funding/financial-aid-and-scholarships-office/contact-us/");
            }
          //  MessageBox.Show("https://www.wits.ac.za/study-at-wits/fees-and-funding/financial-aid-and-scholarships-office/contact-us/", "Visit");
        }

        private void residencebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Follow link?", "Visit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.wits.ac.za/accommodation/");
            }

           // MessageBox.Show("https://www.wits.ac.za/accommodation/", "Visit");
        }

        private void Other_Services_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {this.Hide();
            StudentMenu stdmenu = new StudentMenu();
            stdmenu.Show();
            
        }
    }
}
