using Krypton.Toolkit;
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
    public partial class UcReceptionistOperationCRUDE : UserControl
    { DataAccess Da {  get; set; }

        public UcReceptionistOperationCRUDE()
        {
            InitializeComponent();
            string query = "select * from receptionist";
            Da = new DataAccess();
            this.PopulateGridView(query);
            
        }

        private void PopulateGridView(string query = "select * from Receptionist")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(query);

                this.dvgReceptionistTable.AutoGenerateColumns = false;

                this.dvgReceptionistTable.DataSource = ds.Tables[0];



            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex);

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dvgReceptionistTable.CurrentRow.Cells[0].Value.ToString();
                string query = "select * from receptionist where ReceptionistId ='" + id + "'";
               var ds = Da.ExecuteQuery(query);
                this.txtboxname.Text = this.dvgReceptionistTable.CurrentRow.Cells[1].Value.ToString();
                this.txtPhone.Text = this.dvgReceptionistTable.CurrentRow.Cells[4].Value.ToString();
                this.txtEmail.Text = ds.Tables[0].Rows[0][3].ToString();
                this.txtAddress.Text = this.dvgReceptionistTable.CurrentRow.Cells[5].Value.ToString();
                this.dtpDateOfBirth.Text = ds.Tables[0].Rows[0][6].ToString();
                this.txtSalary.Text = this.dvgReceptionistTable.CurrentRow.Cells[3].Value.ToString();
                string gender = ds.Tables[0].Rows[0][2].ToString();
                this.txtPassword.Text = ds.Tables[0].Rows[0][4].ToString();


               
                if (gender == "Male")
                {
                    this.rbtnMale.Checked = true;

                }
                else if (gender == "Female")
                {
                    this.rbtnFemale.Checked = true;

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("An error Occure : " + ex);
            }

        }

        private void btnRegisterAndSave_Click(object sender, EventArgs e)
        {
              this.AddReceptionist(); 
        }
        private bool IsValidToSave()
        {
            // Check if required text fields are empty
            if (string.IsNullOrEmpty(this.txtboxname.Text) ||
                string.IsNullOrEmpty(this.txtPhone.Text) ||
                string.IsNullOrEmpty(this.txtEmail.Text)|| string.IsNullOrEmpty(this.txtAddress.Text)|| string.IsNullOrEmpty(this.txtSalary.Text))
            {
                return false;
            }

            // Check if at least one gender is selected
            if (!this.rbtnFemale.Checked && !this.rbtnMale.Checked)
            {
                return false;
            }

            return true;
        }
        private void AddReceptionist()
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }
                
                string idd = this.dvgReceptionistTable.CurrentRow.Cells[0].Value.ToString();
                string query = "select  * from patient where ReceptionistID ='" + idd + "'";
                var ds = this.Da.ExecuteQuery(query);
                string gender = "";
                
                if (this.rbtnMale.Checked)
                {
                    gender = "Male";
                }
                else if (this.rbtnFemale.Checked)
                {
                    gender = "Female";
                }
                string dob = this.dtpDateOfBirth.Text;
                MessageBox.Show(dob);

                if (ds.Tables[0].Rows.Count == 1)
                {

                    string updatequery = "UPDATE receptionist SET FullName = '" + this.txtboxname.Text + "',phone = '" + this.txtPhone.Text + "', email ='" + this.txtEmail.Text + "', address ='" + this.txtAddress.Text + "', gender ='" + gender + "',DOB ='" + dob + "' ,salary ='" + this.txtSalary.Text + "',pass ='" + this.txtPassword.Text + "' where receptionistid ='" + idd + "' ";
                    int check = this.Da.ExecuteDMLQuery(updatequery);
                    if (check == 1)
                    {
                        MessageBox.Show("Updated");

                    }
                    else
                    {
                        MessageBox.Show("Not Updated");
                    }
                    this.PopulateGridView();

                }
                else
                {
                    if (!this.IsValidToSave())
                    {
                        MessageBox.Show("Please fill all the empty fields");
                        return;
                    }

                  
                    var receptionistId = this.AutoIdGenerate();

                    if (string.IsNullOrEmpty(receptionistId))
                    {
                        receptionistId = "U001"; 
                    }

                   
                    gender = "";
                    if (this.rbtnMale.Checked)
                    {
                        gender = "Male";
                    }
                    else if (this.rbtnFemale.Checked)
                    {
                        gender = "Female";
                    }

                
                    string dateofbirth = this.dtpDateOfBirth.Text;
                    MessageBox.Show(dateofbirth);

                    
                    string joinDate = System.DateTime.Today.ToString("yyyy-MM-dd");
                    query="insert into Users values ('"+ receptionistId + "' ,'"+this.txtboxname.Text+"','"+this.txtPassword.Text+"' ,'Receptionist' )";
                    int check =Da.ExecuteDMLQuery(query);
                    if (check == 1) 
                        { MessageBox.Show("Succesful Insert into Users table"); }
                        else
                        {
                        MessageBox.Show("Not Succesful Insert into Users table");
                        return ;

                    }

                   
                    query = $@"INSERT INTO Receptionist (ReceptionistId, Fullname, Phone, Email, Address, Gender,Dob, JoinDate ,pass) VALUES  ('{receptionistId}', '{this.txtboxname.Text}', '{this.txtPhone.Text}', '{this.txtEmail.Text}', '{this.txtAddress.Text}', '{gender}', '{dateofbirth}', '{joinDate}' ,'{this.txtPassword.Text}')";

                    int dss = this.Da.ExecuteDMLQuery(query);

                    if (dss == 1)
                    {
                        MessageBox.Show("Successfully Inserted Receptionist");
                    }
                    else
                    {
                        MessageBox.Show("Insertion Unsuccessful");
                    }

                    this.PopulateGridView();




                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
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

        private void btnAddpatient_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dvgReceptionistTable.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }



                var name = this.dvgReceptionistTable.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + name + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                {
                    return;
                }
                else
                {
                    var id = this.dvgReceptionistTable.CurrentRow.Cells[0].Value.ToString();
                   string query = "DELETE FROM receptionist WHERE ReceptionistId = '" + id + "'";

                    var check1 = Da.ExecuteDMLQuery(query);
                     query = "DELETE FROM Users WHERE userId = '" + id + "'";

                    var check = Da.ExecuteDMLQuery(query);

                    

                    if (check == 1 && check1 ==1)
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

            finally
            {
                PopulateGridView();
            }

        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            PopulateGridView();
        }
        public void ClearAll()
        {
            this.txtAddress.Text = "";
            this.txtboxname.Text = "";
            this.txtEmail.Text = "";
            this.txtPassword.Text = "";
            this.txtPhone.Text = "";
            this.txtSalary.Text = "";
            this.txtSearch.contentTextField.Text = "";
        }
    }
}
