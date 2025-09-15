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

        }
    }
    }
