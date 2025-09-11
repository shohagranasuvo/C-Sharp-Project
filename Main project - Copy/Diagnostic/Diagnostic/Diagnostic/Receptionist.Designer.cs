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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvAccessoriesDetails = new MetroFramework.Controls.MetroGrid();
            this.btnAccessoriesDetails = new MaterialSkin.Controls.MaterialRaisedButton();
            this.diagnosticDataSet = new Diagnostic.DiagnosticDataSet();
            this.accessoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessoriesTableAdapter = new Diagnostic.DiagnosticDataSetTableAdapters.AccessoriesTableAdapter();
            this.txtBoxSearch = new CuoreUI.Controls.cuiTextBox();
            this.btnSearch = new CuoreUI.Controls.cuiButton();
            this.cmbSelectType = new CuoreUI.Controls.cuiComboBox();
            this.accessoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccessoriesDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource)).BeginInit();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAccessoriesDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAccessoriesDetails.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvAccessoriesDetails.EnableHeadersVisualStyles = false;
            this.DgvAccessoriesDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvAccessoriesDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvAccessoriesDetails.Location = new System.Drawing.Point(3, 176);
            this.DgvAccessoriesDetails.Name = "DgvAccessoriesDetails";
            this.DgvAccessoriesDetails.ReadOnly = true;
            this.DgvAccessoriesDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAccessoriesDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvAccessoriesDetails.RowHeadersWidth = 82;
            this.DgvAccessoriesDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvAccessoriesDetails.RowTemplate.Height = 33;
            this.DgvAccessoriesDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAccessoriesDetails.Size = new System.Drawing.Size(1223, 568);
            this.DgvAccessoriesDetails.TabIndex = 0;
            // 
            // btnAccessoriesDetails
            // 
            this.btnAccessoriesDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnAccessoriesDetails.Depth = 0;
            this.btnAccessoriesDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccessoriesDetails.ForeColor = System.Drawing.Color.White;
            this.btnAccessoriesDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccessoriesDetails.Location = new System.Drawing.Point(856, 118);
            this.btnAccessoriesDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAccessoriesDetails.Name = "btnAccessoriesDetails";
            this.btnAccessoriesDetails.Primary = true;
            this.btnAccessoriesDetails.Size = new System.Drawing.Size(367, 52);
            this.btnAccessoriesDetails.TabIndex = 1;
            this.btnAccessoriesDetails.Text = "Accessories Details";
            this.btnAccessoriesDetails.UseVisualStyleBackColor = false;
            this.btnAccessoriesDetails.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // diagnosticDataSet
            // 
            this.diagnosticDataSet.DataSetName = "DiagnosticDataSet";
            this.diagnosticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accessoriesBindingSource
            // 
            this.accessoriesBindingSource.DataMember = "Accessories";
            this.accessoriesBindingSource.DataSource = this.diagnosticDataSet;
            // 
            // accessoriesTableAdapter
            // 
            this.accessoriesTableAdapter.ClearBeforeFill = true;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BackgroundColor = System.Drawing.Color.White;
            this.txtBoxSearch.Content = "";
            this.txtBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearch.FocusBackgroundColor = System.Drawing.Color.White;
            this.txtBoxSearch.FocusImageTint = System.Drawing.Color.White;
            this.txtBoxSearch.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxSearch.Image = null;
            this.txtBoxSearch.ImageExpand = new System.Drawing.Point(0, 0);
            this.txtBoxSearch.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtBoxSearch.Location = new System.Drawing.Point(20, 128);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSearch.Multiline = false;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.NormalImageTint = System.Drawing.Color.White;
            this.txtBoxSearch.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtBoxSearch.Padding = new System.Windows.Forms.Padding(29, 6, 29, 0);
            this.txtBoxSearch.PasswordChar = false;
            this.txtBoxSearch.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxSearch.PlaceholderText = "";
            this.txtBoxSearch.Rounding = new System.Windows.Forms.Padding(8);
            this.txtBoxSearch.Size = new System.Drawing.Size(332, 41);
            this.txtBoxSearch.TabIndex = 2;
            this.txtBoxSearch.TextOffset = new System.Drawing.Size(0, 0);
            this.txtBoxSearch.UnderlinedStyle = true;
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
            this.btnSearch.Location = new System.Drawing.Point(375, 128);
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
            this.btnSearch.Size = new System.Drawing.Size(153, 45);
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
            this.cmbSelectType.Location = new System.Drawing.Point(537, 128);
            this.cmbSelectType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbSelectType.Name = "cmbSelectType";
            this.cmbSelectType.NoSelectionDropdownText = "Empty";
            this.cmbSelectType.NoSelectionText = "None";
            this.cmbSelectType.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmbSelectType.OutlineThickness = 1F;
            this.cmbSelectType.Rounding = 8;
            this.cmbSelectType.Size = new System.Drawing.Size(239, 45);
            this.cmbSelectType.TabIndex = 5;
            // 
            // accessoryIDDataGridViewTextBoxColumn
            // 
            this.accessoryIDDataGridViewTextBoxColumn.DataPropertyName = "AccessoryID";
            this.accessoryIDDataGridViewTextBoxColumn.HeaderText = "Accessory ID";
            this.accessoryIDDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.accessoryIDDataGridViewTextBoxColumn.Name = "accessoryIDDataGridViewTextBoxColumn";
            this.accessoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addedByDataGridViewTextBoxColumn
            // 
            this.addedByDataGridViewTextBoxColumn.DataPropertyName = "AddedBy";
            this.addedByDataGridViewTextBoxColumn.HeaderText = "Added By";
            this.addedByDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.addedByDataGridViewTextBoxColumn.Name = "addedByDataGridViewTextBoxColumn";
            this.addedByDataGridViewTextBoxColumn.ReadOnly = true;
            this.addedByDataGridViewTextBoxColumn.Visible = false;
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
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbSelectType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.btnAccessoriesDetails);
            this.Controls.Add(this.DgvAccessoriesDetails);
            this.Name = "Receptionist";
            this.Size = new System.Drawing.Size(1226, 747);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccessoriesDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid DgvAccessoriesDetails;
        private MaterialSkin.Controls.MaterialRaisedButton btnAccessoriesDetails;
        private System.Windows.Forms.BindingSource accessoriesBindingSource;
        private DiagnosticDataSet diagnosticDataSet;
        private DiagnosticDataSetTableAdapters.AccessoriesTableAdapter accessoriesTableAdapter;
        private CuoreUI.Controls.cuiTextBox txtBoxSearch;
        private CuoreUI.Controls.cuiButton btnSearch;
        private CuoreUI.Controls.cuiComboBox cmbSelectType;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedAtDataGridViewTextBoxColumn;
    }
}
