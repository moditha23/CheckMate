using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace checjmatelogin
{
    public partial class login2 : Form
    {

        public static string EmpID = "";
        public login2()
        {
            InitializeComponent();
            EmpID = textBoxloginID.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acc_Reg Reg = new Acc_Reg();
            Reg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leave_Admin Hf = new Leave_Admin();
            Hf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees employees = new Employees();
            employees.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary_Home_Employer_View salary_Home_Employer_View = new Salary_Home_Employer_View();
            salary_Home_Employer_View.ShowDialog();
        }


        private void btn_login1_Click(object sender, EventArgs e)
        {
            Check_Salary check_Salary= new Check_Salary();
            check_Salary.ShowDialog();
            this.Hide();
            EmpID= textBoxloginID.Text;
        }
    }
}
