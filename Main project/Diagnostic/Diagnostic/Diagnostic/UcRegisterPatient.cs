using CuoreUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            //string name =this.txtboxname.Text;
            //if (name == "")
            //{
            //    MessageBox.Show("Fill the Name");
            //    return;
            //}
            //else
            //{
            //    var sql ="select patientid from patient where Patientname= '"+name+"'";
            //    var ds =this.Da.ExecuteQuery(sql);  
            //    if(ds.Tables[0].Rows.Count > 0)
            //    {
            //        MessageBox.Show("User Already exist ");
            //        return;
            //    }
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
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



                // gets the selected date
                //string dobString = dob.ToString("yyyy-MM-dd");
                string query = "INSERT INTO Patient (PatientId, PatientName, Phone, Email, Address, Gender, DateOfBirth) VALUES ('" + patientId + "', '" + this.txtboxname.Text + "', '" + this.txtPhone.Text + "', '" + this.txtEmail.Text + "', '" + this.txtAddress.Text + "', '" + gender + "','" + dob + "')";

                var ds = this.Da.ExecuteDMLQuery(query);    
                if(ds==1)
                {
                    MessageBox.Show("Successfully Register");
                 
                }
                else
                {
                    MessageBox.Show("Register not Successful");

                }
                this.PopulateGridView(); 




            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private string AutoIdGenerate()
        {
            var query = "SELECT MAX(PatientId) FROM Patient";
            var dt = this.Da.ExecuteQueryTable(query);

            string oldId = dt.Rows[0][0].ToString();
            int pid = 1;

            if (!string.IsNullOrEmpty(oldId))
            {
                pid = Convert.ToInt32(oldId) + 1;
            }

            MessageBox.Show("OldId: " + oldId);
            MessageBox.Show("NewId: " + pid);

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

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.txtboxname.Text = this.dvgpatient.CurrentRow.Cells[1].ToString();
            this.txtPhone.Text=this.dvgpatient.CurrentRow.Cells["Phone"].ToString();
        }
    }
}
