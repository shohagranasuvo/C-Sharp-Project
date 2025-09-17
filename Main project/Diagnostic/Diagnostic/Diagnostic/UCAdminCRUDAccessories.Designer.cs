namespace Diagnostic
{
    partial class UCAdminCRUDAccessories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new CuoreUI.Controls.cuiTextBox();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.pnlRegisterPatient = new MetroFramework.Controls.MetroPanel();
            this.pnlAdminAddAccessories = new CuoreUI.Controls.cuiGradientPanel();
            this.pnlGrideViewPatient = new MetroFramework.Controls.MetroPanel();
            this.dvgAccessories = new MetroFramework.Controls.MetroGrid();
            this.AccessoriesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessoriesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAdd = new CuoreUI.Controls.cuiPanel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.pnlRegisterPatient.SuspendLayout();
            this.pnlAdminAddAccessories.SuspendLayout();
            this.pnlGrideViewPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAccessories)).BeginInit();
            this.pnlAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.BackgroundImage = global::Diagnostic.Properties.Resources.Search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(1638, 45);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 64);
            this.btnSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSearch.UseCustomBackColor = true;
            this.btnSearch.UseCustomForeColor = true;
            this.btnSearch.UseSelectable = true;
            //this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSearch.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtSearch.Content = "";
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusBackgroundColor = System.Drawing.Color.White;
            this.txtSearch.FocusImageTint = System.Drawing.Color.White;
            this.txtSearch.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Image = null;
            this.txtSearch.ImageExpand = new System.Drawing.Point(0, 0);
            this.txtSearch.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtSearch.Location = new System.Drawing.Point(1137, 45);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.NormalImageTint = System.Drawing.Color.White;
            this.txtSearch.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtSearch.Padding = new System.Windows.Forms.Padding(29, 18, 29, 0);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.Rounding = new System.Windows.Forms.Padding(20);
            this.txtSearch.Size = new System.Drawing.Size(560, 64);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextOffset = new System.Drawing.Size(0, 0);
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch.ContentChanged += new System.EventHandler(this.txtSearch_ContentChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEdit.BackgroundImage = global::Diagnostic.Properties.Resources.EditUserNew;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(192, 23);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 86);
            this.btnEdit.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEdit.UseCustomBackColor = true;
            this.btnEdit.UseCustomForeColor = true;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDelete.BackgroundImage = global::Diagnostic.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(364, 23);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 86);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseCustomForeColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.BackgroundImage = global::Diagnostic.Properties.Resources.add_user;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(24, 23);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 86);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseCustomForeColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlRegisterPatient
            // 
            this.pnlRegisterPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.pnlRegisterPatient.Controls.Add(this.pnlAdminAddAccessories);
            this.pnlRegisterPatient.HorizontalScrollbarBarColor = true;
            this.pnlRegisterPatient.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlRegisterPatient.HorizontalScrollbarSize = 9;
            this.pnlRegisterPatient.Location = new System.Drawing.Point(0, 16);
            this.pnlRegisterPatient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlRegisterPatient.Name = "pnlRegisterPatient";
            this.pnlRegisterPatient.Size = new System.Drawing.Size(1736, 1238);
            this.pnlRegisterPatient.TabIndex = 10;
            this.pnlRegisterPatient.VerticalScrollbarBarColor = true;
            this.pnlRegisterPatient.VerticalScrollbarHighlightOnWheel = false;
            this.pnlRegisterPatient.VerticalScrollbarSize = 10;
            // 
            // pnlAdminAddAccessories
            // 
            this.pnlAdminAddAccessories.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlAdminAddAccessories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAdminAddAccessories.Controls.Add(this.pnlGrideViewPatient);
            this.pnlAdminAddAccessories.Controls.Add(this.pnlAdd);
            this.pnlAdminAddAccessories.Controls.Add(this.btnSearch);
            this.pnlAdminAddAccessories.Controls.Add(this.txtSearch);
            this.pnlAdminAddAccessories.Controls.Add(this.btnEdit);
            this.pnlAdminAddAccessories.Controls.Add(this.btnDelete);
            this.pnlAdminAddAccessories.Controls.Add(this.btnAdd);
            this.pnlAdminAddAccessories.GradientAngle = 0F;
            this.pnlAdminAddAccessories.Location = new System.Drawing.Point(4, 3);
            this.pnlAdminAddAccessories.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlAdminAddAccessories.Name = "pnlAdminAddAccessories";
            this.pnlAdminAddAccessories.OutlineThickness = 1F;
            this.pnlAdminAddAccessories.PanelColor1 = System.Drawing.Color.LightSkyBlue;
            this.pnlAdminAddAccessories.PanelColor2 = System.Drawing.Color.Transparent;
            this.pnlAdminAddAccessories.PanelOutlineColor1 = System.Drawing.Color.PaleTurquoise;
            this.pnlAdminAddAccessories.PanelOutlineColor2 = System.Drawing.Color.LightBlue;
            this.pnlAdminAddAccessories.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlAdminAddAccessories.Size = new System.Drawing.Size(1732, 1268);
            this.pnlAdminAddAccessories.TabIndex = 2;
            // 
            // pnlGrideViewPatient
            // 
            this.pnlGrideViewPatient.Controls.Add(this.dvgAccessories);
            this.pnlGrideViewPatient.HorizontalScrollbarBarColor = true;
            this.pnlGrideViewPatient.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlGrideViewPatient.HorizontalScrollbarSize = 9;
            this.pnlGrideViewPatient.Location = new System.Drawing.Point(-2, 167);
            this.pnlGrideViewPatient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlGrideViewPatient.Name = "pnlGrideViewPatient";
            this.pnlGrideViewPatient.Size = new System.Drawing.Size(1112, 891);
            this.pnlGrideViewPatient.TabIndex = 19;
            this.pnlGrideViewPatient.VerticalScrollbarBarColor = true;
            this.pnlGrideViewPatient.VerticalScrollbarHighlightOnWheel = false;
            this.pnlGrideViewPatient.VerticalScrollbarSize = 10;
            // 
            // dvgAccessories
            // 
            this.dvgAccessories.AllowUserToAddRows = false;
            this.dvgAccessories.AllowUserToDeleteRows = false;
            this.dvgAccessories.AllowUserToResizeRows = false;
            this.dvgAccessories.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dvgAccessories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgAccessories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgAccessories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgAccessories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgAccessories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAccessories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccessoriesId,
            this.AccessoriesName,
            this.Quantity,
            this.Price});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgAccessories.DefaultCellStyle = dataGridViewCellStyle5;
            this.dvgAccessories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgAccessories.EnableHeadersVisualStyles = false;
            this.dvgAccessories.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dvgAccessories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgAccessories.Location = new System.Drawing.Point(0, 0);
            this.dvgAccessories.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dvgAccessories.Name = "dvgAccessories";
            this.dvgAccessories.ReadOnly = true;
            this.dvgAccessories.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgAccessories.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgAccessories.RowHeadersWidth = 82;
            this.dvgAccessories.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgAccessories.RowTemplate.Height = 33;
            this.dvgAccessories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgAccessories.Size = new System.Drawing.Size(1112, 891);
            this.dvgAccessories.TabIndex = 17;
            this.dvgAccessories.DoubleClick += new System.EventHandler(this.dvgAccessories_DoubleClick);
            // 
            // AccessoriesId
            // 
            this.AccessoriesId.DataPropertyName = "AccessoriesId";
            this.AccessoriesId.HeaderText = "ID";
            this.AccessoriesId.MinimumWidth = 6;
            this.AccessoriesId.Name = "AccessoriesId";
            this.AccessoriesId.ReadOnly = true;
            this.AccessoriesId.Width = 125;
            // 
            // AccessoriesName
            // 
            this.AccessoriesName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccessoriesName.DataPropertyName = "AccessoriesName";
            this.AccessoriesName.HeaderText = "Name";
            this.AccessoriesName.MinimumWidth = 6;
            this.AccessoriesName.Name = "AccessoriesName";
            this.AccessoriesName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.LightBlue;
            this.pnlAdd.Controls.Add(this.txtId);
            this.pnlAdd.Controls.Add(this.btnSave);
            this.pnlAdd.Controls.Add(this.cuiLabel1);
            this.pnlAdd.Controls.Add(this.btnUpdate);
            this.pnlAdd.Controls.Add(this.txtPrice);
            this.pnlAdd.Controls.Add(this.txtQuantity);
            this.pnlAdd.Controls.Add(this.txtName);
            this.pnlAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdd.Location = new System.Drawing.Point(1134, 167);
            this.pnlAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.OutlineThickness = 1F;
            this.pnlAdd.PanelColor = System.Drawing.Color.LightBlue;
            this.pnlAdd.PanelOutlineColor = System.Drawing.Color.LightBlue;
            this.pnlAdd.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlAdd.Size = new System.Drawing.Size(576, 870);
            this.pnlAdd.TabIndex = 18;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(446, 2);
            this.txtId.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(32, 111);
            this.txtId.Margin = new System.Windows.Forms.Padding(0);
            this.txtId.MaxLength = 32767;
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PromptText = "Accessories ID";
            this.txtId.ReadOnly = true;
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(488, 44);
            this.txtId.Style = MetroFramework.MetroColorStyle.White;
            this.txtId.TabIndex = 13;
            this.txtId.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.UseCustomBackColor = true;
            this.txtId.UseCustomForeColor = true;
            this.txtId.UseSelectable = true;
            this.txtId.UseStyleColors = true;
            this.txtId.WaterMark = "Accessories ID";
            this.txtId.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtId.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(160, 448);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(212, 59);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "<<   SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "ADD\\ ACCESSORIES";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(76, 45);
            this.cuiLabel1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(390, 41);
            this.cuiLabel1.TabIndex = 7;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdate.BackgroundImage = global::Diagnostic.Properties.Resources.updated_User;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(210, 580);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 86);
            this.btnUpdate.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnUpdate.UseCustomBackColor = true;
            this.btnUpdate.UseCustomForeColor = true;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(446, 2);
            this.txtPrice.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(32, 373);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PromptText = "Price";
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(488, 44);
            this.txtPrice.Style = MetroFramework.MetroColorStyle.White;
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.UseCustomBackColor = true;
            this.txtPrice.UseCustomForeColor = true;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.UseStyleColors = true;
            this.txtPrice.WaterMark = "Price";
            this.txtPrice.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(446, 2);
            this.txtQuantity.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(32, 286);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PromptText = "Quantity";
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(488, 44);
            this.txtQuantity.Style = MetroFramework.MetroColorStyle.White;
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.UseCustomBackColor = true;
            this.txtQuantity.UseCustomForeColor = true;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.UseStyleColors = true;
            this.txtQuantity.WaterMark = "Quantity";
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(446, 2);
            this.txtName.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(32, 198);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.MaxLength = 32767;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Accessories Name";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(488, 44);
            this.txtName.Style = MetroFramework.MetroColorStyle.White;
            this.txtName.TabIndex = 0;
            this.txtName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.UseCustomBackColor = true;
            this.txtName.UseCustomForeColor = true;
            this.txtName.UseSelectable = true;
            this.txtName.UseStyleColors = true;
            this.txtName.WaterMark = "Accessories Name";
            this.txtName.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtName.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // UCAdminCRUDAccessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRegisterPatient);
            this.Name = "UCAdminCRUDAccessories";
            this.Size = new System.Drawing.Size(1736, 1271);
            this.pnlRegisterPatient.ResumeLayout(false);
            this.pnlAdminAddAccessories.ResumeLayout(false);
            this.pnlGrideViewPatient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAccessories)).EndInit();
            this.pnlAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnSearch;
        private CuoreUI.Controls.cuiTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroPanel pnlRegisterPatient;
        private CuoreUI.Controls.cuiGradientPanel pnlAdminAddAccessories;
        private MetroFramework.Controls.MetroPanel pnlGrideViewPatient;
        private MetroFramework.Controls.MetroGrid dvgAccessories;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessoriesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessoriesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private CuoreUI.Controls.cuiPanel pnlAdd;
        private MetroFramework.Controls.MetroTextBox txtId;
        private System.Windows.Forms.Button btnSave;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroTextBox txtName;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}
