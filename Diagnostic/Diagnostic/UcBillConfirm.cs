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
    public partial class UcBillConfirm : UserControl
    { 
        private double TotalBill {  get; set; }  
        private string PatientId {  get; set; }     
        private ListView Lv { get; set; }
        private DataAccess Da { get; set; }
        public UcBillConfirm()
        {
            this.Da = new DataAccess();
            InitializeComponent();
            
        }

        public UcBillConfirm(ListView lv, string id = "2") 
        {
            this.Da = new DataAccess();
            InitializeComponent();
            this.PatientId = id;    

            copyList(lv);
            this.TotalBill = setSum();
            this.lbltotaltaka.Text = TotalBill.ToString();
            DataBaseUpdate();


        }
        public void copyList(ListView lv)
        {
           this.Lv = lv;

            lvSelectedItemView.Items.Clear();

            foreach (ListViewItem item in Lv.Items)
            {
                //lvSelectedItemView.Items.Add((ListViewItem)item.Clone());
                ListViewItem newItem = (ListViewItem)item.Clone();
                string quantityText = newItem.SubItems[2].Text;
                string priceText = newItem.SubItems[3].Text;

                if(int.TryParse(quantityText, out int quantity) && double.TryParse(priceText, out double price))
                {
                    double itemTotal = quantity * price;
                    newItem.SubItems.Add(itemTotal.ToString("0.00"));

                }
                else
                {
                    newItem.SubItems.Add("0.00");
                }

                lvSelectedItemView.Items.Add(newItem);
            }

        }


        public Double setSum() {
            Double totalPrice = 0;

            foreach (ListViewItem item in lvSelectedItemView.Items)
            {
                
                string priceText = item.SubItems[4].Text;

                if (Double.TryParse(priceText, out Double price))
                {
                    totalPrice += price;
                }
            }
            return totalPrice;

        }

        private int AutoIdGenerate()
        {
            try
            {
                string query = "SELECT MAX(BillId) FROM Bill";
                var dt = this.Da.ExecuteQueryTable(query);

                string oldId = dt.Rows[0][0]?.ToString(); 
                if (string.IsNullOrEmpty(oldId))
                    return 1; 

                int maxId = 0;
                if (!int.TryParse(oldId, out maxId))
                    maxId = 0;
                Random rnd = new Random();
                return maxId + rnd.Next(1, 100000);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating ID: " + ex.Message);
                return -1;
            }
        }


        public void DataBaseUpdate()
        {
         
            try
            {

                string nextBillId = this.AutoIdGenerate().ToString();

              
                string patientId = PatientId;
                string totalAmount = setSum().ToString();
                string billDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                string query = $"INSERT INTO Bill (BillId, PatientId, BillDate, TotalAmount) " +
                               $"VALUES ({nextBillId}, '{patientId}', '{billDate}', '{totalAmount}')";

                int result = Da.ExecuteDMLQuery(query);

                if (result > 0)
                {
                    MessageBox.Show($"Bill saved successfully BillId: {nextBillId}");
                }
                else
                {
                    MessageBox.Show("Failed to save bill");
                }

                
                foreach (ListViewItem item in lvSelectedItemView.Items)
                {
                    string itemName = item.SubItems[1].Text;
                    int purchasedQty = int.Parse(item.SubItems[2].Text); 

                   
                    string checkAccessories = $"SELECT Quantity FROM Accessories WHERE AccessoriesName = '{itemName}'";
                    DataTable accessoriesDt = Da.ExecuteQueryTable(checkAccessories);

                    if (accessoriesDt.Rows.Count > 0)
                    {
                        int oldQty = Convert.ToInt32(accessoriesDt.Rows[0]["Quantity"]);
                        int newQty = oldQty - purchasedQty;

                        if (newQty < 0) newQty = 0; 

                        string updateAccessories = $"UPDATE Accessories SET Quantity = {newQty} WHERE AccessoriesName = '{itemName}'";
                        Da.ExecuteDMLQuery(updateAccessories);
                    }
                    else
                    {
                        
                        //string checkTest = $"SELECT Quantity FROM Test WHERE TestName = '{itemName}'";
                        //DataTable testDt = da.ExecuteQueryTable(checkTest);

                        //if (testDt.Rows.Count > 0)
                        //{
                        //    int oldQty = Convert.ToInt32(testDt.Rows[0]["Quantity"]);
                        //    int newQty = oldQty - purchasedQty;

                        //    if (newQty < 0) newQty = 0;

                        //    string updateTest = $"UPDATE Test SET Quantity = {newQty} WHERE TestName = '{itemName}'";
                        //    da.ExecuteDMLQuery(updateTest);
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error: " + ex.Message);
            }
        

        }

        private void lvSelectedItemView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbltotaltaka_Click(object sender, EventArgs e)
        {

        }
    }



}







