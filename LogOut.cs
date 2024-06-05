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
    public partial class LogOut : Form
    {
        public LogOut()
        {
            InitializeComponent();
        }

        private void YesLogoutButton_Click(object sender, EventArgs e)
        {
            LoginHomepage login = new LoginHomepage();
            login.Show(); 
            this.Hide();
        }

        private void NoLogoutButton_Click(object sender, EventArgs e)
        {

            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
    }
}
