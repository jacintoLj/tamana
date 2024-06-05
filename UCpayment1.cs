using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManagementSystem
{
    public partial class UCpayment1 : UserControl
    {
        public UCpayment1()
        {
            InitializeComponent();
        }

        public string CNameP { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           UserControl3payment UCpayment1 = new UserControl3payment();
            this.Show();
            UCpayment1.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(UCpayment1);
            UCpayment1.BringToFront();
        }

        private void computeChange_Click(object sender, EventArgs e )
        {
          ;
            double recievePayment = double.Parse(RPayment.Text);
            double totalBalance = double.Parse(textBox2.Text);
            double change = recievePayment - totalBalance;
            label5.Text = RPayment.Text;
            label6.Text = textBox2.Text;
            label7.Text = Convert.ToString(change);
            MessageBox.Show("Transaction Complete");
            MessageBox.Show("\tRECIEPT" +
                "\n\n\n Customer Name: " + NameMo.Text +
                "\n\n\Order ID: " + IDMo.Text +
                "\n\n\nPayement Recieved:" + RPayment.Text +
                 "\n\n\nTotal Balance:" + textBox2.Text + 
                "\n\n\nChange: " + change );
        }

        
    }
}
