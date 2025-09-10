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

           // MessageBox.Show(ds.Tables[0].Rows.Count.ToString());



            this.DgvAccessoriesDetails.DataSource = ds.Tables[0];
        }
    }
}
