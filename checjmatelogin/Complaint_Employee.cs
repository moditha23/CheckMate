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
    public partial class Complaint_Employee : Form
    {
        public Complaint_Employee()
        {
            InitializeComponent();
            DisplayRemarks();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-6JT31SC8;Initial Catalog=Checkmate2;Integrated Security=True");

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DisplayRemarks()
        {
            Con.Open();
            string Query = "Select * from Remarks ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridViewremark.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary_Home salary_Home = new Salary_Home();
            salary_Home.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leave leave = new Leave();
            leave.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            login2 lg = new login2();
            lg.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            End end = new End();
            end.ShowDialog();

        }

        private void Reset()
        {
            textBoxdate.Text = "";
            richTextBoxcomplain.Text = "";
            comboBoxdepart.SelectedIndex = -1;

        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            if (textBoxdate.Text == "" || richTextBoxcomplain.Text == "" || comboBoxdepart.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Complain(Date,Department,Description)values(@cD,@cDp,@cDS)", Con);
                    cmd.Parameters.AddWithValue("@cD", textBoxdate.Text);
                    cmd.Parameters.AddWithValue("@cDS", richTextBoxcomplain.Text);
                    cmd.Parameters.AddWithValue("@cDp", comboBoxdepart.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Complain Added!");
                    Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Complaint_Employee_Load(object sender, EventArgs e)
        {

        }
    }
}
