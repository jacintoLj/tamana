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
    public partial class MachineList : Form
    {
        public MachineList()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
             
        }

        private void ButtonPayment_Click(object sender, EventArgs e)
        {
            Payment card = new Payment();
            card.Show();
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
