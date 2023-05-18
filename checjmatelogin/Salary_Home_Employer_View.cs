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
    public partial class Salary_Home_Employer_View : Form
    {
        public Salary_Home_Employer_View()
        {
            InitializeComponent();
        }

        private void Salary_Home_Employer_View_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Complaint_Review_Employer complaint_Review_Employer = new Complaint_Review_Employer();
            complaint_Review_Employer.ShowDialog();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            End end = new End();
            end.ShowDialog();
        }
    }
}
