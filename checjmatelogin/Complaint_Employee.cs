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
    public partial class Complaint_Employee : Form
    {
        public Complaint_Employee()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary_Home salary_Home = new Salary_Home();
            salary_Home.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leave leave = new Leave();
            leave.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            login2 lg = new login2();
            lg.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            End end = new End();
            end.ShowDialog();

        }
    }
}
