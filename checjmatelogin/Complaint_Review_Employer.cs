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
using System.Windows.Forms.VisualStyles;

namespace checjmatelogin
{
    public partial class Complaint_Review_Employer : Form
    {
        public Complaint_Review_Employer()
        {
            InitializeComponent();
            DisplayComplain();
            
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-6JT31SC8;Initial Catalog=Checkmate2;Integrated Security=True");

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

        private void DisplayComplain()
        {
            Con.Open();
            string Query = "Select * from Complain ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridViewcomplain.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void dataGridViewcomplain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBoxremark.Text == "" || textBoxdate.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Remarks(Remark,Date)values(@rDs,@rD)", Con);
                    cmd.Parameters.AddWithValue("@rDs", richTextBoxremark.Text);
                    cmd.Parameters.AddWithValue("@rD", textBoxdate.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Remark Added!");
                    Con.Close();
                    textBoxdate.Text = "";
                    richTextBoxremark.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
