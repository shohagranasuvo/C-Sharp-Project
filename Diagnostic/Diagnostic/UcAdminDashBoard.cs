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
    public partial class UcAdminDashBoard : UserControl
    { DataAccess Da {  get; set; }  
        public UcAdminDashBoard()
        {
            InitializeComponent();
            Da= new DataAccess();   
            updatelabel();
        }

       public void updatelabel()
        {

            string query = "select count(testid) from test ;";
                var ds = this.Da.ExecuteQuery(query);
            this.lblTest.Text = ds.Tables[0].Rows[0][0].ToString();
             query = "select count(Accessoriesid) from Accessories;";
             ds = this.Da.ExecuteQuery(query);
            this.lblAccessories.Text = ds.Tables[0].Rows[0][0].ToString();
            query = "select count(Patientid) from patient;";
            ds = this.Da.ExecuteQuery(query);
            this.lblpatient.Text = ds.Tables[0].Rows[0][0].ToString();
            query = "select count(ReceptionistId) from Receptionist;";
            ds = this.Da.ExecuteQuery(query);
            this.lblReceptionist.Text = ds.Tables[0].Rows[0][0].ToString();





        }
    }
}
