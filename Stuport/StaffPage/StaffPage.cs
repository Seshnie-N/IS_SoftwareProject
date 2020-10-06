using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuportStaff
{
    public partial class StaffPage : Form
    {
        public StaffPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stuportDatabaseDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.stuportDatabaseDataSet.Staff);

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void StaffTableGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
   
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddStaff_Click(object sender, EventArgs e)
        {
            Form AddStaffForm = new AddStaff();
            AddStaffForm.ShowDialog();
        }

        private void BtnUpdateDetails_Click(object sender, EventArgs e)
        {
            Form UpdateStaff = new UpdateDetails();
            UpdateStaff.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
