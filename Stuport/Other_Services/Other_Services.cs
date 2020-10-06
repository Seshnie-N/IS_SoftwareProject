using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stuport_section
{
    public partial class Other_Services : Form
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
            MessageBox.Show("https://www.wits.ac.za/study-at-wits/fees-and-funding/financial-aid-and-scholarships-office/contact-us/");
        }

        private void residencebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("https://www.wits.ac.za/accommodation/");
        }
    }
}
