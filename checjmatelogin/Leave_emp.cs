using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace checjmatelogin
{
    public partial class Leave_emp : Form
    {
        public Leave_emp()
        {
            InitializeComponent();
            DisplayAccount();
            Reset();
            textBoxid.Text = login2.EmpID;
        }

        SqlConnection Con = new SqlConnection("Data Source=laptop-6jt31sc8;Initial Catalog=Checkmate2;Integrated Security=True");
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

        private void DisplayAccount()
        {
            Con.Open();
            string Query = "Select Employee_ID,Beginning,Ending,Decision from Leave ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Reset()
        {
            textBoxfrom.Text = "";
            textBoxto.Text = "";
            richTextBoxreason.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxid.Text == "" || textBoxfrom.Text == "" || textBoxto.Text == "" || richTextBoxreason.Text == "" )
            {
                MessageBox.Show("Missing Information", "CheckMate");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Leave(Employee_ID,Beginning,Ending,Reason)values(@eid,@ef,@et,@er)", Con);
                    cmd.Parameters.AddWithValue("@eid", textBoxid.Text);
                    cmd.Parameters.AddWithValue("@ef", textBoxfrom.Text);
                    cmd.Parameters.AddWithValue("@et", textBoxto.Text);
                    cmd.Parameters.AddWithValue("@er", richTextBoxreason.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Leave Requested!", "CheckMate");
                    Con.Close();
                    DisplayAccount();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Leave_emp lg= new Leave_emp();
            lg.ShowDialog();
            this.Hide();
        }

        private void Leave_emp_Load(object sender, EventArgs e)
        {

        }
    }
}
