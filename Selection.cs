using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormado
{
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void btnempdetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Employeedetails().ShowDialog();
        }

        private void btnbackk_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
        }

        private void btnemppayroll_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Payroll().ShowDialog();
        }
    }
}
