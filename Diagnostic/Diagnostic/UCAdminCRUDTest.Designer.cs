namespace Diagnostic
{
    partial class UCAdminCRUDTest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.txtTestId = new MetroFramework.Controls.MetroTextBox();
            this.btnUpdatePatient = new MetroFramework.Controls.MetroButton();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtDisease = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.pnlAdd = new CuoreUI.Controls.cuiPanel();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.Disease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgTest = new MetroFramework.Controls.MetroGrid();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlGrideViewPatient = new MetroFramework.Controls.MetroPanel();
            this.pnlRegisterPatient = new MetroFramework.Controls.MetroPanel();
            this.pnlAdminAddTest = new CuoreUI.Controls.cuiGradientPanel();
            this.txtSearch = new CuoreUI.Controls.cuiTextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTest)).BeginInit();
            this.pnlGrideViewPatient.SuspendLayout();
            this.pnlRegisterPatient.SuspendLayout();
            this.pnlAdminAddTest.SuspendLayout();
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
            // txtTestId
            // 
            this.txtTestId.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txtTestId.CustomButton.Image = null;
            this.txtTestId.CustomButton.Location = new System.Drawing.Point(446, 2);
            this.txtTestId.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTestId.CustomButton.Name = "";
            this.txtTestId.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtTestId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTestId.CustomButton.TabIndex = 1;
            this.txtTestId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTestId.CustomButton.UseSelectable = true;
            this.txtTestId.CustomButton.Visible = false;
            this.txtTestId.Lines = new string[0];
            this.txtTestId.Location = new System.Drawing.Point(32, 111);
            this.txtTestId.Margin = new System.Windows.Forms.Padding(0);
            this.txtTestId.MaxLength = 32767;
            this.txtTestId.Multiline = true;
            this.txtTestId.Name = "txtTestId";
            this.txtTestId.PasswordChar = '\0';
            this.txtTestId.PromptText = "Test ID";
            this.txtTestId.ReadOnly = true;
            this.txtTestId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTestId.SelectedText = "";
            this.txtTestId.SelectionLength = 0;
            this.txtTestId.SelectionStart = 0;
            this.txtTestId.ShortcutsEnabled = true;
            this.txtTestId.Size = new System.Drawing.Size(488, 44);
            this.txtTestId.Style = MetroFramework.MetroColorStyle.White;
            this.txtTestId.TabIndex = 13;
            this.txtTestId.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTestId.UseCustomBackColor = true;
            this.txtTestId.UseCustomForeColor = true;
            this.txtTestId.UseSelectable = true;
            this.txtTestId.UseStyleColors = true;
            this.txtTestId.WaterMark = "Test ID";
            this.txtTestId.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtTestId.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdatePatient.BackgroundImage = global::Diagnostic.Properties.Resources.updated_User;
            this.btnUpdatePatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdatePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePatient.ForeColor = System.Drawing.Color.Black;
            this.btnUpdatePatient.Location = new System.Drawing.Point(210, 580);
            this.btnUpdatePatient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(108, 86);
            this.btnUpdatePatient.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnUpdatePatient.TabIndex = 12;
            this.btnUpdatePatient.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnUpdatePatient.UseCustomBackColor = true;
            this.btnUpdatePatient.UseCustomForeColor = true;
            this.btnUpdatePatient.UseSelectable = true;
            this.btnUpdatePatient.Click += new System.EventHandler(this.btnUpdatePatient_Click);
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
            // txtDisease
            // 
            this.txtDisease.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txtDisease.CustomButton.Image = null;
            this.txtDisease.CustomButton.Location = new System.Drawing.Point(446, 2);
            this.txtDisease.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDisease.CustomButton.Name = "";
            this.txtDisease.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtDisease.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDisease.CustomButton.TabIndex = 1;
            this.txtDisease.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDisease.CustomButton.UseSelectable = true;
            this.txtDisease.CustomButton.Visible = false;
            this.txtDisease.Lines = new string[0];
            this.txtDisease.Location = new System.Drawing.Point(32, 286);
            this.txtDisease.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisease.MaxLength = 32767;
            this.txtDisease.Multiline = true;
            this.txtDisease.Name = "txtDisease";
            this.txtDisease.PasswordChar = '\0';
            this.txtDisease.PromptText = "Disease";
            this.txtDisease.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDisease.SelectedText = "";
            this.txtDisease.SelectionLength = 0;
            this.txtDisease.SelectionStart = 0;
            this.txtDisease.ShortcutsEnabled = true;
            this.txtDisease.Size = new System.Drawing.Size(488, 44);
            this.txtDisease.Style = MetroFramework.MetroColorStyle.White;
            this.txtDisease.TabIndex = 1;
            this.txtDisease.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDisease.UseCustomBackColor = true;
            this.txtDisease.UseCustomForeColor = true;
            this.txtDisease.UseSelectable = true;
            this.txtDisease.UseStyleColors = true;
            this.txtDisease.WaterMark = "Disease";
            this.txtDisease.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtDisease.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtName.PromptText = "Test Name";
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
            this.txtName.WaterMark = "Test Name";
            this.txtName.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtName.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.LightBlue;
            this.pnlAdd.Controls.Add(this.txtTestId);
            this.pnlAdd.Controls.Add(this.btnAddTest);
            this.pnlAdd.Controls.Add(this.cuiLabel1);
            this.pnlAdd.Controls.Add(this.btnUpdatePatient);
            this.pnlAdd.Controls.Add(this.txtPrice);
            this.pnlAdd.Controls.Add(this.txtDisease);
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
            // btnAddTest
            // 
            this.btnAddTest.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddTest.Location = new System.Drawing.Point(160, 448);
            this.btnAddTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(212, 59);
            this.btnAddTest.TabIndex = 10;
            this.btnAddTest.Text = "<<   SAVE";
            this.btnAddTest.UseVisualStyleBackColor = false;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "ADD\\ TESTS";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(76, 45);
            this.cuiLabel1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(390, 41);
            this.cuiLabel1.TabIndex = 7;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near;
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
            // Disease
            // 
            this.Disease.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Disease.DataPropertyName = "Diseases";
            this.Disease.HeaderText = "Disease";
            this.Disease.MinimumWidth = 6;
            this.Disease.Name = "Disease";
            this.Disease.ReadOnly = true;
            // 
            // TestId
            // 
            this.TestId.DataPropertyName = "TestId";
            this.TestId.HeaderText = "ID";
            this.TestId.MinimumWidth = 6;
            this.TestId.Name = "TestId";
            this.TestId.ReadOnly = true;
            this.TestId.Width = 125;
            // 
            // dvgTest
            // 
            this.dvgTest.AllowUserToAddRows = false;
            this.dvgTest.AllowUserToDeleteRows = false;
            this.dvgTest.AllowUserToResizeRows = false;
            this.dvgTest.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dvgTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgTest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgTest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dvgTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestId,
            this.TestName,
            this.Disease,
            this.Price});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgTest.DefaultCellStyle = dataGridViewCellStyle14;
            this.dvgTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgTest.EnableHeadersVisualStyles = false;
            this.dvgTest.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dvgTest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgTest.Location = new System.Drawing.Point(0, 0);
            this.dvgTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dvgTest.Name = "dvgTest";
            this.dvgTest.ReadOnly = true;
            this.dvgTest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgTest.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dvgTest.RowHeadersWidth = 82;
            this.dvgTest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgTest.RowTemplate.Height = 33;
            this.dvgTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgTest.Size = new System.Drawing.Size(1112, 891);
            this.dvgTest.TabIndex = 17;
            this.dvgTest.DoubleClick += new System.EventHandler(this.dvgTest_DoubleClick);
            // 
            // TestName
            // 
            this.TestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TestName.DataPropertyName = "TestName";
            this.TestName.HeaderText = "Name";
            this.TestName.MinimumWidth = 6;
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            // 
            // pnlGrideViewPatient
            // 
            this.pnlGrideViewPatient.Controls.Add(this.dvgTest);
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
            // pnlRegisterPatient
            // 
            this.pnlRegisterPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.pnlRegisterPatient.Controls.Add(this.pnlAdminAddTest);
            this.pnlRegisterPatient.HorizontalScrollbarBarColor = true;
            this.pnlRegisterPatient.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlRegisterPatient.HorizontalScrollbarSize = 9;
            this.pnlRegisterPatient.Location = new System.Drawing.Point(0, 16);
            this.pnlRegisterPatient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlRegisterPatient.Name = "pnlRegisterPatient";
            this.pnlRegisterPatient.Size = new System.Drawing.Size(1736, 1238);
            this.pnlRegisterPatient.TabIndex = 9;
            this.pnlRegisterPatient.VerticalScrollbarBarColor = true;
            this.pnlRegisterPatient.VerticalScrollbarHighlightOnWheel = false;
            this.pnlRegisterPatient.VerticalScrollbarSize = 10;
            // 
            // pnlAdminAddTest
            // 
            this.pnlAdminAddTest.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlAdminAddTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAdminAddTest.Controls.Add(this.pnlGrideViewPatient);
            this.pnlAdminAddTest.Controls.Add(this.pnlAdd);
            this.pnlAdminAddTest.Controls.Add(this.btnSearch);
            this.pnlAdminAddTest.Controls.Add(this.txtSearch);
            this.pnlAdminAddTest.Controls.Add(this.btnEdit);
            this.pnlAdminAddTest.Controls.Add(this.btnDelete);
            this.pnlAdminAddTest.Controls.Add(this.btnAdd);
            this.pnlAdminAddTest.GradientAngle = 0F;
            this.pnlAdminAddTest.Location = new System.Drawing.Point(4, 3);
            this.pnlAdminAddTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlAdminAddTest.Name = "pnlAdminAddTest";
            this.pnlAdminAddTest.OutlineThickness = 1F;
            this.pnlAdminAddTest.PanelColor1 = System.Drawing.Color.LightSkyBlue;
            this.pnlAdminAddTest.PanelColor2 = System.Drawing.Color.Transparent;
            this.pnlAdminAddTest.PanelOutlineColor1 = System.Drawing.Color.PaleTurquoise;
            this.pnlAdminAddTest.PanelOutlineColor2 = System.Drawing.Color.LightBlue;
            this.pnlAdminAddTest.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlAdminAddTest.Size = new System.Drawing.Size(1732, 1268);
            this.pnlAdminAddTest.TabIndex = 2;
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
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // UCAdminCRUDTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRegisterPatient);
            this.Name = "UCAdminCRUDTest";
            this.Size = new System.Drawing.Size(1736, 1271);
            this.pnlAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgTest)).EndInit();
            this.pnlGrideViewPatient.ResumeLayout(false);
            this.pnlRegisterPatient.ResumeLayout(false);
            this.pnlAdminAddTest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox txtTestId;
        private MetroFramework.Controls.MetroButton btnUpdatePatient;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox txtDisease;
        private MetroFramework.Controls.MetroTextBox txtName;
        private CuoreUI.Controls.cuiPanel pnlAdd;
        private System.Windows.Forms.Button btnAddTest;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private MetroFramework.Controls.MetroButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disease;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestId;
        private MetroFramework.Controls.MetroGrid dvgTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private MetroFramework.Controls.MetroPanel pnlGrideViewPatient;
        private MetroFramework.Controls.MetroPanel pnlRegisterPatient;
        private CuoreUI.Controls.cuiGradientPanel pnlAdminAddTest;
        private CuoreUI.Controls.cuiTextBox txtSearch;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
    }
}
