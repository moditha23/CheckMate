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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary_Home salary_Home = new Salary_Home();
            salary_Home.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bonus bonus = new Bonus();
            bonus.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendence attendence = new Attendence();
            attendence.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Issue_Salary issue_Salary = new Issue_Salary();
            issue_Salary.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            End end = new End();
            end.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees employees = new Employees();
            employees.ShowDialog();
        }
    }
}
