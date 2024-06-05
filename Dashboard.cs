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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
           
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
          
            UCmachinelist UCmachinelist = new UCmachinelist();
            this.Show();
            UCmachinelist.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(UCmachinelist);
            UCmachinelist.BringToFront();
        }        
        


        private void MenuButton_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPayment_Click(object sender, EventArgs e)
        {
            UserControl3payment UserControl3payment = new UserControl3payment();
            this.Show();
            UserControl3payment.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(UserControl3payment);
            UserControl3payment.BringToFront();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            UClogout UClogout = new UClogout();
            this.Show();
            UClogout.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(UClogout);
            UClogout.BringToFront();
        }

        private void machineIconHome_Click(object sender, EventArgs e)
        {
            UCdashboard UCdashboard = new UCdashboard();
            this.Show();
            UCdashboard.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(UCdashboard);
            UCdashboard.BringToFront();
            ;        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            UCadmin UCadmin = new UCadmin();
            this.Show();
            UCadmin.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(UCadmin);
            UCadmin.BringToFront();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}
