using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stuport.Groups
{
    public partial class Groups : Form
    {
        static string _path = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "StuportDatabase.accdb";
        OleDbConnection conn = new OleDbConnection(_path);
        public Groups()
        {
            InitializeComponent();
        }



        
    }
}
