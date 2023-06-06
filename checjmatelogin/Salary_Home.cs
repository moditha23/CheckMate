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
    public partial class Salary_Home : Form
    {
        public Salary_Home()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bonus bonus = new Bonus();
            bonus.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();

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

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            End end = new End();
            end.ShowDialog();
        }

        private void label11_Click_1(object sender, EventArgs e)
        {
            Leave_Admin la = new Leave_Admin();
            la.ShowDialog();
            this.Hide();
        }
    }
}
