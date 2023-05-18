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
    public partial class Check_Salary : Form
    {
        public Check_Salary()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leave leave = new Leave();
            leave.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Complaint_Employee emp = new Complaint_Employee();
            emp.ShowDialog();
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
