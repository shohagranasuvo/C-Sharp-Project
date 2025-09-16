namespace Diagnostic
{
    partial class UcAdminOperationCRUDE
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblAdmin = new CuoreUI.Controls.cuiLabel();
            this.txtAdminName = new MetroFramework.Controls.MetroTextBox();
            this.pnlAdminDataUpdate = new CuoreUI.Controls.cuiPanel();
            this.TxtPass = new MetroFramework.Controls.MetroTextBox();
            this.txtSearch = new CuoreUI.Controls.cuiTextBox();
            this.pnlAdminTable = new MetroFramework.Controls.MetroPanel();
            this.dvgAdminTable = new MetroFramework.Controls.MetroGrid();
            this.AdminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminTableAdapter = new Diagnostic.DiagnosticDataSet2TableAdapters.AdminTableAdapter();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.diagnosticDataSet2 = new Diagnostic.DiagnosticDataSet2();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessoriesTableAdapter1 = new Diagnostic.DiagnosticDataSetTableAdapters.AccessoriesTableAdapter();
            this.tableAdapterManager1 = new Diagnostic.DiagnosticDataSetTableAdapters.TableAdapterManager();
            this.btnPatientSearch = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdatePatient = new MetroFramework.Controls.MetroButton();
            this.btnAddpatient = new MetroFramework.Controls.MetroButton();
            this.pnlAdminDataUpdate.SuspendLayout();
            this.pnlAdminTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAdminTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(152, 263);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(212, 60);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.Content = "Admin\\ Data";
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblAdmin.Location = new System.Drawing.Point(76, 15);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(390, 40);
            this.lblAdmin.TabIndex = 7;
            this.lblAdmin.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtAdminName
            // 
            this.txtAdminName.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txtAdminName.CustomButton.Image = null;
            this.txtAdminName.CustomButton.Location = new System.Drawing.Point(892, 4);
            this.txtAdminName.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdminName.CustomButton.Name = "";
            this.txtAdminName.CustomButton.Size = new System.Drawing.Size(78, 75);
            this.txtAdminName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdminName.CustomButton.TabIndex = 1;
            this.txtAdminName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdminName.CustomButton.UseSelectable = true;
            this.txtAdminName.CustomButton.Visible = false;
            this.txtAdminName.Lines = new string[0];
            this.txtAdminName.Location = new System.Drawing.Point(32, 77);
            this.txtAdminName.Margin = new System.Windows.Forms.Padding(0);
            this.txtAdminName.MaxLength = 32767;
            this.txtAdminName.Multiline = true;
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.PasswordChar = '\0';
            this.txtAdminName.PromptText = "Admin Name";
            this.txtAdminName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdminName.SelectedText = "";
            this.txtAdminName.SelectionLength = 0;
            this.txtAdminName.SelectionStart = 0;
            this.txtAdminName.ShortcutsEnabled = true;
            this.txtAdminName.Size = new System.Drawing.Size(488, 44);
            this.txtAdminName.Style = MetroFramework.MetroColorStyle.White;
            this.txtAdminName.TabIndex = 0;
            this.txtAdminName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdminName.UseCustomBackColor = true;
            this.txtAdminName.UseCustomForeColor = true;
            this.txtAdminName.UseSelectable = true;
            this.txtAdminName.UseStyleColors = true;
            this.txtAdminName.WaterMark = "Admin Name";
            this.txtAdminName.WaterMarkColor = System.Drawing.Color.Black;
            this.txtAdminName.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlAdminDataUpdate
            // 
            this.pnlAdminDataUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.pnlAdminDataUpdate.Controls.Add(this.btnUpdate);
            this.pnlAdminDataUpdate.Controls.Add(this.lblAdmin);
            this.pnlAdminDataUpdate.Controls.Add(this.TxtPass);
            this.pnlAdminDataUpdate.Controls.Add(this.txtAdminName);
            this.pnlAdminDataUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdminDataUpdate.Location = new System.Drawing.Point(1122, 169);
            this.pnlAdminDataUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAdminDataUpdate.Name = "pnlAdminDataUpdate";
            this.pnlAdminDataUpdate.OutlineThickness = 1F;
            this.pnlAdminDataUpdate.PanelColor = System.Drawing.Color.LightBlue;
            this.pnlAdminDataUpdate.PanelOutlineColor = System.Drawing.Color.LightBlue;
            this.pnlAdminDataUpdate.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlAdminDataUpdate.Size = new System.Drawing.Size(576, 373);
            this.pnlAdminDataUpdate.TabIndex = 31;
            // 
            // TxtPass
            // 
            this.TxtPass.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.TxtPass.CustomButton.Image = null;
            this.TxtPass.CustomButton.Location = new System.Drawing.Point(892, 4);
            this.TxtPass.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPass.CustomButton.Name = "";
            this.TxtPass.CustomButton.Size = new System.Drawing.Size(78, 75);
            this.TxtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPass.CustomButton.TabIndex = 1;
            this.TxtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPass.CustomButton.UseSelectable = true;
            this.TxtPass.CustomButton.Visible = false;
            this.TxtPass.Lines = new string[0];
            this.TxtPass.Location = new System.Drawing.Point(32, 173);
            this.TxtPass.Margin = new System.Windows.Forms.Padding(0);
            this.TxtPass.MaxLength = 32767;
            this.TxtPass.Multiline = true;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '\0';
            this.TxtPass.PromptText = "Pass";
            this.TxtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPass.SelectedText = "";
            this.TxtPass.SelectionLength = 0;
            this.TxtPass.SelectionStart = 0;
            this.TxtPass.ShortcutsEnabled = true;
            this.TxtPass.Size = new System.Drawing.Size(488, 44);
            this.TxtPass.Style = MetroFramework.MetroColorStyle.White;
            this.TxtPass.TabIndex = 1;
            this.TxtPass.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPass.UseCustomBackColor = true;
            this.TxtPass.UseCustomForeColor = true;
            this.TxtPass.UseSelectable = true;
            this.TxtPass.UseStyleColors = true;
            this.TxtPass.WaterMark = "Pass";
            this.TxtPass.WaterMarkColor = System.Drawing.Color.Black;
            this.TxtPass.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtSearch.Location = new System.Drawing.Point(1146, 8);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.NormalImageTint = System.Drawing.Color.White;
            this.txtSearch.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtSearch.Padding = new System.Windows.Forms.Padding(29, 17, 29, 0);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.Rounding = new System.Windows.Forms.Padding(20);
            this.txtSearch.Size = new System.Drawing.Size(576, 63);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.TextOffset = new System.Drawing.Size(0, 0);
            this.txtSearch.UnderlinedStyle = false;
            // 
            // pnlAdminTable
            // 
            this.pnlAdminTable.Controls.Add(this.dvgAdminTable);
            this.pnlAdminTable.HorizontalScrollbarBarColor = true;
            this.pnlAdminTable.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAdminTable.HorizontalScrollbarSize = 19;
            this.pnlAdminTable.Location = new System.Drawing.Point(14, 169);
            this.pnlAdminTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlAdminTable.Name = "pnlAdminTable";
            this.pnlAdminTable.Size = new System.Drawing.Size(1078, 1094);
            this.pnlAdminTable.TabIndex = 24;
            this.pnlAdminTable.VerticalScrollbarBarColor = true;
            this.pnlAdminTable.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAdminTable.VerticalScrollbarSize = 20;
            // 
            // dvgAdminTable
            // 
            this.dvgAdminTable.AllowUserToAddRows = false;
            this.dvgAdminTable.AllowUserToDeleteRows = false;
            this.dvgAdminTable.AllowUserToResizeRows = false;
            this.dvgAdminTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgAdminTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgAdminTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgAdminTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgAdminTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgAdminTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAdminTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdminId,
            this.Name,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgAdminTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgAdminTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgAdminTable.EnableHeadersVisualStyles = false;
            this.dvgAdminTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dvgAdminTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgAdminTable.Location = new System.Drawing.Point(0, 0);
            this.dvgAdminTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dvgAdminTable.Name = "dvgAdminTable";
            this.dvgAdminTable.ReadOnly = true;
            this.dvgAdminTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgAdminTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgAdminTable.RowHeadersWidth = 82;
            this.dvgAdminTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgAdminTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgAdminTable.Size = new System.Drawing.Size(1078, 1094);
            this.dvgAdminTable.TabIndex = 5;
            // 
            // AdminId
            // 
            this.AdminId.DataPropertyName = "AdminId";
            this.AdminId.HeaderText = "ID";
            this.AdminId.MinimumWidth = 10;
            this.AdminId.Name = "AdminId";
            this.AdminId.ReadOnly = true;
            this.AdminId.Width = 200;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 10;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 200;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "pass";
            this.Column1.HeaderText = "Password";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // diagnosticDataSet2
            // 
            this.diagnosticDataSet2.DataSetName = "DiagnosticDataSet2";
            this.diagnosticDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.diagnosticDataSet2;
            // 
            // accessoriesTableAdapter1
            // 
            this.accessoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AccessoriesTableAdapter = this.accessoriesTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Diagnostic.DiagnosticDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPatientSearch.BackgroundImage = global::Diagnostic.Properties.Resources.Search;
            this.btnPatientSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPatientSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientSearch.ForeColor = System.Drawing.Color.Black;
            this.btnPatientSearch.Location = new System.Drawing.Point(1650, 23);
            this.btnPatientSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(48, 40);
            this.btnPatientSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPatientSearch.TabIndex = 30;
            this.btnPatientSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnPatientSearch.UseCustomBackColor = true;
            this.btnPatientSearch.UseCustomForeColor = true;
            this.btnPatientSearch.UseSelectable = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEdit.BackgroundImage = global::Diagnostic.Properties.Resources.EditUserNew;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(188, 8);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 87);
            this.btnEdit.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnEdit.TabIndex = 28;
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
            this.btnDelete.Location = new System.Drawing.Point(360, 8);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 87);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDelete.TabIndex = 27;
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
            this.btnUpdatePatient.Location = new System.Drawing.Point(532, 8);
            this.btnUpdatePatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(108, 87);
            this.btnUpdatePatient.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnUpdatePatient.TabIndex = 26;
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
            this.btnAddpatient.Location = new System.Drawing.Point(20, 8);
            this.btnAddpatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddpatient.Name = "btnAddpatient";
            this.btnAddpatient.Size = new System.Drawing.Size(128, 87);
            this.btnAddpatient.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAddpatient.TabIndex = 25;
            this.btnAddpatient.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAddpatient.UseCustomBackColor = true;
            this.btnAddpatient.UseCustomForeColor = true;
            this.btnAddpatient.UseSelectable = true;
            // 
            // UcAdminOperationCRUDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAdminDataUpdate);
            this.Controls.Add(this.btnPatientSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdatePatient);
            this.Controls.Add(this.btnAddpatient);
            this.Controls.Add(this.pnlAdminTable);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
          //  this.Name = "UcAdminOperationCRUDE";
            this.Size = new System.Drawing.Size(1736, 1271);
            this.pnlAdminDataUpdate.ResumeLayout(false);
            this.pnlAdminTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAdminTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private CuoreUI.Controls.cuiLabel lblAdmin;
        private MetroFramework.Controls.MetroTextBox txtAdminName;
        private CuoreUI.Controls.cuiPanel pnlAdminDataUpdate;
        private MetroFramework.Controls.MetroTextBox TxtPass;
        private MetroFramework.Controls.MetroButton btnPatientSearch;
        private CuoreUI.Controls.cuiTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnUpdatePatient;
        private MetroFramework.Controls.MetroButton btnAddpatient;
        private MetroFramework.Controls.MetroPanel pnlAdminTable;
        private DiagnosticDataSet2TableAdapters.AdminTableAdapter adminTableAdapter;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private DiagnosticDataSet2 diagnosticDataSet2;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private DiagnosticDataSetTableAdapters.AccessoriesTableAdapter accessoriesTableAdapter1;
        private DiagnosticDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private MetroFramework.Controls.MetroGrid dvgAdminTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
