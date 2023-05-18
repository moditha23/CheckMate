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
    public partial class login2 : Form
    {
        public login2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary_Home_Employer_View salary_Home_Employer_View = new Salary_Home_Employer_View();
            salary_Home_Employer_View.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees employees = new Employees();
            employees.ShowDialog();
        }

        private void btn_login1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Check_Salary check_Salary = new Check_Salary();
            check_Salary.ShowDialog();

        }
    }
}
