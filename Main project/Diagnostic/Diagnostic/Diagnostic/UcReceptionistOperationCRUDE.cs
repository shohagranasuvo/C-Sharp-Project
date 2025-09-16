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

        private bool isNew = false;   
        private string newReceptionistId = ""; 


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
                this.txtReceptionistId.Text= this.dvgReceptionistTable.CurrentRow.Cells[0].Value.ToString();





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
          
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                string gender = "";
                if (this.rbtnMale.Checked) gender = "Male";
                else if (this.rbtnFemale.Checked) gender = "Female";

                string dob = this.dtpDateOfBirth.Text;
                string joinDate = System.DateTime.Today.ToString("yyyy-MM-dd");

                
                string receptionistId = this.txtReceptionistId.Text.Trim();
                if (string.IsNullOrEmpty(receptionistId))
                {
                    MessageBox.Show("Receptionist ID is required");
                    return;
                }

                
                string checkQuery = "SELECT * FROM Users WHERE UserId = '" + receptionistId + "'";
                var dt = this.Da.ExecuteQueryTable(checkQuery);

                if (dt.Rows.Count == 1)
                {
                    
                    string updateUser = "UPDATE Users " +
                                        "SET Name = '" + this.txtboxname.Text + "', " +
                                        "Password = '" + this.txtPassword.Text + "', " +
                                        "Role = 'Receptionist' " +
                                        "WHERE UserId = '" + receptionistId + "'";

                    int userUpdate = this.Da.ExecuteDMLQuery(updateUser);

                    string updateReceptionist = "UPDATE Receptionist SET " +
                                                "FullName = '" + this.txtboxname.Text + "', " +
                                                "Phone = '" + this.txtPhone.Text + "', " +
                                                "Email = '" + this.txtEmail.Text + "', " +
                                                "Address = '" + this.txtAddress.Text + "', " +
                                                "Gender = '" + gender + "', " +
                                                "DOB = '" + dob + "', " +
                                                "Salary = '" + this.txtSalary.Text + "', " +
                                                "Pass = '" + this.txtPassword.Text + "' " +
                                                "WHERE ReceptionistId = '" + receptionistId + "'";

                    int recUpdate = this.Da.ExecuteDMLQuery(updateReceptionist);

                    if (userUpdate == 1 && recUpdate == 1)
                        MessageBox.Show("Data has been updated successfully");
                    else
                        MessageBox.Show("Update failed for one or more tables");
                }
                else
                { 
                   
                    string insertUser = "INSERT INTO Users VALUES ('" + receptionistId + "', '" + this.txtboxname.Text + "', '" + this.txtPassword.Text + "', 'Receptionist')";
                    int userInsert = this.Da.ExecuteDMLQuery(insertUser);

                    string insertReceptionist = "INSERT INTO Receptionist (ReceptionistId, FullName, Phone, Email, Address, Gender, DOB, JoinDate, Pass, Salary) " +
                                                "VALUES ('" + receptionistId + "', '" + this.txtboxname.Text + "', '" + this.txtPhone.Text + "', '" + this.txtEmail.Text + "', '" + this.txtAddress.Text + "', '" + gender + "', '" + dob + "', '" + joinDate + "', '" + this.txtPassword.Text + "', '" + this.txtSalary.Text + "')";

                    int recInsert = this.Da.ExecuteDMLQuery(insertReceptionist);

                    if (userInsert == 1 && recInsert == 1)
                        MessageBox.Show("Data has been inserted successfully");
                    else
                        MessageBox.Show("Insertion failed for one or more tables");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred: " + exc.Message);
            }
        }

        
        private bool IsValidToSave()
        {
            
            if (string.IsNullOrEmpty(this.txtboxname.Text) ||
                string.IsNullOrEmpty(this.txtPhone.Text) ||
                string.IsNullOrEmpty(this.txtEmail.Text)|| string.IsNullOrEmpty(this.txtAddress.Text)|| string.IsNullOrEmpty(this.txtSalary.Text))
            {
                return false;
            }

           
            if (!this.rbtnFemale.Checked && !this.rbtnMale.Checked)
            {
                return false;
            }

            return true;
        }
        //private void AddReceptionist()
        //{
        //    try
        //    {
        //        if (!this.IsValidToSave())
        //        {
        //            MessageBox.Show("Please fill all the empty fields");
        //            return;
        //        }

        //        string gender = "";
        //        if (this.rbtnMale.Checked) gender = "Male";
        //        else if (this.rbtnFemale.Checked) gender = "Female";

        //        string dob = this.dtpDateOfBirth.Text;
        //        string joinDate = System.DateTime.Today.ToString("yyyy-MM-dd");

        //        if (isNew) 
        //        {
        
        //            string receptionistId = newReceptionistId;
        //            if (string.IsNullOrEmpty(receptionistId))
        //            {
        //                receptionistId = "U001";


        //            }
        //            string query = "INSERT INTO Users VALUES ('" + receptionistId + "', '" + this.txtboxname.Text + "', '" + this.txtPassword.Text + "', 'Receptionist')";
        //            int check = this.Da.ExecuteDMLQuery(query);



        //            if (check == 1)
        //                MessageBox.Show("Inserted into Users table");
        //            else
        //            {
        //                MessageBox.Show("Failed to insert into Users table");
        //                return;
        //            }

                    
        //            query = "INSERT INTO Receptionist (ReceptionistId, FullName, Phone, Email, Address, Gender, DOB, JoinDate, Pass, Salary) " +
        //                    "VALUES ('" + receptionistId + "', '" + this.txtboxname.Text + "', '" + this.txtPhone.Text + "', '" + this.txtEmail.Text + "', '" + this.txtAddress.Text + "', '" + gender + "', '" + dob + "', '" + joinDate + "', '" + this.txtPassword.Text + "', '" + this.txtSalary.Text + "')";
        //            int dss = this.Da.ExecuteDMLQuery(query);

        //            if (dss == 1)
        //                MessageBox.Show("Successfully Inserted Receptionist");
        //            else
        //                MessageBox.Show("Insertion into Receptionist table failed");

        //            this.PopulateGridView();
        //            isNew = false; 
        //        }
        //        else 
        //        {
        //            string idd = this.dvgReceptionistTable.CurrentRow.Cells[0].Value.ToString();


        //            string updatequery =
        //                "UPDATE Receptionist SET " +
        //                "FullName = '" + this.txtboxname.Text + "', " +
        //                "Phone = '" + this.txtPhone.Text + "', " +
        //                "Email = '" + this.txtEmail.Text + "', " +
        //                "Address = '" + this.txtAddress.Text + "', " +
        //                "Gender = '" + gender + "', " +
        //                "DOB = '" + dob + "', " +
        //                "Salary = '" + this.txtSalary.Text + "', " +
        //                "Pass = '" + this.txtPassword.Text + "' " +
        //                "WHERE ReceptionistId = '" + idd + "'";

        //            int check = this.Da.ExecuteDMLQuery(updatequery);
        //            if (check == 1) MessageBox.Show("Updated successfully");
        //            else MessageBox.Show("Update failed");

        //            this.PopulateGridView();
        //        }
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show("An error has occured: " + exc.Message);
        //    }
        //}

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
          
            try
            {
                this.ClearAll();   
                this.dvgReceptionistTable.ClearSelection();

                
                newReceptionistId = this.AutoIdGenerate();
                isNew = true;
                this.txtReceptionistId.Text= newReceptionistId;
                //this.txtReceptionistId.Visible = false;
                MessageBox.Show("New Receptionist ID generated: " + newReceptionistId, "Info");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Add button: " + ex.Message);
            }
        

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

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string value = this.txtSearch.contentTextField.Text;

                if (string.IsNullOrEmpty(value))
                {
                    MessageBox.Show("Please enter a receptionist name.");
                    return;
                }

                
                string query = "SELECT * FROM Receptionist WHERE FullName LIKE '" + value + "%'";

                var ds = this.Da.ExecuteQuery(query);
                this.dvgReceptionistTable.AutoGenerateColumns = true;
                this.dvgReceptionistTable.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching receptionist: " + ex.Message);
            }
        }
    }
}
