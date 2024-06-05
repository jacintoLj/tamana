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
    public partial class UserControl3payment : UserControl
    {
        public UserControl3payment()
        {
            InitializeComponent();
        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            UCpayment1 UCpayment1 = new UCpayment1();
            this.Show();
            UCpayment1.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(UCpayment1);
            UCpayment1.BringToFront();


        }

       
    }
}
