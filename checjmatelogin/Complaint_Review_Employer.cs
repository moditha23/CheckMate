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
    public partial class Complaint_Review_Employer : Form
    {
        public Complaint_Review_Employer()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary_Home_Employer_View salview = new Salary_Home_Employer_View();
            salview.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            End end = new End();
            end.ShowDialog();
        }
    }
}
