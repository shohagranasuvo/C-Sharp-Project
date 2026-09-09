using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagnostic
{
    public partial class UCAdminCRUDAccessories : UserControl
    {


        private DataAccess Da { get; set; }

        public UCAdminCRUDAccessories()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.dvgAccessories.ClearSelection();
            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        private void PopulateGridView(string sql = "select * from Accessories;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dvgAccessories.AutoGenerateColumns = false;
            this.dvgAccessories.DataSource = ds.Tables[0];
        }




        private void ClearAll()
        {
            this.txtId.Clear();
            this.txtName.Clear();
            this.txtQuantity.Clear();
            this.txtPrice.Clear();
            this.txtSearch.Text = "";

            this.dvgAccessories.ClearSelection();
            this.AutoIdGenerate();
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtName.Text))
                return false;
            double price;
            int quantity;
            if (!double.TryParse(this.txtPrice.Text, out price) || !int.TryParse(this.txtQuantity.Text, out quantity))
            {
                return false;
            }
            else return true;
        }



        private void AutoIdGenerate()
        {
            var query = "select max(AccessoriesId) from Accessories;";
            var dt = this.Da.ExecuteQueryTable(query);
            var oldId = dt.Rows[0][0].ToString();
            var s = oldId.Split('-');
            var temp = Convert.ToInt32(s[1]);
            var newId = "a-" + (++temp).ToString("d3");
            this.txtId.Text = newId;
        }

        private void dvgAccessories_DoubleClick(object sender, EventArgs e)
        {

            this.txtId.Text = this.dvgAccessories.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dvgAccessories.CurrentRow.Cells[1].Value.ToString();
            this.txtQuantity.Text = this.dvgAccessories.CurrentRow.Cells[2].Value.ToString();
            this.txtPrice.Text = this.dvgAccessories.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.dvgAccessories.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var id = this.dvgAccessories.CurrentRow.Cells[0].Value.ToString();
                var name = this.dvgAccessories.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + name + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from Accessories where AccessoriesId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("This accessories" +
                        " hasn't been deleted");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            this.AutoIdGenerate();
            this.ClearAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            this.txtId.Text = this.dvgAccessories.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dvgAccessories.CurrentRow.Cells[1].Value.ToString();
            this.txtQuantity.Text = this.dvgAccessories.CurrentRow.Cells[2].Value.ToString();
            this.txtPrice.Text = this.dvgAccessories.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.ClearAll();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the fields properly.");
                    return;
                }

                var query = "select * from Accessories where AccessoriesId ='" + this.txtId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {


                    var sql = @"update Accessories
                                set AccessoriesName = '" + this.txtName.Text + @"',
                                quantity = quantity + " + this.txtQuantity.Text + @",
                                Price = " + this.txtPrice.Text + @"
                                where AccessoriesId = '" + this.txtId.Text + "';";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Accessories Information has been updated");
                    else MessageBox.Show("Accessories information hasn't beed updated");
                }
                else
                {

                    var sql = "insert into Accessories values('" + this.txtId.Text + "', '" + this.txtName.Text + "', '" + this.txtQuantity.Text + "', " + this.txtPrice.Text + ");";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Accessories has been Added");
                    else
                        MessageBox.Show("Accessories hasn't been added");

                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has Occured: " + exc.Message);
            }




        }


        private void txtSearch_ContentChanged(object sender, EventArgs e)
        {

            try
            {

                string sql = $"SELECT * FROM [Accessories] WHERE AccessoriesName like '%{this.txtSearch.contentTextField.Text.Replace("'", "''")}%'";

                var ds = this.Da.ExecuteQuery(sql);
                dvgAccessories.AutoGenerateColumns = false;
                dvgAccessories.DataSource = ds.Tables[0];

            }

            catch (Exception exc)
            {
                MessageBox.Show("Try Again in proper way");
            }
        }
    }
}
