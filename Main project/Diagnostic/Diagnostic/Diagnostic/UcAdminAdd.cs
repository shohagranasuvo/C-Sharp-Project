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
    public partial class UcAdminAdd : UserControl
    {
        DataAccess da;
        public UcAdminAdd()
        {
            InitializeComponent();
           da=new DataAccess();
            var sql = "select * from Admin ;";
            PopulateGridView();
        }
        public void showTable()
        {
            var sql = "select * from Admin ";
            var ds =da.ExecuteQuery(sql);
            this.dvgAdminTable.AutoGenerateColumns = true;
            this.dvgAdminTable.DataSource = ds.Tables[0];
          
        }

        private void UcAdminAdd_Load(object sender, EventArgs e)
        {

        }
        private void PopulateGridView(string sql = "select * from Admin;")
        {
            var ds = this.da.ExecuteQuery(sql);

            this.dvgAdminTable.AutoGenerateColumns = false;
            this.dvgAdminTable.DataSource = ds.Tables[0];
        }

    }
}
