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
    public partial class MakeAppointment : Form
    {
        public MakeAppointment()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentAppointmentsHome appointmentsHome = (StudentAppointmentsHome)Application.OpenForms["StudentAppointmentsHome"];
            appointmentsHome.Show();
        }
    }
}
