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
            this.accessoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosticDataSet = new Diagnostic.DiagnosticDataSet();
            this.btnAccessoriesDetails = new MaterialSkin.Controls.MaterialRaisedButton();
            this.accessoriesTableAdapter = new Diagnostic.DiagnosticDataSetTableAdapters.AccessoriesTableAdapter();
            this.btnSearch = new CuoreUI.Controls.cuiButton();
            this.cmbSelectType = new CuoreUI.Controls.cuiComboBox();
            this.txtBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.newDiagnosticDataSet = new Diagnostic.NewDiagnosticDataSet();
            this.accessoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accessoriesTableAdapter1 = new Diagnostic.NewDiagnosticDataSetTableAdapters.AccessoriesTableAdapter();
            this.DgvAccessoriesDetails = new MetroFramework.Controls.MetroGrid();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.AccessoriesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessoriesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDiagnosticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccessoriesDetails)).BeginInit();
            this.SuspendLayout();
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
            this.btnAccessoriesDetails.Location = new System.Drawing.Point(682, 97);
            this.btnAccessoriesDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAccessoriesDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAccessoriesDetails.Name = "btnAccessoriesDetails";
            this.btnAccessoriesDetails.Primary = true;
            this.btnAccessoriesDetails.Size = new System.Drawing.Size(184, 27);
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
            this.btnSearch.Location = new System.Drawing.Point(172, 95);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnSearch.Size = new System.Drawing.Size(76, 23);
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
        "AccessoriesName",
        "AccessoriesId"};
            this.cmbSelectType.Location = new System.Drawing.Point(253, 94);
            this.cmbSelectType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbSelectType.Name = "cmbSelectType";
            this.cmbSelectType.NoSelectionDropdownText = "Empty";
            this.cmbSelectType.NoSelectionText = "None";
            this.cmbSelectType.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmbSelectType.OutlineThickness = 1F;
            this.cmbSelectType.Rounding = 8;
            this.cmbSelectType.Size = new System.Drawing.Size(120, 23);
            this.cmbSelectType.TabIndex = 5;
            // 
            // txtBoxSearch
            // 
            // 
            // 
            // 
            this.txtBoxSearch.CustomButton.Image = null;
            this.txtBoxSearch.CustomButton.Location = new System.Drawing.Point(56, 1);
            this.txtBoxSearch.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxSearch.CustomButton.Name = "";
            this.txtBoxSearch.CustomButton.Size = new System.Drawing.Size(6, 6);
            this.txtBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxSearch.CustomButton.TabIndex = 1;
            this.txtBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxSearch.CustomButton.UseSelectable = true;
            this.txtBoxSearch.CustomButton.Visible = false;
            this.txtBoxSearch.Lines = new string[0];
            this.txtBoxSearch.Location = new System.Drawing.Point(22, 97);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxSearch.MaxLength = 32767;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PasswordChar = '\0';
            this.txtBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.SelectionLength = 0;
            this.txtBoxSearch.SelectionStart = 0;
            this.txtBoxSearch.ShortcutsEnabled = true;
            this.txtBoxSearch.Size = new System.Drawing.Size(127, 16);
            this.txtBoxSearch.TabIndex = 6;
            this.txtBoxSearch.UseSelectable = true;
            this.txtBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // newDiagnosticDataSet
            // 
            this.newDiagnosticDataSet.DataSetName = "NewDiagnosticDataSet";
            this.newDiagnosticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accessoriesBindingSource1
            // 
            this.accessoriesBindingSource1.DataMember = "Accessories";
            this.accessoriesBindingSource1.DataSource = this.newDiagnosticDataSet;
            // 
            // accessoriesTableAdapter1
            // 
            this.accessoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // DgvAccessoriesDetails
            // 
            this.DgvAccessoriesDetails.AllowUserToAddRows = false;
            this.DgvAccessoriesDetails.AllowUserToDeleteRows = false;
            this.DgvAccessoriesDetails.AllowUserToResizeRows = false;
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
            this.AccessoriesId,
            this.AccessoriesName,
            this.Quantity,
            this.Price});
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
            this.DgvAccessoriesDetails.Location = new System.Drawing.Point(2, 122);
            this.DgvAccessoriesDetails.Margin = new System.Windows.Forms.Padding(2);
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
            this.DgvAccessoriesDetails.Size = new System.Drawing.Size(866, 413);
            this.DgvAccessoriesDetails.TabIndex = 0;
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::Diagnostic.Properties.Resources.alert2;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton1.Location = new System.Drawing.Point(22, 21);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.UseSelectable = true;
            // 
            // AccessoriesId
            // 
            this.AccessoriesId.DataPropertyName = "AccessoriesId";
            this.AccessoriesId.HeaderText = "Accessories Id";
            this.AccessoriesId.Name = "AccessoriesId";
            this.AccessoriesId.ReadOnly = true;
            // 
            // AccessoriesName
            // 
            this.AccessoriesName.DataPropertyName = "AccessoriesName";
            this.AccessoriesName.HeaderText = "Accessories Name";
            this.AccessoriesName.Name = "AccessoriesName";
            this.AccessoriesName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.cmbSelectType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAccessoriesDetails);
            this.Controls.Add(this.DgvAccessoriesDetails);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Receptionist";
            this.Size = new System.Drawing.Size(868, 556);
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDiagnosticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccessoriesDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnAccessoriesDetails;
        private System.Windows.Forms.BindingSource accessoriesBindingSource;
        private DiagnosticDataSet diagnosticDataSet;
        private DiagnosticDataSetTableAdapters.AccessoriesTableAdapter accessoriesTableAdapter;
        private CuoreUI.Controls.cuiButton btnSearch;
        private CuoreUI.Controls.cuiComboBox cmbSelectType;
        private MetroFramework.Controls.MetroTextBox txtBoxSearch;
        private System.Windows.Forms.BindingSource accessoriesBindingSource1;
        private NewDiagnosticDataSet newDiagnosticDataSet;
        private NewDiagnosticDataSetTableAdapters.AccessoriesTableAdapter accessoriesTableAdapter1;
        private MetroFramework.Controls.MetroGrid DgvAccessoriesDetails;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessoriesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessoriesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
