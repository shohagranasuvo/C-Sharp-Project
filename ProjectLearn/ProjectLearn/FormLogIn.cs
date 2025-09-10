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
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            new FrmSignUp().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string name = textBox1.Text;
            string password = textBox2.Text;

            string connectionString = "Data Source=SHOHAGRANASUVO\\SQLEXPRESS;Initial Catalog=LogIn;Integrated Security=True";
            string query = "INSERT INTO dbo.LogIn ([NAME], [Password]) VALUES (@name, @password)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    conn.Open();
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
        
    



