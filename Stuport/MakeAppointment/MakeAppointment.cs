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
    public partial class MakeAppointment : Form
    {
        public MakeAppointment()
        {
            InitializeComponent();
        }

        String ServiceType = "";
        String date="";
        String time="";

        private void MakeAppointment_Load(object sender, EventArgs e)
        {
            
            mcDate.MinDate = DateTime.Today;
            mcDate.MaxSelectionCount = 1;
            
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            bool bFlag = true;
            if (cbxServiceType.SelectedIndex==-1)
            {
                MessageBox.Show("Please choose service type");
                bFlag = false;
                cbxServiceType.Focus();
            }
            else
            {
                ServiceType = cbxServiceType.SelectedItem.ToString();
            }

            if (cbxTimeSlot.SelectedIndex==-1)
            {
                MessageBox.Show("Please choose time slot");
                bFlag = false;
                cbxTimeSlot.Focus();
            }
            else
            {
                time = cbxTimeSlot.SelectedItem.ToString();
            }
            date = mcDate.SelectionStart.ToString("dd/MM/yy");

           
            if (bFlag==true && (MessageBox.Show("Do you want to confirm the appointment?", "Confirm or cancel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                StudentController sc = new StudentController();
                sc.RequestAppointment()
                

            }
            

            
            
        }
    }
}
