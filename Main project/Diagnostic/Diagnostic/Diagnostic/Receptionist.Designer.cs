namespace Diagnostic
{
    partial class Receptionist
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvAccessoriesDetails = new MetroFramework.Controls.MetroGrid();
            this.accessoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosticDataSet = new Diagnostic.DiagnosticDataSet();
            this.btnAccessoriesDetails = new MaterialSkin.Controls.MaterialRaisedButton();
            this.accessoriesTableAdapter = new Diagnostic.DiagnosticDataSetTableAdapters.AccessoriesTableAdapter();
            this.btnSearch = new CuoreUI.Controls.cuiButton();
            this.cmbSelectType = new CuoreUI.Controls.cuiComboBox();
            this.txtBoxSearch = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccessoriesDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAccessoriesDetails
            // 
            this.DgvAccessoriesDetails.AllowUserToAddRows = false;
            this.DgvAccessoriesDetails.AllowUserToDeleteRows = false;
            this.DgvAccessoriesDetails.AllowUserToResizeRows = false;
            this.DgvAccessoriesDetails.AutoGenerateColumns = false;
            this.DgvAccessoriesDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvAccessoriesDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvAccessoriesDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvAccessoriesDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAccessoriesDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAccessoriesDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAccessoriesDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accessoryIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.addedByDataGridViewTextBoxColumn,
            this.addedAtDataGridViewTextBoxColumn});
            this.DgvAccessoriesDetails.DataSource = this.accessoriesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAccessoriesDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvAccessoriesDetails.EnableHeadersVisualStyles = false;
            this.DgvAccessoriesDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvAccessoriesDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvAccessoriesDetails.Location = new System.Drawing.Point(4, 235);
            this.DgvAccessoriesDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvAccessoriesDetails.Name = "DgvAccessoriesDetails";
            this.DgvAccessoriesDetails.ReadOnly = true;
            this.DgvAccessoriesDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAccessoriesDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvAccessoriesDetails.RowHeadersWidth = 82;
            this.DgvAccessoriesDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvAccessoriesDetails.RowTemplate.Height = 33;
            this.DgvAccessoriesDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAccessoriesDetails.Size = new System.Drawing.Size(1732, 794);
            this.DgvAccessoriesDetails.TabIndex = 0;
            // 
            // accessoryIDDataGridViewTextBoxColumn
            // 
            this.accessoryIDDataGridViewTextBoxColumn.DataPropertyName = "AccessoryID";
            this.accessoryIDDataGridViewTextBoxColumn.HeaderText = "Accessory ID";
            this.accessoryIDDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.accessoryIDDataGridViewTextBoxColumn.Name = "accessoryIDDataGridViewTextBoxColumn";
            this.accessoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.accessoryIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 200;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 200;
            // 
            // addedByDataGridViewTextBoxColumn
            // 
            this.addedByDataGridViewTextBoxColumn.DataPropertyName = "AddedBy";
            this.addedByDataGridViewTextBoxColumn.HeaderText = "Added By";
            this.addedByDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.addedByDataGridViewTextBoxColumn.Name = "addedByDataGridViewTextBoxColumn";
            this.addedByDataGridViewTextBoxColumn.ReadOnly = true;
            this.addedByDataGridViewTextBoxColumn.Visible = false;
            this.addedByDataGridViewTextBoxColumn.Width = 200;
            // 
            // addedAtDataGridViewTextBoxColumn
            // 
            this.addedAtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.addedAtDataGridViewTextBoxColumn.DataPropertyName = "AddedAt";
            this.addedAtDataGridViewTextBoxColumn.HeaderText = "Added At";
            this.addedAtDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.addedAtDataGridViewTextBoxColumn.Name = "addedAtDataGridViewTextBoxColumn";
            this.addedAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.addedAtDataGridViewTextBoxColumn.Visible = false;
            this.addedAtDataGridViewTextBoxColumn.Width = 200;
            // 
            // accessoriesBindingSource
            // 
            this.accessoriesBindingSource.DataMember = "Accessories";
            this.accessoriesBindingSource.DataSource = this.diagnosticDataSet;
            // 
            // diagnosticDataSet
            // 
            this.diagnosticDataSet.DataSetName = "DiagnosticDataSet";
            this.diagnosticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAccessoriesDetails
            // 
            this.btnAccessoriesDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnAccessoriesDetails.Depth = 0;
            this.btnAccessoriesDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccessoriesDetails.ForeColor = System.Drawing.Color.White;
            this.btnAccessoriesDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccessoriesDetails.Location = new System.Drawing.Point(1364, 187);
            this.btnAccessoriesDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccessoriesDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAccessoriesDetails.Name = "btnAccessoriesDetails";
            this.btnAccessoriesDetails.Primary = true;
            this.btnAccessoriesDetails.Size = new System.Drawing.Size(368, 52);
            this.btnAccessoriesDetails.TabIndex = 1;
            this.btnAccessoriesDetails.Text = "Accessories Details";
            this.btnAccessoriesDetails.UseVisualStyleBackColor = false;
            this.btnAccessoriesDetails.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // accessoriesTableAdapter
            // 
            this.accessoriesTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.CheckButton = false;
            this.btnSearch.Checked = false;
            this.btnSearch.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSearch.CheckedForeColor = System.Drawing.Color.White;
            this.btnSearch.CheckedImageTint = System.Drawing.Color.White;
            this.btnSearch.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSearch.Content = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverBackground = System.Drawing.Color.White;
            this.btnSearch.HoverForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverImageTint = System.Drawing.Color.White;
            this.btnSearch.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearch.Image = null;
            this.btnSearch.ImageAutoCenter = true;
            this.btnSearch.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSearch.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearch.Location = new System.Drawing.Point(344, 183);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormalBackground = System.Drawing.Color.White;
            this.btnSearch.NormalForeColor = System.Drawing.Color.Black;
            this.btnSearch.NormalImageTint = System.Drawing.Color.White;
            this.btnSearch.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearch.OutlineThickness = 1F;
            this.btnSearch.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSearch.PressedImageTint = System.Drawing.Color.White;
            this.btnSearch.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearch.Rounding = new System.Windows.Forms.Padding(8);
            this.btnSearch.Size = new System.Drawing.Size(152, 44);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSelectType
            // 
            this.cmbSelectType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSelectType.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbSelectType.ButtonHoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cmbSelectType.ButtonHoverOutline = System.Drawing.Color.Empty;
            this.cmbSelectType.ButtonNormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cmbSelectType.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cmbSelectType.ButtonPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cmbSelectType.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cmbSelectType.DropDownBackgroundColor = System.Drawing.Color.White;
            this.cmbSelectType.DropDownOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSelectType.ExpandArrowColor = System.Drawing.Color.Gray;
            this.cmbSelectType.ForeColor = System.Drawing.Color.Gray;
            this.cmbSelectType.Items = new string[] {
        "Name",
        "AccessoryId"};
            this.cmbSelectType.Location = new System.Drawing.Point(506, 181);
            this.cmbSelectType.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.cmbSelectType.Name = "cmbSelectType";
            this.cmbSelectType.NoSelectionDropdownText = "Empty";
            this.cmbSelectType.NoSelectionText = "None";
            this.cmbSelectType.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmbSelectType.OutlineThickness = 1F;
            this.cmbSelectType.Rounding = 8;
            this.cmbSelectType.Size = new System.Drawing.Size(240, 44);
            this.cmbSelectType.TabIndex = 5;
            // 
            // txtBoxSearch
            // 
            // 
            // 
            // 
            this.txtBoxSearch.CustomButton.Image = null;
            this.txtBoxSearch.CustomButton.Location = new System.Drawing.Point(226, 2);
            this.txtBoxSearch.CustomButton.Name = "";
            this.txtBoxSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxSearch.CustomButton.TabIndex = 1;
            this.txtBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxSearch.CustomButton.UseSelectable = true;
            this.txtBoxSearch.CustomButton.Visible = false;
            this.txtBoxSearch.Lines = new string[0];
            this.txtBoxSearch.Location = new System.Drawing.Point(43, 187);
            this.txtBoxSearch.MaxLength = 32767;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PasswordChar = '\0';
            this.txtBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.SelectionLength = 0;
            this.txtBoxSearch.SelectionStart = 0;
            this.txtBoxSearch.ShortcutsEnabled = true;
            this.txtBoxSearch.Size = new System.Drawing.Size(254, 30);
            this.txtBoxSearch.TabIndex = 6;
            this.txtBoxSearch.UseSelectable = true;
            this.txtBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.cmbSelectType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAccessoriesDetails);
            this.Controls.Add(this.DgvAccessoriesDetails);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Receptionist";
            this.Size = new System.Drawing.Size(1736, 1069);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccessoriesDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid DgvAccessoriesDetails;
        private MaterialSkin.Controls.MaterialRaisedButton btnAccessoriesDetails;
        private System.Windows.Forms.BindingSource accessoriesBindingSource;
        private DiagnosticDataSet diagnosticDataSet;
        private DiagnosticDataSetTableAdapters.AccessoriesTableAdapter accessoriesTableAdapter;
        private CuoreUI.Controls.cuiButton btnSearch;
        private CuoreUI.Controls.cuiComboBox cmbSelectType;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedAtDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox txtBoxSearch;
    }
}
