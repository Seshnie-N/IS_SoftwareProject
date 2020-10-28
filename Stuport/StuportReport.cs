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
    public partial class StuportReport : Form
    {
        public StuportReport()
        {
            InitializeComponent();
        }

        private void StuportReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StuportDatabaseDataSetGroups.Group' table. You can move, or remove it, as needed.
            this.GroupTableAdapter.Fill(this.StuportDatabaseDataSetGroups.Group);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
