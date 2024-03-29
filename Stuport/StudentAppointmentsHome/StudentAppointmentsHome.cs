﻿using System;
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
    public partial class StudentAppointmentsHome : Form
    {
        public StudentAppointmentsHome()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentMenu studentMenu = new StudentMenu();
            studentMenu.Show();
        }

        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            MakeAppointment makeAppointment = new MakeAppointment();
            makeAppointment.ShowDialog();
        }
    }
}
