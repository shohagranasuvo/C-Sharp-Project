namespace Diagnostic
{
    partial class UcReceptionistOperationCRUDE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPatientSearch = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnAddpatient = new MetroFramework.Controls.MetroButton();
            this.tableAdapterManager1 = new Diagnostic.DiagnosticDataSetTableAdapters.TableAdapterManager();
            this.accessoriesTableAdapter1 = new Diagnostic.DiagnosticDataSetTableAdapters.AccessoriesTableAdapter();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosticDataSet2 = new Diagnostic.DiagnosticDataSet2();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.adminTableAdapter = new Diagnostic.DiagnosticDataSet2TableAdapters.AdminTableAdapter();
            this.dvgReceptionistTable = new MetroFramework.Controls.MetroGrid();
            this.txtSearch = new CuoreUI.Controls.cuiTextBox();
            this.pnlAdminTable = new MetroFramework.Controls.MetroPanel();
            this.btnUpdatePatient = new MetroFramework.Controls.MetroButton();
            this.pnlRegisterPatientForm = new CuoreUI.Controls.cuiPanel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtSalary = new MetroFramework.Controls.MetroTextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnRegisterAndSave = new System.Windows.Forms.Button();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.btnGender = new CuoreUI.Controls.cuiLabel();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtboxname = new MetroFramework.Controls.MetroTextBox();
            this.AdminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgReceptionistTable)).BeginInit();
            this.pnlAdminTable.SuspendLayout();
            this.pnlRegisterPatientForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPatientSearch.BackgroundImage = global::Diagnostic.Properties.Resources.Search;
            this.btnPatientSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPatientSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientSearch.ForeColor = System.Drawing.Color.Black;
            this.btnPatientSearch.Location = new System.Drawing.Point(825, 12);
            this.btnPatientSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(24, 21);
            this.btnPatientSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPatientSearch.TabIndex = 38;
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
            this.btnEdit.Location = new System.Drawing.Point(94, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 45);
            this.btnEdit.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnEdit.TabIndex = 36;
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
            this.btnDelete.Location = new System.Drawing.Point(180, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 45);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseCustomForeColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddpatient
            // 
            this.btnAddpatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddpatient.BackgroundImage = global::Diagnostic.Properties.Resources.add_user;
            this.btnAddpatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddpatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddpatient.ForeColor = System.Drawing.Color.Black;
            this.btnAddpatient.Location = new System.Drawing.Point(10, 4);
            this.btnAddpatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddpatient.Name = "btnAddpatient";
            this.btnAddpatient.Size = new System.Drawing.Size(64, 45);
            this.btnAddpatient.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAddpatient.TabIndex = 33;
            this.btnAddpatient.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAddpatient.UseCustomBackColor = true;
            this.btnAddpatient.UseCustomForeColor = true;
            this.btnAddpatient.UseSelectable = true;
            this.btnAddpatient.Click += new System.EventHandler(this.btnAddpatient_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AccessoriesTableAdapter = this.accessoriesTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Diagnostic.DiagnosticDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // accessoriesTableAdapter1
            // 
            this.accessoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.diagnosticDataSet2;
            // 
            // diagnosticDataSet2
            // 
            this.diagnosticDataSet2.DataSetName = "DiagnosticDataSet2";
            this.diagnosticDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // dvgReceptionistTable
            // 
            this.dvgReceptionistTable.AllowUserToAddRows = false;
            this.dvgReceptionistTable.AllowUserToDeleteRows = false;
            this.dvgReceptionistTable.AllowUserToResizeRows = false;
            this.dvgReceptionistTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgReceptionistTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgReceptionistTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgReceptionistTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgReceptionistTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dvgReceptionistTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgReceptionistTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdminId,
            this.FullName,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgReceptionistTable.DefaultCellStyle = dataGridViewCellStyle20;
            this.dvgReceptionistTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgReceptionistTable.EnableHeadersVisualStyles = false;
            this.dvgReceptionistTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dvgReceptionistTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgReceptionistTable.Location = new System.Drawing.Point(0, 0);
            this.dvgReceptionistTable.Name = "dvgReceptionistTable";
            this.dvgReceptionistTable.ReadOnly = true;
            this.dvgReceptionistTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgReceptionistTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dvgReceptionistTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgReceptionistTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgReceptionistTable.Size = new System.Drawing.Size(577, 569);
            this.dvgReceptionistTable.TabIndex = 5;
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
            this.txtSearch.Location = new System.Drawing.Point(573, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.NormalImageTint = System.Drawing.Color.White;
            this.txtSearch.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtSearch.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.Rounding = new System.Windows.Forms.Padding(20);
            this.txtSearch.Size = new System.Drawing.Size(288, 33);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.TextOffset = new System.Drawing.Size(0, 0);
            this.txtSearch.UnderlinedStyle = false;
            // 
            // pnlAdminTable
            // 
            this.pnlAdminTable.Controls.Add(this.dvgReceptionistTable);
            this.pnlAdminTable.HorizontalScrollbarBarColor = true;
            this.pnlAdminTable.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAdminTable.HorizontalScrollbarSize = 10;
            this.pnlAdminTable.Location = new System.Drawing.Point(7, 88);
            this.pnlAdminTable.Name = "pnlAdminTable";
            this.pnlAdminTable.Size = new System.Drawing.Size(577, 569);
            this.pnlAdminTable.TabIndex = 32;
            this.pnlAdminTable.VerticalScrollbarBarColor = true;
            this.pnlAdminTable.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAdminTable.VerticalScrollbarSize = 10;
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdatePatient.BackgroundImage = global::Diagnostic.Properties.Resources.updated_User;
            this.btnUpdatePatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdatePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePatient.ForeColor = System.Drawing.Color.Black;
            this.btnUpdatePatient.Location = new System.Drawing.Point(266, 4);
            this.btnUpdatePatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(54, 45);
            this.btnUpdatePatient.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnUpdatePatient.TabIndex = 34;
            this.btnUpdatePatient.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnUpdatePatient.UseCustomBackColor = true;
            this.btnUpdatePatient.UseCustomForeColor = true;
            this.btnUpdatePatient.UseSelectable = true;
            this.btnUpdatePatient.Click += new System.EventHandler(this.btnUpdatePatient_Click);
            // 
            // pnlRegisterPatientForm
            // 
            this.pnlRegisterPatientForm.BackColor = System.Drawing.Color.LightBlue;
            this.pnlRegisterPatientForm.Controls.Add(this.txtPassword);
            this.pnlRegisterPatientForm.Controls.Add(this.txtSalary);
            this.pnlRegisterPatientForm.Controls.Add(this.dtpDateOfBirth);
            this.pnlRegisterPatientForm.Controls.Add(this.btnRegisterAndSave);
            this.pnlRegisterPatientForm.Controls.Add(this.cuiLabel2);
            this.pnlRegisterPatientForm.Controls.Add(this.cuiLabel1);
            this.pnlRegisterPatientForm.Controls.Add(this.btnGender);
            this.pnlRegisterPatientForm.Controls.Add(this.rbtnFemale);
            this.pnlRegisterPatientForm.Controls.Add(this.rbtnMale);
            this.pnlRegisterPatientForm.Controls.Add(this.txtAddress);
            this.pnlRegisterPatientForm.Controls.Add(this.txtEmail);
            this.pnlRegisterPatientForm.Controls.Add(this.txtPhone);
            this.pnlRegisterPatientForm.Controls.Add(this.txtboxname);
            this.pnlRegisterPatientForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRegisterPatientForm.Location = new System.Drawing.Point(589, 69);
            this.pnlRegisterPatientForm.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRegisterPatientForm.Name = "pnlRegisterPatientForm";
            this.pnlRegisterPatientForm.OutlineThickness = 1F;
            this.pnlRegisterPatientForm.PanelColor = System.Drawing.Color.LightBlue;
            this.pnlRegisterPatientForm.PanelOutlineColor = System.Drawing.Color.LightBlue;
            this.pnlRegisterPatientForm.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlRegisterPatientForm.Size = new System.Drawing.Size(272, 460);
            this.pnlRegisterPatientForm.TabIndex = 39;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtPassword.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(16, 87);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(244, 23);
            this.txtPassword.Style = MetroFramework.MetroColorStyle.White;
            this.txtPassword.TabIndex = 96;
            this.txtPassword.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.UseCustomBackColor = true;
            this.txtPassword.UseCustomForeColor = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseStyleColors = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.Black;
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txtSalary.CustomButton.Image = null;
            this.txtSalary.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtSalary.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalary.CustomButton.Name = "";
            this.txtSalary.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSalary.CustomButton.TabIndex = 1;
            this.txtSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalary.CustomButton.UseSelectable = true;
            this.txtSalary.CustomButton.Visible = false;
            this.txtSalary.Lines = new string[0];
            this.txtSalary.Location = new System.Drawing.Point(16, 275);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(0);
            this.txtSalary.MaxLength = 32767;
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.PromptText = "Salary";
            this.txtSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalary.SelectedText = "";
            this.txtSalary.SelectionLength = 0;
            this.txtSalary.SelectionStart = 0;
            this.txtSalary.ShortcutsEnabled = true;
            this.txtSalary.Size = new System.Drawing.Size(244, 23);
            this.txtSalary.Style = MetroFramework.MetroColorStyle.White;
            this.txtSalary.TabIndex = 95;
            this.txtSalary.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalary.UseCustomBackColor = true;
            this.txtSalary.UseCustomForeColor = true;
            this.txtSalary.UseSelectable = true;
            this.txtSalary.UseStyleColors = true;
            this.txtSalary.WaterMark = "Salary";
            this.txtSalary.WaterMarkColor = System.Drawing.Color.Black;
            this.txtSalary.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "yyyy-MM-dd";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(94, 356);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(144, 19);
            this.dtpDateOfBirth.TabIndex = 94;
            // 
            // btnRegisterAndSave
            // 
            this.btnRegisterAndSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegisterAndSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterAndSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegisterAndSave.Location = new System.Drawing.Point(80, 397);
            this.btnRegisterAndSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterAndSave.Name = "btnRegisterAndSave";
            this.btnRegisterAndSave.Size = new System.Drawing.Size(106, 31);
            this.btnRegisterAndSave.TabIndex = 10;
            this.btnRegisterAndSave.Text = "Save";
            this.btnRegisterAndSave.UseVisualStyleBackColor = false;
            this.btnRegisterAndSave.Click += new System.EventHandler(this.btnRegisterAndSave_Click);
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "Date\\ Of\\ Birth";
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel2.Location = new System.Drawing.Point(17, 359);
            this.cuiLabel2.Margin = new System.Windows.Forms.Padding(6);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(85, 16);
            this.cuiLabel2.TabIndex = 8;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Receptionist\\ Info";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(38, 8);
            this.cuiLabel1.Margin = new System.Windows.Forms.Padding(6);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(195, 21);
            this.cuiLabel1.TabIndex = 7;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnGender
            // 
            this.btnGender.Content = "Gender";
            this.btnGender.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.btnGender.Location = new System.Drawing.Point(16, 315);
            this.btnGender.Margin = new System.Windows.Forms.Padding(6);
            this.btnGender.Name = "btnGender";
            this.btnGender.Size = new System.Drawing.Size(62, 19);
            this.btnGender.TabIndex = 6;
            this.btnGender.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(173, 315);
            this.rbtnFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(65, 17);
            this.rbtnFemale.TabIndex = 5;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(92, 315);
            this.rbtnMale.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(52, 17);
            this.rbtnMale.TabIndex = 4;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male\r\n";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtAddress.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(16, 186);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PromptText = "Address";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(244, 23);
            this.txtAddress.Style = MetroFramework.MetroColorStyle.White;
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.UseCustomBackColor = true;
            this.txtAddress.UseCustomForeColor = true;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.UseStyleColors = true;
            this.txtAddress.WaterMark = "Address";
            this.txtAddress.WaterMarkColor = System.Drawing.Color.Black;
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtEmail.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(16, 234);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Email";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(244, 23);
            this.txtEmail.Style = MetroFramework.MetroColorStyle.White;
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.UseCustomBackColor = true;
            this.txtEmail.UseCustomForeColor = true;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.UseStyleColors = true;
            this.txtEmail.WaterMark = "Email";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.Black;
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtPhone.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(16, 137);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(0);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PromptText = "Phone";
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(244, 23);
            this.txtPhone.Style = MetroFramework.MetroColorStyle.White;
            this.txtPhone.TabIndex = 1;
            this.txtPhone.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.UseCustomBackColor = true;
            this.txtPhone.UseCustomForeColor = true;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.UseStyleColors = true;
            this.txtPhone.WaterMark = "Phone";
            this.txtPhone.WaterMarkColor = System.Drawing.Color.Black;
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtboxname
            // 
            this.txtboxname.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txtboxname.CustomButton.Image = null;
            this.txtboxname.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtboxname.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxname.CustomButton.Name = "";
            this.txtboxname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxname.CustomButton.TabIndex = 1;
            this.txtboxname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxname.CustomButton.UseSelectable = true;
            this.txtboxname.CustomButton.Visible = false;
            this.txtboxname.Lines = new string[0];
            this.txtboxname.Location = new System.Drawing.Point(16, 40);
            this.txtboxname.Margin = new System.Windows.Forms.Padding(0);
            this.txtboxname.MaxLength = 32767;
            this.txtboxname.Multiline = true;
            this.txtboxname.Name = "txtboxname";
            this.txtboxname.PasswordChar = '\0';
            this.txtboxname.PromptText = "Patient Name";
            this.txtboxname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxname.SelectedText = "";
            this.txtboxname.SelectionLength = 0;
            this.txtboxname.SelectionStart = 0;
            this.txtboxname.ShortcutsEnabled = true;
            this.txtboxname.Size = new System.Drawing.Size(244, 23);
            this.txtboxname.Style = MetroFramework.MetroColorStyle.White;
            this.txtboxname.TabIndex = 0;
            this.txtboxname.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxname.UseCustomBackColor = true;
            this.txtboxname.UseCustomForeColor = true;
            this.txtboxname.UseSelectable = true;
            this.txtboxname.UseStyleColors = true;
            this.txtboxname.WaterMark = "Patient Name";
            this.txtboxname.WaterMarkColor = System.Drawing.Color.Black;
            this.txtboxname.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // AdminId
            // 
            this.AdminId.DataPropertyName = "receptionistid";
            this.AdminId.HeaderText = "ID";
            this.AdminId.Name = "AdminId";
            this.AdminId.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "Fullname";
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "pass";
            this.Column1.HeaderText = "Password";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "salary";
            this.Column2.HeaderText = "Salary";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "phone";
            this.Column3.HeaderText = "Phone";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Address";
            this.Column4.HeaderText = "Address";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // UcReceptionistOperationCRUDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRegisterPatientForm);
            this.Controls.Add(this.btnPatientSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddpatient);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnlAdminTable);
            this.Controls.Add(this.btnUpdatePatient);
            this.Name = "UcReceptionistOperationCRUDE";
            this.Size = new System.Drawing.Size(868, 661);
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgReceptionistTable)).EndInit();
            this.pnlAdminTable.ResumeLayout(false);
            this.pnlRegisterPatientForm.ResumeLayout(false);
            this.pnlRegisterPatientForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnPatientSearch;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnAddpatient;
        private DiagnosticDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private DiagnosticDataSetTableAdapters.AccessoriesTableAdapter accessoriesTableAdapter1;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private DiagnosticDataSet2 diagnosticDataSet2;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private DiagnosticDataSet2TableAdapters.AdminTableAdapter adminTableAdapter;
        private MetroFramework.Controls.MetroGrid dvgReceptionistTable;
        private CuoreUI.Controls.cuiTextBox txtSearch;
        private MetroFramework.Controls.MetroPanel pnlAdminTable;
        private MetroFramework.Controls.MetroButton btnUpdatePatient;
        private CuoreUI.Controls.cuiPanel pnlRegisterPatientForm;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtSalary;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Button btnRegisterAndSave;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel btnGender;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroTextBox txtboxname;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
