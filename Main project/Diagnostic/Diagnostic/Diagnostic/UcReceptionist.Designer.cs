namespace Diagnostic
{
    partial class UcReceptionist
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
            this.cmbSelectType = new CuoreUI.Controls.cuiComboBox();
            this.newDiagnosticDataSet = new Diagnostic.NewDiagnosticDataSet();
            this.accessoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accessoriesTableAdapter1 = new Diagnostic.NewDiagnosticDataSetTableAdapters.AccessoriesTableAdapter();
            this.DgvAccessoriesDetails = new MetroFramework.Controls.MetroGrid();
            this.AccessoriesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessoriesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdatePatient = new MetroFramework.Controls.MetroButton();
            this.btnAddpatient = new MetroFramework.Controls.MetroButton();
            this.txtBoxForSearch = new CuoreUI.Controls.cuiTextBox();
            this.btnForSearch = new MetroFramework.Controls.MetroButton();
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
            this.cmbSelectType.Location = new System.Drawing.Point(668, 60);
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
            this.DgvAccessoriesDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // AccessoriesId
            // 
            this.AccessoriesId.DataPropertyName = "AccessoriesId";
            this.AccessoriesId.HeaderText = "Accessories Id";
            this.AccessoriesId.MinimumWidth = 10;
            this.AccessoriesId.Name = "AccessoriesId";
            this.AccessoriesId.ReadOnly = true;
            this.AccessoriesId.Width = 200;
            // 
            // AccessoriesName
            // 
            this.AccessoriesName.DataPropertyName = "AccessoriesName";
            this.AccessoriesName.HeaderText = "Accessories Name";
            this.AccessoriesName.MinimumWidth = 10;
            this.AccessoriesName.Name = "AccessoriesName";
            this.AccessoriesName.ReadOnly = true;
            this.AccessoriesName.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 10;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 200;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 10;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 200;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEdit.BackgroundImage = global::Diagnostic.Properties.Resources.EditUserNew;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(96, 14);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 45);
            this.btnEdit.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEdit.UseCustomBackColor = true;
            this.btnEdit.UseCustomForeColor = true;
            this.btnEdit.UseSelectable = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDelete.BackgroundImage = global::Diagnostic.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(182, 14);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 45);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseCustomForeColor = true;
            this.btnDelete.UseSelectable = true;
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdatePatient.BackgroundImage = global::Diagnostic.Properties.Resources.updated_User;
            this.btnUpdatePatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdatePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePatient.ForeColor = System.Drawing.Color.Black;
            this.btnUpdatePatient.Location = new System.Drawing.Point(268, 14);
            this.btnUpdatePatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(54, 45);
            this.btnUpdatePatient.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnUpdatePatient.TabIndex = 16;
            this.btnUpdatePatient.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnUpdatePatient.UseCustomBackColor = true;
            this.btnUpdatePatient.UseCustomForeColor = true;
            this.btnUpdatePatient.UseSelectable = true;
            // 
            // btnAddpatient
            // 
            this.btnAddpatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddpatient.BackgroundImage = global::Diagnostic.Properties.Resources.add_user;
            this.btnAddpatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddpatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddpatient.ForeColor = System.Drawing.Color.Black;
            this.btnAddpatient.Location = new System.Drawing.Point(12, 14);
            this.btnAddpatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddpatient.Name = "btnAddpatient";
            this.btnAddpatient.Size = new System.Drawing.Size(64, 45);
            this.btnAddpatient.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAddpatient.TabIndex = 15;
            this.btnAddpatient.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAddpatient.UseCustomBackColor = true;
            this.btnAddpatient.UseCustomForeColor = true;
            this.btnAddpatient.UseSelectable = true;
            // 
            // txtBoxForSearch
            // 
            this.txtBoxForSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBoxForSearch.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBoxForSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtBoxForSearch.Content = "";
            this.txtBoxForSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxForSearch.FocusBackgroundColor = System.Drawing.Color.White;
            this.txtBoxForSearch.FocusImageTint = System.Drawing.Color.White;
            this.txtBoxForSearch.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.txtBoxForSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxForSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxForSearch.Image = null;
            this.txtBoxForSearch.ImageExpand = new System.Drawing.Point(0, 0);
            this.txtBoxForSearch.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtBoxForSearch.Location = new System.Drawing.Point(500, 14);
            this.txtBoxForSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxForSearch.Multiline = false;
            this.txtBoxForSearch.Name = "txtBoxForSearch";
            this.txtBoxForSearch.NormalImageTint = System.Drawing.Color.White;
            this.txtBoxForSearch.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtBoxForSearch.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.txtBoxForSearch.PasswordChar = false;
            this.txtBoxForSearch.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxForSearch.PlaceholderText = "";
            this.txtBoxForSearch.Rounding = new System.Windows.Forms.Padding(20);
            this.txtBoxForSearch.Size = new System.Drawing.Size(288, 33);
            this.txtBoxForSearch.TabIndex = 19;
            this.txtBoxForSearch.TextOffset = new System.Drawing.Size(0, 0);
            this.txtBoxForSearch.UnderlinedStyle = false;
            // 
            // btnForSearch
            // 
            this.btnForSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnForSearch.BackgroundImage = global::Diagnostic.Properties.Resources.Search;
            this.btnForSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnForSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForSearch.ForeColor = System.Drawing.Color.Black;
            this.btnForSearch.Location = new System.Drawing.Point(764, 19);
            this.btnForSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnForSearch.Name = "btnForSearch";
            this.btnForSearch.Size = new System.Drawing.Size(24, 21);
            this.btnForSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnForSearch.TabIndex = 20;
            this.btnForSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnForSearch.UseCustomBackColor = true;
            this.btnForSearch.UseCustomForeColor = true;
            this.btnForSearch.UseSelectable = true;
            this.btnForSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnForSearch);
            this.Controls.Add(this.txtBoxForSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdatePatient);
            this.Controls.Add(this.btnAddpatient);
            this.Controls.Add(this.cmbSelectType);
            this.Controls.Add(this.btnAccessoriesDetails);
            this.Controls.Add(this.DgvAccessoriesDetails);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Receptionist";
            this.Size = new System.Drawing.Size(868, 661);
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
        private CuoreUI.Controls.cuiComboBox cmbSelectType;
        private System.Windows.Forms.BindingSource accessoriesBindingSource1;
        private NewDiagnosticDataSet newDiagnosticDataSet;
        private NewDiagnosticDataSetTableAdapters.AccessoriesTableAdapter accessoriesTableAdapter1;
        private MetroFramework.Controls.MetroGrid DgvAccessoriesDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessoriesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessoriesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnUpdatePatient;
        private MetroFramework.Controls.MetroButton btnAddpatient;
        private CuoreUI.Controls.cuiTextBox txtBoxForSearch;
        private MetroFramework.Controls.MetroButton btnForSearch;
    }
}
