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
    public partial class Appointment: Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //Add column header
            listView1.Columns.Add("Appointment Topic", 300);
            listView1.Columns.Add("Student Name", 150);
            listView1.Columns.Add("Date", 150);

            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;

            //Add first item
            arr[0] = "Personal";
            arr[1] = "12345";
            arr[2] = "7 Nov 2020";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            //Add second item
            arr[0] = "Academic";
            arr[1] = "132466";
            arr[2] = "9 Nov 2020";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure");
        }

        private void approvebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure");
        }
    }
}
