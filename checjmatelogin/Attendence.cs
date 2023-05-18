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
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
        }

        private void Attendence_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bonus bonus = new Bonus();
            bonus.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary_Home salary_Home = new Salary_Home();
            salary_Home.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Issue_Salary issue_Salary = new Issue_Salary();
            issue_Salary.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees employees = new Employees();
            employees.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            End end = new End();
            end.ShowDialog();
        }
    }
}
