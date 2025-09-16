using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagnostic
{
    public partial class UcAdminOperationCRUDE : UserControl
    {
       private DataAccess Da { get; set; }
        public UcAdminOperationCRUDE()
        {
            string query = "select * from admin";
            InitializeComponent();
            Da = new DataAccess();
            PopulateGridView(query);
             
        }

        private void PopulateGridView(string query = "select * from admin")
        {
           try
            {
                var ds = this.Da.ExecuteQuery(query);

                this.dvgAdminTable.AutoGenerateColumns = false;

                this.dvgAdminTable.DataSource = ds.Tables[0];



            }
            catch (Exception ex )
            {

                MessageBox.Show("Error : " + ex);

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.txtId.Text = this.dvgAdminTable.CurrentRow.Cells[0].Value.ToString();
            this.txtAdminName.Text = this.dvgAdminTable.CurrentRow.Cells[1].Value.ToString();
            this.TxtPass.Text = this.dvgAdminTable.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Users SET Name='" + this.txtAdminName.Text + "', Password='" + this.TxtPass.Text + "', Role='Admin' WHERE UserId='" + this.txtId.Text + "' ";
                var ds = this.Da.ExecuteDMLQuery(query);
                 query = "UPDATE admin SET Name='" + this.txtAdminName.Text + "', Pass='" + this.TxtPass.Text + "', Userid='" + this.txtId.Text + "' WHERE AdminId='" + this.txtId.Text + "' ";
                 ds = this.Da.ExecuteDMLQuery(query);

                if (ds == 1)
                {
                    MessageBox.Show("Updated");

                }
                else
                {
                    MessageBox.Show("Updated");
                }

                query = "select * from admin";
                PopulateGridView(query);
            }

            catch (Exception ex) {
                MessageBox.Show("Error : " + ex);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string newId = this.AutoIdGenerate();

                string query = "insert into users values ( '" + newId + "' , '" + this.txtNewname.Text + "','" + this.txtNewpass.Text + "' , 'Admin') ;";
                var ds = this.Da.ExecuteDMLQuery(query);

              query = "insert into admin values ( '" + newId + "' , '" + this.txtNewname.Text + "','" + this.txtNewpass.Text + "' , '"+newId+"') ;";
                 ds = this.Da.ExecuteDMLQuery(query);
                if (ds == 1)
                {
                    MessageBox.Show("Add");
                }
                else
                {
                    MessageBox.Show("Not Added");

                }
                this.PopulateGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }


        }
       


        private string AutoIdGenerate()
        {

            var query = "SELECT MAX(UserId) FROM Users";
            var dt = this.Da.ExecuteQueryTable(query);

            string oldId = dt.Rows[0][0].ToString();
            string newId = "U001";

            if (!string.IsNullOrEmpty(oldId))
            {

                int numPart = Convert.ToInt32(oldId.Substring(1));


                numPart++;


                newId = "U" + numPart.ToString("D3");
            }

            return newId;
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.dvgAdminTable.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }



                var name = this.dvgAdminTable.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + name + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                {
                    return;
                }
                else
                {
                    var id = this.dvgAdminTable.CurrentRow.Cells[0].Value.ToString();
                    string query = "DELETE FROM Admin WHERE AdminId = '" + id + "'";

                    var check1 = Da.ExecuteDMLQuery(query);
                    query = "DELETE FROM Users WHERE userId = '" + id + "'";

                    var check = Da.ExecuteDMLQuery(query);



                    if (check == 1 && check1 == 1)
                    {
                        MessageBox.Show("Successfully Delete");

                    }
                    else
                    {
                        MessageBox.Show("delete not Successful");


                    }
                    this.PopulateGridView();


                }

            }


            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
    }
}
