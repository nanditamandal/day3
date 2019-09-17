using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffe_shop
{
    public partial class Coffeeshop : Form
    {
        string [] customername= new string[10];
        string [] address = new string[10];
        string [] mobile = new string[10];
        string [] order = new string[10];
        string [] quantity = new string[10];
        int index=0, q,price, totalprice;
        string value;


        public Coffeeshop()
        {
            InitializeComponent();
        }


        private void savebutton1_Click(object sender, EventArgs e)
        {
            displayrichTextBox1.Text = " ";

            customername[index] = nametextBox1.Text;
            address[index] = addresstextBox3.Text;
            mobile[index] = contacttextBox2.Text;
            order[index] = ordercomboBox1.Text;
            quantity[index] = quantitytextBox4.Text;

            q = int.Parse(quantity[index]);

            if (order[index] == "Black-120")
            {
                price = 120;
                totalprice = price * q;
            }
            else if (order[index] == "Cold-100")
            {
                price = 100;
                totalprice = price * q;
            }
            else if (order[index] == "Hot-90")
            {
                price = 90;
                totalprice = price * q;
            }
            else if (order[index] == "Regular-80")
            {
                price = 80;
                totalprice = price * q;
            }

            value += "name\t" + customername[index] + Environment.NewLine +
                   "address\t" + address[index] + Environment.NewLine +
                   "contact number\t" + mobile[index] + Environment.NewLine +
                  "order\t" + order[index] + Environment.NewLine +
                  "quantity\t" + quantity[index] + Environment.NewLine +
                   "total price:\t" + Convert.ToString(totalprice) + Environment.NewLine;

            displayrichTextBox1.Text = value;
            index++;
        }
        private void contacttextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void quantitytextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}







