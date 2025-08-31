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

namespace ProjectLearn
{
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            new FormWelcome().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            string password = this.textBox2.Text;
            string email = this.textBox3.Text;

            string connectionString = "Data Source=SHOHAGRANASUVO\\SQLEXPRESS;Initial Catalog=LogIn;Integrated Security=True";
            string query = "INSERT INTO dbo.SignUpFormInformation([Name] ,[Password],[Email]) VALUES(@NAME,@PASSWORD,@EMAIL)";
             using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NAME", name);
                cmd.Parameters.AddWithValue("@PASSWORD", password);
                cmd.Parameters.AddWithValue("@EMAIL", email);
                try
                {
                    conn.Open();
                    MessageBox.Show($"Name: {name}\nPassword: {password}\nEmail: {email}");

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Data inserted successfully ✅");
                    else
                        MessageBox.Show("Insert failed ❌");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


            }
        }
    }
}
