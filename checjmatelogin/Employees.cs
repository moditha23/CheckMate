using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace checjmatelogin
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            DisplayAccount();
        }

        SqlConnection Con= new SqlConnection(@"Data Source=LAPTOP-6JT31SC8;Initial Catalog=Checkmate2;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Departments departments = new Departments();
            departments.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary_Home salary_Home = new Salary_Home();
            salary_Home.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leave_Admin leave_Admin = new Leave_Admin();
            leave_Admin.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            End end = new End();
            end.ShowDialog();
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void DisplayAccount()
        {
            Con.Open();
            string Query = "Select * from EmployeeDetails ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridViewed.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Reset()
        {
            textBoxname.Text = "";
            textBoxaddress.Text = "";
            textBoxphone.Text = "";
            textBoxbasesalary.Text = "";
            textBoxDOB.Text = "";
            textBoxHD.Text = "";
            comboBoxgender.SelectedIndex = -1;
            textBoxqulifications.Text = "";
            comboBoxpositon.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxname.Text=="" || textBoxaddress.Text=="" || textBoxphone.Text=="" || textBoxbasesalary.Text=="" || textBoxDOB.Text == "" || textBoxHD.Text == "" || comboBoxgender.SelectedIndex== -1 || textBoxqulifications.Text=="" || comboBoxpositon.SelectedIndex== -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeDetails(Name,Address,DOB,Gender,TelNumber,Qualification,Position,HiredDate,BasicSalary)values(@eN,@eA,@eDOB,@eG,@eP,@eQ,@ePo,@eHD,@eBS)", Con);
                    cmd.Parameters.AddWithValue("@eN", textBoxname.Text);
                    cmd.Parameters.AddWithValue("@eA", textBoxaddress.Text);
                    cmd.Parameters.AddWithValue("@eDOB", textBoxDOB.Text);
                    cmd.Parameters.AddWithValue("@eP", textBoxphone.Text);
                    cmd.Parameters.AddWithValue("@eHD", textBoxHD.Text);
                    cmd.Parameters.AddWithValue("@eBS", textBoxbasesalary.Text);
                    cmd.Parameters.AddWithValue("@eG", comboBoxgender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@eQ", textBoxqulifications.Text);
                    cmd.Parameters.AddWithValue("@ePo", comboBoxpositon.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added!");
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

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Departments departments = new Departments();
            departments.ShowDialog();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Salary_Home salary_Home = new Salary_Home();
            salary_Home.ShowDialog();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Leave_Admin leave_Admin = new Leave_Admin();
            leave_Admin.ShowDialog();
        }

        private void label16_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            End end = new End();
            end.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select an employee");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from EmployeeDetails where Employee_ID=@eKey ", Con);
                    cmd.Parameters.AddWithValue("@eKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted!");
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
        int Key = 0;

        private void dataGridViewed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxname.Text = dataGridViewed.SelectedRows[0].Cells[1].Value.ToString();
            textBoxaddress.Text = dataGridViewed.SelectedRows[0].Cells[2].Value.ToString();
            textBoxDOB.Text = dataGridViewed.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxgender.SelectedItem = dataGridViewed.SelectedRows[0].Cells[4].ToString();
            textBoxphone.Text = dataGridViewed.SelectedRows[0].Cells[5].Value.ToString();
            textBoxqulifications.Text = dataGridViewed.SelectedRows[0].Cells[6].Value.ToString();
            comboBoxpositon.SelectedItem = dataGridViewed.SelectedRows[0].Cells[7].ToString();
            textBoxHD.Text = dataGridViewed.SelectedRows[0].Cells[8].Value.ToString();
            textBoxbasesalary.Text = dataGridViewed.SelectedRows[0].Cells[9].Value.ToString();
            if (textBoxname.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(dataGridViewed.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxname.Text == "" || textBoxaddress.Text == "" || textBoxphone.Text == "" || textBoxbasesalary.Text == "" || textBoxDOB.Text == "" || textBoxHD.Text == "" || comboBoxgender.SelectedIndex == -1 || textBoxqulifications.Text == "" || comboBoxpositon.SelectedIndex == -1)
            {
                MessageBox.Show("Select an employee");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update into EmployeeDetails set Name=@eN,Address=@eA,DOB=@eDOB,Gender=@eG,TelNumber=@eP,Qualification=@eQ,Position=@ePo,HiredDate=@eHD,BasicSalary=@eBS where Employee_ID=@eKey", Con);
                    cmd.Parameters.AddWithValue("@eN", textBoxname.Text);
                    cmd.Parameters.AddWithValue("@eA", textBoxaddress.Text);
                    cmd.Parameters.AddWithValue("@eDOB", textBoxDOB.Text);
                    cmd.Parameters.AddWithValue("@eP", textBoxphone.Text);
                    cmd.Parameters.AddWithValue("@eHD", textBoxHD.Text);
                    cmd.Parameters.AddWithValue("@eBS", textBoxbasesalary.Text);
                    cmd.Parameters.AddWithValue("@eG", comboBoxgender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@eQ", textBoxqulifications.Text);
                    cmd.Parameters.AddWithValue("@ePo", comboBoxpositon.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@eKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated!");
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
    }
}
