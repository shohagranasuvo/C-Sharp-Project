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
    { private double Total {  get; set; }  
        private string PatientId {  get; set; }     
        private ListView Lv { get; set; }
        private DataAccess Da { get; set; }
        public UcBillConfirm()
        {
            InitializeComponent();
            Da =new DataAccess();
        }

        public UcBillConfirm(ListView lv, string id = "2") 
        {
            InitializeComponent();
            this.PatientId = id;    

            copyList(lv);
            this.Total = setSum();
            this.lbltotaltaka.Text = Total.ToString();
            DataBaseUpdate();


        }
        public void copyList(ListView lv)
        {
           this.Lv = lv;

            lvSelectedItemView.Items.Clear();

            foreach (ListViewItem item in Lv.Items)
            {
                lvSelectedItemView.Items.Add((ListViewItem)item.Clone());
            }

        }


        public Double setSum() {
            Double totalPrice = 0;

            foreach (ListViewItem item in lvSelectedItemView.Items)
            {
                
                string priceText = item.SubItems[3].Text;

                if (Double.TryParse(priceText, out Double price))
                {
                    totalPrice += price;
                }
            }
            return totalPrice;

        }

      

           public void DataBaseUpdate()
        {
            try
            {
                DataAccess da = new DataAccess();

                
                string getIdQuery = "SELECT ISNULL(MAX(BillId), 0) + 1 FROM Bill";
                DataTable dt = da.ExecuteQueryTable(getIdQuery);
                int nextBillId = Convert.ToInt32(dt.Rows[0][0]); 

                
                string patientId = PatientId; 
                string totalAmount = setSum().ToString(); 
                string billDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); 

                
                string query = $"INSERT INTO Bill (BillId, PatientId, BillDate, TotalAmount) " +
                               $"VALUES ({nextBillId}, '{patientId}', '{billDate}', '{totalAmount}')";

                int result = da.ExecuteDMLQuery(query);

                if (result > 0)
                { MessageBox.Show($"Bill saved successfully BillId: {nextBillId}"); }
                else
                { MessageBox.Show("Failed to save bill"); }

                foreach (ListViewItem item in lvSelectedItemView.Items)
                {

                    string itemName = item.SubItems[1].Text;
                    string quantity = item.SubItems[2].Text;    
                    string query1 = "select AccessoriesName ,Quantity from Accessories";//need to code
                    var ds = this.Da.ExecuteQuery(query1);
                    if(ds.Tables[0].Rows.Count > 0)
                    {
                       // string OldQuantity = 

                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }



}







