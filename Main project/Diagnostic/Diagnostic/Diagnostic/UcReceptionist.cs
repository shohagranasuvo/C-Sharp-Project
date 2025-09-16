using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WFADBCRUDN;

namespace Diagnostic
{
    public partial class UcReceptionist : UserControl
    {
        DataAccess da;
        public UcReceptionist()
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

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    if (this.cmbSelectType.SelectedItem.ToString() == "AccessoryId")
        //    {
        //        var sql = @"SELECT * FROM [Accessories] WHERE " + this.cmbSelectType.SelectedItem.ToString() + " = " + this.txtBoxSearch.contentTextField + "";

        //        var ds = this.da.ExecuteQuery(sql);
        //        this.DgvAccessoriesDetails.AutoGenerateColumns = true;
        //        this.DgvAccessoriesDetails.DataSource = ds.Tables[0];

        //    }
        //    else
        //    {
        //        string sql = @"SELECT * FROM [Accessories] WHERE " + this.cmbSelectType.SelectedItem.ToString() + " = '" + this.txtBoxSearch.contentTextField + "'";

        //        var ds = this.da.ExecuteQuery(sql);
        //        this.DgvAccessoriesDetails.AutoGenerateColumns = true;
        //        this.DgvAccessoriesDetails.DataSource = ds.Tables[0];
        //    }

        //}
       

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (cmbSelectType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a search type.");
                return;
            }

            string column = cmbSelectType.SelectedItem.ToString();
            
            string value = this.txtBoxForSearch.contentTextField.Text;
           // string val =this.txtsea.contentTextField.Text;

            


            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Please enter a search value.");
                return;
            }

            string sql;


            if (column == "AccessoryId")
            {
                if (!int.TryParse(value, out int id))
                {
                    MessageBox.Show("Please enter a valid numeric ID.");
                    return;
                }
                sql = $"SELECT * FROM [Accessories] WHERE {column} = {id}";
            }
            else
            {
                
                sql = $"SELECT * FROM [Accessories] WHERE {column} = '{value.Replace("'", "''")}'";
            }

            try
            {
                var ds = this.da.ExecuteQuery(sql);
                DgvAccessoriesDetails.AutoGenerateColumns = true;
                DgvAccessoriesDetails.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching: " + ex.Message);
            }

        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
