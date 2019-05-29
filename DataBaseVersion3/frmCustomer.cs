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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Text);
            Customer who = new Customer();
            who = Datalayer.CustomerDB.GetCustomer(ID);

            lblCustomerID.Text = who.CustomerID.ToString();
            lblName.Text = who.Name;
            lblAddress.Text = who.Address;
            lblCity.Text = who.City;
            lblState.Text = who.State;
            lblZipCode.Text = who.ZipCode;


        }

        private void button2_Click(object sender, EventArgs e)
        {
          int response =  Datalayer.CustomerDB.AddCustomer(txtName.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtZipcode.Text);
            if (response == 0)
            {
                //error
                MessageBox.Show("error");
             }
            else
            {
              //success
           }
        }
    }
}
