using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFADBCRUDN;

namespace Diagnostic
{
    public partial class Receptionist : UserControl
    {
        DataAccess da;
        public Receptionist()
        {
            
            InitializeComponent();
            da = new DataAccess();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            PopulateGridView("select * from Accessories");
        }

        private void PopulateGridView(string sql = "select * from Accessories;")
        {
            var ds = this.da.ExecuteQuery(sql);
            this.DgvAccessoriesDetails.AutoGenerateColumns = true;
            this.DgvAccessoriesDetails.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.cmbSelectType.SelectedItem.ToString() == "AccessoryId")
            {
                var sql = @"SELECT * FROM [Accessories] WHERE " + this.cmbSelectType.SelectedItem.ToString() + " = " + this.txtBoxSearch.contentTextField + "";

                var ds = this.da.ExecuteQuery(sql);
                this.DgvAccessoriesDetails.AutoGenerateColumns = true;
                this.DgvAccessoriesDetails.DataSource = ds.Tables[0];

            }
            else
            {
                string sql = @"SELECT * FROM [Accessories] WHERE " + this.cmbSelectType.SelectedItem.ToString() + " = '" + this.txtBoxSearch.contentTextField + "'";

                var ds = this.da.ExecuteQuery(sql);
                this.DgvAccessoriesDetails.AutoGenerateColumns = true;
                this.DgvAccessoriesDetails.DataSource = ds.Tables[0];
            }

        }
    }
}
