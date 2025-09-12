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
//using WFADBCRUDN;

namespace Diagnostic
{
    public partial class FormLogIn : Form
    {
        DataAccess da;
        
       
     

        public FormLogIn()
        {
            da = new DataAccess();

            InitializeComponent();
          //  ReceptionistDashboard rd = new ReceptionistDashboard(this.txtName.Text, this);
            this.txtName.Text = "";

          //  rd.Visible = true;


        }

        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from [Users] where UserId = '" + this.txtName.Text + "'";
                DataSet ds = this.da.ExecuteQuery(sql);


                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    string dbPassword = ds.Tables[0].Rows[0]["Password"].ToString();

                    if (dbPassword == this.txtPassword.Text)
                    {

                        MessageBox.Show("Log in Successful ");
                        this.txtPassword.Text = "";
                       
                        this.Visible= false;
                        if (ds.Tables[0].Rows[0]["Role"].ToString() == "Receptionist")
                        {
                            


                            ReceptionistDashboard rd = new ReceptionistDashboard(this.FindName(), this);
                            this.txtName.Text = "";

                            rd.Visible = true;
                        }
                        else if (ds.Tables[0].Rows[0]["Role"].ToString() == "Admin")
                            {

                            



                            AdminInterface rd = new AdminInterface(this.FindName(), this);
                                this.txtName.Text = "";

                                rd.Visible = true;
                            }
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password");
                    }
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private string FindName()
        {
            string sqlForName = "select Name from Users where UserId = '" + this.txtName.Text + "'";
            DataSet dsForname = this.da.ExecuteQuery(sqlForName);
            var name = dsForname.Tables[0].Rows[0][0].ToString();
            return name;
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_MouseHover(object sender, EventArgs e)
        {
            this.btnLogIn.BackColor = Color.Blue;
        }

        private void btnLogIn_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogIn.BackColor = Color.White;
        }
    }
}

