using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datalayer;
using BusinessLayer;

namespace DataBaseVersion3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Datalayer.StateDB.GetStates();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomer f = new frmCustomer();
            f.Show();
        }
    }
}
