using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checjmatelogin
{
    public partial class Leave_Admin : Form
    {
        public Leave_Admin()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees employees = new Employees();
            employees.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Departments departments = new Departments();
            departments.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary_Home salary_Home = new Salary_Home();
            salary_Home.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            End end = new End();
            end.ShowDialog();
        }
    }
}
