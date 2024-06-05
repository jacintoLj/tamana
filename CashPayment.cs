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
    public partial class CashPayment : Form
    {
        public CashPayment()
        {
            InitializeComponent();
        }

        private void Compute_Click(object sender, EventArgs e)
        {       
                double recievePayment = double.Parse(RPayment.Text);
                double totalBalance = double.Parse(textBox2.Text);
                double change = recievePayment - totalBalance  ;

                label5.Text = RPayment.Text;
                label6.Text = textBox2.Text;
                label7.Text = Convert.ToString(change);

                
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl3payment cb = new UserControl3payment();
            cb.Show();
            cb.Hide();
            
        }
    }
}
