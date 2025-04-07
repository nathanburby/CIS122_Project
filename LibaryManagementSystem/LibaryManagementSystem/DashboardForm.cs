using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibaryManagementSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will open the Borrow/Return screen.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will open the Add Book screen.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will open the View Book screen.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will open the users's managing screen.");
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will log out the screen");
        }
    }
}
