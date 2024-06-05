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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void ButtonPayment_Click(object sender, EventArgs e)
        {
            Payment card = new Payment();   


         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashPayment co = new CashPayment();
            co.Show();
            this.Hide();
        }

        private void dateTimePickerOrders_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            MachineList machine = new MachineList();
            machine.Show();
            this.Hide();
        }

        private void machineIconHome_Click(object sender, EventArgs e)
        {
            Dashboard DB = new Dashboard();
            DB.Show();
            this.Hide();
        }
    }
}
