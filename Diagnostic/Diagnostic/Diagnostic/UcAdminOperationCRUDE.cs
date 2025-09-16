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

        }
    }
}
