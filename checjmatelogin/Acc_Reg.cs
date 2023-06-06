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
    public partial class Acc_Reg : Form
    {
        public Acc_Reg()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=laptop-6jt31sc8;Initial Catalog=Checkmate2;Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            textBoxeid.Text = "";
            textBoxusername.Text = "";
            textBoxpassword.Text = "";
            textBoxconfirm.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [EmployeeDetails] WHERE ([Employee_ID] = @eID)", Con);
            check_User_Name.Parameters.AddWithValue("@eID", textBoxeid.Text);
            int UserExist = (int)check_User_Name.ExecuteScalar();
            Con.Close();

            Con.Open();
            SqlCommand check_User_Name2 = new SqlCommand("SELECT COUNT(*) FROM [Register] WHERE ([Employee_ID] = @eID)", Con);
            check_User_Name2.Parameters.AddWithValue("@eID", textBoxeid.Text);
            int UserExist2 = (int)check_User_Name2.ExecuteScalar();
            Con.Close();

            Con.Open();
            SqlCommand check_User_Name3 = new SqlCommand("SELECT COUNT(*) FROM [Register] WHERE ([Username] = @eUN)", Con);
            check_User_Name3.Parameters.AddWithValue("@eUN", textBoxusername.Text);
            int UserExist3 = (int)check_User_Name3.ExecuteScalar();
            Con.Close();

            if (textBoxeid.Text == "" || textBoxusername.Text == "" || textBoxpassword.Text == "" || textBoxconfirm.Text == "")
            {
                MessageBox.Show("Missing Information", "CheckMate");
            }
            else if (textBoxpassword.Text!=textBoxconfirm.Text)
            {
                MessageBox.Show("Enter the same password!","CheckMate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (UserExist <= 0)
            {
                MessageBox.Show("Employee does not exist!", "CheckMate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (UserExist2 > 0)
            {
                MessageBox.Show("Already have a Login!", "CheckMate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (UserExist3 > 0)
            {
                MessageBox.Show("Username already exist!", "CheckMate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Register(Employee_ID,Username,Password,Confirm_Password)values(@eID,@eUN,@ePD,@eCPD)", Con);
                    cmd.Parameters.AddWithValue("@eID", textBoxeid.Text);
                    cmd.Parameters.AddWithValue("@eUN", textBoxusername.Text);
                    cmd.Parameters.AddWithValue("@ePD", textBoxpassword.Text);
                    cmd.Parameters.AddWithValue("@eCPD", textBoxconfirm.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Login Registered!", "CheckMate");
                    Con.Close();
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
