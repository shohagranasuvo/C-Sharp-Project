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
    public partial class UcBilling : UserControl
    {
        DataAccess Da { get; set; }
        public UcBilling()
        {
            InitializeComponent();
            Da = new DataAccess();
            string query1 = "select * from Accessories;";
            this.PopulateGridView1(query1);
            string query2 = "select * from Test";
            this.PopulateGridView2(query2);
        }
        private void PopulateGridView1(string sql = "select * from Accessories;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.DgvAccessoriesDetails.AutoGenerateColumns = true;
            this.DgvAccessoriesDetails.DataSource = ds.Tables[0];
        }
        private void PopulateGridView2(string sql = "select * from Test")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvTestItems.AutoGenerateColumns = true;
            this.dgvTestItems.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {




        }

        private void button2_Click(object sender, EventArgs e)
        {



            if (this.DgvAccessoriesDetails.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.DgvAccessoriesDetails.SelectedRows[0];
                string accessoriesId = row.Cells["AccessoriesId"].Value.ToString();
                string accessoryName = row.Cells["AccessoriesName"].Value.ToString();
                int totalQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                string quantityText = this.txttemsCount1.contentTextField.Text;
                if (!string.IsNullOrWhiteSpace(quantityText))
                {
                    int enteredQuantity = Convert.ToInt32(quantityText);

                    if (enteredQuantity <= totalQuantity)
                    {

                        bool itemExists = false;
                        foreach (ListViewItem lvItem in lvSelectedItem.Items)
                        {
                            if (lvItem.SubItems[1].Text == accessoryName)
                            {

                                int oldQuantity = Convert.ToInt32(lvItem.SubItems[2].Text);
                                int newQuantity = oldQuantity + enteredQuantity;

                                if (newQuantity <= totalQuantity)
                                {
                                    lvItem.SubItems[2].Text = newQuantity.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Total quantity exceeds available stock!");
                                }

                                itemExists = true;
                                break;
                            }
                        }


                        if (!itemExists)
                        {
                            ListViewItem item = new ListViewItem(accessoriesId);
                            item.SubItems.Add(accessoryName);
                            item.SubItems.Add(enteredQuantity.ToString());
                            item.SubItems.Add(price.ToString());

                            lvSelectedItem.Items.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Entered quantity exceeds available stock!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a quantity.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row first!");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.dgvTestItems.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvTestItems.SelectedRows[0];

                string testId = row.Cells[0].Value.ToString();
                string testName = row.Cells[1].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells[3].Value);

                // Get entered quantity from TextBox
                string quantityText = this.txttemsCount2.contentTextField.Text;
                if (string.IsNullOrWhiteSpace(quantityText))
                {
                    MessageBox.Show("Please enter a quantity.");
                    return;
                }

                int enteredQuantity = Convert.ToInt32(quantityText);

                bool itemExists = false;

                foreach (ListViewItem lvItem in lvSelectedItem.Items)
                {
                    if (lvItem.SubItems[1].Text == testName)
                    {
                        
                        int oldQuantity = 0;
                        if (!string.IsNullOrEmpty(lvItem.SubItems[2].Text))
                        {
                            oldQuantity = Convert.ToInt32(lvItem.SubItems[2].Text);
                        }

                        int newQuantity = oldQuantity + enteredQuantity;
                        lvItem.SubItems[2].Text = newQuantity.ToString();

                        itemExists = true;
                        break;
                    }
                }

              
                if (!itemExists)
                {
                    ListViewItem item = new ListViewItem(testId);       
                    item.SubItems.Add(testName);                          
                    item.SubItems.Add(enteredQuantity.ToString());       
                    item.SubItems.Add(price.ToString("0.00"));          

                    lvSelectedItem.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Please select a row first!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (lvSelectedItem.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvSelectedItem.SelectedItems[0];

            
                string removeText = txtRemove.contentTextField.Text;
                if (string.IsNullOrWhiteSpace(removeText))
                {
                    MessageBox.Show("Please enter quantity to remove.");
                    return;
                }

                int removeQty = Convert.ToInt32(removeText);

               
                int currentQty = 0;
                if (!string.IsNullOrEmpty(selectedItem.SubItems[2].Text))
                {
                    currentQty = Convert.ToInt32(selectedItem.SubItems[2].Text);
                }

               
                int newQty = currentQty - removeQty;

                if (newQty > 0)
                {
                    selectedItem.SubItems[2].Text = newQty.ToString();
                }
                else
                {
                   
                    lvSelectedItem.Items.Remove(selectedItem);
                }
            }
            else
            {
                MessageBox.Show("Please select an item in the ListView first!");
            }
        

    }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string patientId = txtId.Text.Trim();
                string patientName = txtName.Text.Trim();
                string patientPhone = txtPhone.Text.Trim();

                if (string.IsNullOrEmpty(patientId) &&
                    (string.IsNullOrEmpty(patientName) || string.IsNullOrEmpty(patientPhone)))
                {
                    MessageBox.Show("Please fill either Patient ID OR both Name and Phone!");
                    return;
                }


                if (!string.IsNullOrEmpty(patientId))
                {
                    string query = "SELECT COUNT(*) FROM Patient WHERE PatientId = '" + patientId + "'";
                    var da = this.Da.ExecuteQuery(query);

                    int count = 0;

                    if (da.Tables.Count > 0 && da.Tables[0].Rows.Count > 0)
                    {
                        count = Convert.ToInt32(da.Tables[0].Rows[0][0]);
                    }

                    if (count > 0)
                    {

                        MessageBox.Show("Patient exists! You can continue.");
                        this.pnlTestItems.Controls.Clear();
                        //string id = da.Tables[0].Rows[0][0].ToString() ;
                        UcBillConfirm billConfirm = new UcBillConfirm(this.lvSelectedItem , patientId);
                        this.pnlTestItems.Controls.Add(billConfirm);
                    }
                    else
                    {

                       

                        MessageBox.Show("Patient ID does not exist. Please enter Name and Phone to add a new patient.");

                    }
                }
                else
                {
                    
                    if (!string.IsNullOrEmpty(patientName) && !string.IsNullOrEmpty(patientPhone))
                    {
                        //UcRegisterPatient ucRegisterPatient = new UcRegisterPatient();
                        string id =this.AutoIdGenerate();
                        string insertQuery = $"INSERT INTO Patient (patientid ,patientName, Phone) VALUES ('"+id+"','"+patientName+"', '"+patientPhone+"')";
                        this.Da.ExecuteDMLQuery(insertQuery);
                        MessageBox.Show("New patient added successfully!");
                        this.pnlTestItems.Controls.Clear();
                        UcBillConfirm billConfirm = new UcBillConfirm(this.lvSelectedItem ,id);
                        this.pnlTestItems.Controls.Add(billConfirm);


                    }
                    else
                    {
                        MessageBox.Show("Please fill Patient ID OR both Name and Phone.");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex);
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
                Random rnd = new Random();
              

                pid = Convert.ToInt32(oldId)  + rnd.Next(1, 1000000);
            }

            //MessageBox.Show("OldId: " + oldId);
            //MessageBox.Show("NewId: " + pid);

            return pid.ToString();
        }
    }
    }
