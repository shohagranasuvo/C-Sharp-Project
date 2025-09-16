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
    public partial class UCAdminTransactions : UserControl
    {
        private DataAccess Da { get; set; }
        public UCAdminTransactions()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulatedGridView();
            //this.AutoIdGenerate();
        }

        private void PopulatedGridView(string sql = "select * from Bill;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvTransaction.AutoGenerateColumns = false;
            this.dgvTransaction.DataSource = ds.Tables[0];
        }
       

        private void btnTransactionSearch_Click(object sender, EventArgs e)
        {
            string sql = " select * from Bill where ReceptionistId = '" + this.txtTransactionSearch.Text + "'; ";
            this.PopulatedGridView(sql);
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = this.cmbStatus.SelectedItem.ToString();
            string sql = "";

            if (selectedStatus.Equals("Paid", StringComparison.OrdinalIgnoreCase))
            {
                sql = "select * from Bill where PaymentStatus = 'Paid';";
            }
            else if (selectedStatus.Equals("Pending", StringComparison.OrdinalIgnoreCase))
            {
                sql = "select * from Bill where PaymentStatus = 'Pending';";
            }

            this.PopulatedGridView(sql);
        }

        private void dgvTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTransactionSearch_ContentChanged(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTransactionSearch_Click_1(object sender, EventArgs e)
        {

        }
    }

}
