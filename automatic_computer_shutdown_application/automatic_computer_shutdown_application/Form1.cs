using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automatic_computer_shutdown_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (second.Value > 0)
            {
                int closeDuration = (int)second.Value;
                Process.Start("shutdown", $"/s /t {closeDuration * 60}");
                MessageBox.Show($"{closeDuration} minute after the computer will shut down!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (second.Value <= 0)
            {
                MessageBox.Show("Do not enter the value as empty or missing", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("User problematic error!", "Big error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (second.Value > 0)
            {
                Process.Start("shutdown", "/a");
                MessageBox.Show("Transaction canceled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (second.Value <= 0)
            {
                MessageBox.Show("Enter the time!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Enter the time!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string computerName = Environment.MachineName;
            MessageBox.Show($"Thank you for using my application {computerName}", "Ahmet TOPAL's Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
