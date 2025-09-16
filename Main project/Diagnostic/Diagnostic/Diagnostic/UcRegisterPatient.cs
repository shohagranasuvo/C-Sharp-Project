using CuoreUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Diagnostic
{
    public partial class UcRegisterPatient : UserControl
    {
        private DataAccess Da { set; get; }
        public UcRegisterPatient()
        {
            InitializeComponent();
            Da = new DataAccess();
            var sql = "select * from patient";
            PopulateGridView(sql);
        }

        private void pnlRegisterPatientForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuiLabel2_Load(object sender, EventArgs e)
        {

        }
        private void PopulateGridView(string sql = "select * from patient")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dvgpatient.AutoGenerateColumns = false;

            this.dvgpatient.DataSource = ds.Tables[0];
        }

        private void btnAddpatient_Click(object sender, EventArgs e)
        {
            try
            {
                //this.clearAll();
                dvgpatient.ClearSelection();
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var patientId = this.AutoIdGenerate();

                if (patientId == null)
                {
                    patientId = "1";
                }
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

               string query = "INSERT INTO Patient (PatientId, PatientName, Phone, Email, Address, Gender, DateOfBirth) VALUES ('" + patientId + "', '" + this.txtboxname.Text + "', '" + this.txtPhone.Text + "', '" + this.txtEmail.Text + "', '" + this.txtAddress.Text + "', '" + gender + "','" + dob + "')";

                var dss = this.Da.ExecuteDMLQuery(query);
                if (dss == 1)
                {
                    MessageBox.Show("Successfully ");

                }
                else
                {
                    MessageBox.Show(" Unsuccessful");

                }
                this.PopulateGridView();
            




            }
            catch (Exception ex){
                MessageBox.Show("Eerror :" + ex);
            }
           



        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPatent();
        }

        private void AddPatent ()
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }
                
                string idd = this.dvgpatient.CurrentRow.Cells[0].Value.ToString();
                string query = "select  * from patient where Patientid ='" + idd + "'";
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

                    string updatequery = "UPDATE Patient SET PatientName = '" + this.txtboxname.Text + "',phone = '" + this.txtPhone.Text + "', email ='" + this.txtEmail.Text + "', address ='" + this.txtAddress.Text + "', gender ='" + gender + "',DateOfBirth ='" + dob + "' where Patientid ='" + idd + "' ";
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

                    var patientId = this.AutoIdGenerate();

                    if (patientId == null)
                    {
                        patientId = "1";
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
                    dob = this.dtpDateOfBirth.Text;
                    MessageBox.Show(dob);



                    
                    query = "INSERT INTO Patient (PatientId, PatientName, Phone, Email, Address, Gender, DateOfBirth) VALUES ('" + patientId + "', '" + this.txtboxname.Text + "', '" + this.txtPhone.Text + "', '" + this.txtEmail.Text + "', '" + this.txtAddress.Text + "', '" + gender + "','" + dob + "')";

                    var dss = this.Da.ExecuteDMLQuery(query);
                    if (dss == 1)
                    {
                        MessageBox.Show("Successfully ");

                    }
                    else
                    {
                        MessageBox.Show(" Unsuccessful");

                    }
                    this.PopulateGridView();
                }




            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        public string AutoIdGenerate()
        {
            var query = "SELECT MAX(PatientId) FROM Patient";
            var dt = this.Da.ExecuteQueryTable(query);

            string oldId = dt.Rows[0][0].ToString();
            int pid = 1;

            if (!string.IsNullOrEmpty(oldId))
            {
                pid = Convert.ToInt32(oldId) + 1;
            }

            //MessageBox.Show("OldId: " + oldId);
            //MessageBox.Show("NewId: " + pid);

            return pid.ToString();
        }

        private bool IsValidToSave()
        {
            // Check if required text fields are empty
            if (string.IsNullOrEmpty(this.txtboxname.Text) ||
                string.IsNullOrEmpty(this.txtPhone.Text) ||
                string.IsNullOrEmpty(this.txtEmail.Text))
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

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            clearAll();
            dvgpatient.ClearSelection();

            var sql = "select * from patient";
            PopulateGridView(sql);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dvgpatient.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                

                var name = this.dvgpatient.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + name + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                {
                    return;
                }
                else
                {
                    var id = this.dvgpatient.CurrentRow.Cells[0].Value.ToString();
                    string query = "DELETE FROM Patient WHERE PatientId = '" + id + "'";

                   var check =  Da.ExecuteDMLQuery(query);
                    if (check == 1)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                this.txtboxname.Text = this.dvgpatient.CurrentRow.Cells[1].Value.ToString();
                this.txtPhone.Text = this.dvgpatient.CurrentRow.Cells[2].Value.ToString();
                this.txtEmail.Text = this.dvgpatient.CurrentRow.Cells[3].Value.ToString();
                this.txtAddress.Text = this.dvgpatient.CurrentRow.Cells[5].Value.ToString();
                this.dtpDateOfBirth.Text = this.dvgpatient.CurrentRow.Cells[6].Value.ToString();

                this.btnRegisterAndSave.Text = "Save";
                if (this.dvgpatient.CurrentRow.Cells[4].Value.ToString() == "Male")
                {
                    this.rbtnMale.Checked = true;

                }
                else if (this.dvgpatient.CurrentRow.Cells[4].Value.ToString() == "Female")
                {
                    this.rbtnFemale.Checked = true;

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("An error Occure : " + ex);
            }


        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            try
            {
               

                string value = this.txtSearch.contentTextField.Text;
           




            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Please enter a search value.");
                return;
            }

           


               string query = "SELECT * FROM patient WHERE PatientName = '" + value+"'";
            

           
                var ds = this.Da.ExecuteQuery(query);
                this.dvgpatient.AutoGenerateColumns = true;
                this.dvgpatient.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching: " + ex.Message);
            }
        }

        private void dvgpatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editButton(e);
        }

        private void editButton(DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dvgpatient.Rows[e.RowIndex];

                    this.txtboxname.Text = row.Cells[1].Value.ToString();
                    this.txtPhone.Text = row.Cells[2].Value.ToString();
                    this.txtEmail.Text = row.Cells[3].Value.ToString();
                    this.txtAddress.Text = row.Cells[5].Value.ToString();
                    this.dtpDateOfBirth.Text = row.Cells[6].Value.ToString();

                    if (row.Cells[4].Value.ToString() == "Male")
                    {
                        this.rbtnMale.Checked = true;
                    }
                    else if (row.Cells[4].Value.ToString() == "Female")
                    {
                        this.rbtnFemale.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row: " + ex.Message);
            }
        }
        public void clearAll()
        {
            this.txtboxname.Text = "";
            this.txtAddress.Text = "";
            this.txtPhone.Text = "";
            this.txtEmail.Text = "";
           
        }
    }
}
