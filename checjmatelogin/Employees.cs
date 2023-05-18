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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
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

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leave_Admin leave_Admin = new Leave_Admin();
            leave_Admin.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            End end = new End();
            end.ShowDialog();
        }
    }
}
