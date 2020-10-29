using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stuport.CreateGroup
{
    public partial class GroupCreate : Form
    {
        public GroupCreate()
        {
            InitializeComponent();
        }

        private void GroupCreate_Load(object sender, EventArgs e)
        {

        }

        private void exitlbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizelbl_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
