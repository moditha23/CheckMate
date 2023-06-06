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

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Complaint_Employee emp = new Complaint_Employee();
            emp.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            End end = new End();
            end.ShowDialog();

        }

        private void Check_Salary_Load(object sender, EventArgs e)
        {
            textBoxid.Text = login2.EmpID;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Leave_emp lf= new Leave_emp();
            lf.ShowDialog();
            this.Hide();
        }
    }
}
