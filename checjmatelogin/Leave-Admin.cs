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
    public partial class Leave_Admin : Form
    {
        public Leave_Admin()
        {
            InitializeComponent();
            DisplayAccount();
        }

        SqlConnection Con = new SqlConnection("Data Source=laptop-6jt31sc8;Initial Catalog=Checkmate2;Integrated Security=True");
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees employees = new Employees();
            employees.ShowDialog();
        }

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

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            End end = new End();
            end.ShowDialog();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Salary_Home sh= new Salary_Home();  
            sh.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxid.Text == "" && textBoxfrom.Text == "" && textBoxto.Text == "" &&textBoxreason.Text == "")
            {
                MessageBox.Show("Select an employee", "CheckMate");
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Missing Information", "CheckMate");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update Leave set Decision=@ed where Leave_Id=@eKey", Con);
                    cmd.Parameters.AddWithValue("@ed", comboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@eKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Decision Submitted!", "CheckMate");
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

        private void DisplayAccount()
        {
            Con.Open();
            string Query = "Select * from Leave ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridViewleave.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Reset()
        {
            textBoxfrom.Text = "";
            textBoxto.Text = "";
            textBoxreason.Text = "";
            comboBox1.SelectedIndex= 0;
        }

        int Key = 0;
        private void dataGridViewed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxid.Text = dataGridViewleave.SelectedRows[0].Cells[1].Value.ToString();
            textBoxfrom.Text = dataGridViewleave.SelectedRows[0].Cells[2].Value.ToString();
            textBoxto.Text = dataGridViewleave.SelectedRows[0].Cells[3].Value.ToString();
            textBoxreason.Text = dataGridViewleave.SelectedRows[0].Cells[4].Value.ToString();
            //comboBox1.Text = dataGridViewleave.SelectedRows[0].Cells[5].Value.ToString();
            if (textBoxid.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(dataGridViewleave.SelectedRows[0].Cells[0].Value.ToString());
            }
        }


    }
}
