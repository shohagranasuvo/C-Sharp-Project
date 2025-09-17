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
    public partial class UCAdminCRUDTest : UserControl
    {

        private DataAccess Da { get; set; }

        public UCAdminCRUDTest()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.dvgTest.ClearSelection();
            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        private void PopulateGridView(string sql = "select * from Test;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dvgTest.AutoGenerateColumns = false;
            this.dvgTest.DataSource = ds.Tables[0];
        }


        private void ClearAll()
        {
            this.txtTestId.Clear();
            this.txtName.Clear();
            this.txtDisease.Clear();
            this.txtPrice.Clear();
            this.txtSearch.Text = "";

            this.dvgTest.ClearSelection();
            this.AutoIdGenerate();
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtName.Text) || string.IsNullOrEmpty(this.txtDisease.Text))
                return false;
            double price;
            if (!double.TryParse(this.txtPrice.Text, out price))
            {
                return false;
            }
            else return true;
        }



        private void AutoIdGenerate()
        {
            var query = "select max(TestId) from Test;";
            var dt = this.Da.ExecuteQueryTable(query);
            var oldId = dt.Rows[0][0].ToString();
            var s = oldId.Split('-');
            var temp = Convert.ToInt32(s[1]);
            var newId = "t-" + (++temp).ToString("d3");
            this.txtTestId.Text = newId;
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {

            this.PopulateGridView();
            this.ClearAll();
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {

            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the fields properly.");
                    return;
                }

                var query = "select * from Test where TestId ='" + this.txtTestId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {

                    var sql = @"update Test
                                set TestName = '" + this.txtName.Text + @"',
                                Diseases = '" + this.txtDisease.Text + @"',
                                Price = " + this.txtPrice.Text + @"
                                where TestId = '" + this.txtTestId.Text + "';";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Test Information has been updated");
                    else MessageBox.Show("Test information hasn't been updated");
                }
                else
                {

                    var sql = "insert into Test values('" + this.txtTestId.Text + "', '" + this.txtName.Text + "', '" + this.txtDisease.Text + "', " + this.txtPrice.Text + ");";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Test has been Added");
                    else
                        MessageBox.Show("Test hasn't been added");

                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has Occured: " + exc.Message);
            }

        }

        private void dvgTest_DoubleClick(object sender, EventArgs e)
        {

            this.txtTestId.Text = this.dvgTest.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dvgTest.CurrentRow.Cells[1].Value.ToString();
            this.txtDisease.Text = this.dvgTest.CurrentRow.Cells[2].Value.ToString();
            this.txtPrice.Text = this.dvgTest.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.dvgTest.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var id = this.dvgTest.CurrentRow.Cells[0].Value.ToString();
                var name = this.dvgTest.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + name + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from Test where TestId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("This test hasn't been deleted");

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

            this.txtTestId.Text = this.dvgTest.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dvgTest.CurrentRow.Cells[1].Value.ToString();
            this.txtDisease.Text = this.dvgTest.CurrentRow.Cells[2].Value.ToString();
            this.txtPrice.Text = this.dvgTest.CurrentRow.Cells[3].Value.ToString();

        }

        private void txtSearch_ContentChanged(object sender, EventArgs e)
        {

            try
            {

                string sql = $"SELECT * FROM [Test] WHERE TestName like '%{this.txtSearch.contentTextField.Text.Replace("'", "''")}%'";

                var ds = this.Da.ExecuteQuery(sql);
                dvgTest.AutoGenerateColumns = false;
                dvgTest.DataSource = ds.Tables[0];

            }

            catch (Exception exc)
            {
                MessageBox.Show("Try Again in proper way");
            }
        }
    }
}
