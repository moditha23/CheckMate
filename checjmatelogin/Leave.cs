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
    public partial class Leave : Form
    {
        public Leave()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Check_Salary check_Salary = new Check_Salary();
            check_Salary.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Complaint_Employee emp = new Complaint_Employee();
            emp.ShowDialog();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            End end = new End();
            end.ShowDialog();
        }
    }
}
