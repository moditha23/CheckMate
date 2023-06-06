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

namespace checjmatelogin
{
    public partial class Departments : Form
    {

        SqlConnection Con = new SqlConnection("Data Source=laptop-6jt31sc8;Initial Catalog=Checkmate2;Integrated Security=True");
        public Departments()
        {
            InitializeComponent();
            ShowData();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees employees = new Employees();
            employees.ShowDialog();
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

        private void label8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            End end = new End();
            end.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtDepDescription.Text == "" || txtDepName.Text =="")
            {
                MessageBox.Show("Missing Information", "Checkmate");
            }
            else
            {
                try
                {
                    string query = "INSERT into Department(Name, Description) VALUES('"+ txtDepName.Text +"', '"+ txtDepDescription.Text +"')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department Added", "Checkmate");
                    ShowData();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally 
                { 
                    Con.Close(); 
                }
            }
        }

        public void ShowData()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Department", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void Reset()
        {
            txtDepDescription.Text = "";
            txtDepName.Text = "";
        }
        int Key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDepName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtDepDescription.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            if (txtDepName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtDepName.Text == "" || txtDepDescription.Text == "")
            {
                MessageBox.Show("Select a Department", "CheckMate");
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Department set Name=@dN, Description=@dDes where Department_ID=@dKey", Con);
                    Con.Open();
                    cmd.Parameters.AddWithValue("@dN", txtDepName.Text);
                    cmd.Parameters.AddWithValue("@dDes", txtDepDescription.Text);
                    cmd.Parameters.AddWithValue("@dKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department Updated!", "CheckMate");
                    Reset();
                    ShowData();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Key < 0 || txtDepDescription.Text == "" && txtDepName.Text == "")
            {
                MessageBox.Show("Select a Department", "Checkmate");
            }
            else if(MessageBox.Show("Are you sure you want to delete this Department?", "CheckMate", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE from Department where Department_ID=@dKey", Con);
                    cmd.Parameters.AddWithValue("@dKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department Deleted!", "CheckMate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    ShowData();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        private void Departments_Load(object sender, EventArgs e)
        {

        }
    }
}
