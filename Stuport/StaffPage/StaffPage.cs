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
using System.Configuration;

namespace Stuport
{
    public partial class StaffPage : Form
    {
        int staffID =0;
        public StaffPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stuportDatabaseDataSet.Personnel' table. You can move, or remove it, as needed.
            this.personnelTableAdapter.Fill(this.stuportDatabaseDataSet.Personnel);
            // TODO: This line of code loads data into the 'stuportDatabaseDataSet.Personnel' table. You can move, or remove it, as needed.
            this.personnelTableAdapter.Fill(this.stuportDatabaseDataSet.Personnel);
            // TODO: This line of code loads data into the 'stuportDatabaseDataSet.Staff' table. You can move, or remove it, as needed.


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void StaffTableGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }


        private void BtnAddStaff_Click(object sender, EventArgs e)
        {
            Form AddStaffForm = new AddStaff();
            AddStaffForm.ShowDialog();
        }

        private void BtnUpdateDetails_Click(object sender, EventArgs e)
        {
            
            if (StaffTableGridView.SelectedRows.Count == 1 )
            {
                DataGridViewSelectedRowCollection row = StaffTableGridView.SelectedRows;
                staffID = (int)row[0].Cells[0].Value;
            }
            else {
                MessageBox.Show("Please Select A Single Row");
            }
           
            if (staffID>1)
            {
            Form UpdateStaff = new UpdateDetails(staffID);
            UpdateStaff.ShowDialog();
            }

        }

        public void loaddata()
        {

            this.personnelTableAdapter.Fill(this.stuportDatabaseDataSet.Personnel);

        }





        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }
    }
}
