using MetroFramework.Controls;
using System.Drawing;

namespace Diagnostic
{
    partial class UcRegisterPatient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlRegisterPatient = new MetroFramework.Controls.MetroPanel();
            this.btnSearch = new CuoreUI.Controls.cuiGradientPanel();
            this.pnlGrideViewPatient = new MetroFramework.Controls.MetroPanel();
            this.dvgpatient = new MetroFramework.Controls.MetroGrid();
            this.pnlRegisterPatientForm = new CuoreUI.Controls.cuiPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.btnGender = new CuoreUI.Controls.cuiLabel();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtboxname = new MetroFramework.Controls.MetroTextBox();
            this.btnPatientSearch = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new CuoreUI.Controls.cuiTextBox();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdatePatient = new MetroFramework.Controls.MetroButton();
            this.btnAddpatient = new MetroFramework.Controls.MetroButton();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRegisterPatient.SuspendLayout();
            this.btnSearch.SuspendLayout();
            this.pnlGrideViewPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgpatient)).BeginInit();
            this.pnlRegisterPatientForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegisterPatient
            // 
            this.pnlRegisterPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.pnlRegisterPatient.Controls.Add(this.btnSearch);
            this.pnlRegisterPatient.HorizontalScrollbarBarColor = true;
            this.pnlRegisterPatient.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlRegisterPatient.HorizontalScrollbarSize = 5;
            this.pnlRegisterPatient.Location = new System.Drawing.Point(0, 0);
            this.pnlRegisterPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRegisterPatient.Name = "pnlRegisterPatient";
            this.pnlRegisterPatient.Size = new System.Drawing.Size(868, 554);
            this.pnlRegisterPatient.TabIndex = 7;
            this.pnlRegisterPatient.VerticalScrollbarBarColor = true;
            this.pnlRegisterPatient.VerticalScrollbarHighlightOnWheel = false;
            this.pnlRegisterPatient.VerticalScrollbarSize = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnSearch.Controls.Add(this.pnlGrideViewPatient);
            this.btnSearch.Controls.Add(this.pnlRegisterPatientForm);
            this.btnSearch.Controls.Add(this.btnPatientSearch);
            this.btnSearch.Controls.Add(this.txtSearch);
            this.btnSearch.Controls.Add(this.btnEdit);
            this.btnSearch.Controls.Add(this.btnDelete);
            this.btnSearch.Controls.Add(this.btnUpdatePatient);
            this.btnSearch.Controls.Add(this.btnAddpatient);
            this.btnSearch.GradientAngle = 0F;
            this.btnSearch.Location = new System.Drawing.Point(2, 2);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OutlineThickness = 1F;
            this.btnSearch.PanelColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.PanelColor2 = System.Drawing.Color.Transparent;
            this.btnSearch.PanelOutlineColor1 = System.Drawing.Color.PaleTurquoise;
            this.btnSearch.PanelOutlineColor2 = System.Drawing.Color.LightBlue;
            this.btnSearch.Rounding = new System.Windows.Forms.Padding(8);
            this.btnSearch.Size = new System.Drawing.Size(868, 556);
            this.btnSearch.TabIndex = 2;
            // 
            // pnlGrideViewPatient
            // 
            this.pnlGrideViewPatient.Controls.Add(this.dvgpatient);
            this.pnlGrideViewPatient.HorizontalScrollbarBarColor = true;
            this.pnlGrideViewPatient.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlGrideViewPatient.HorizontalScrollbarSize = 5;
            this.pnlGrideViewPatient.Location = new System.Drawing.Point(-1, 87);
            this.pnlGrideViewPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlGrideViewPatient.Name = "pnlGrideViewPatient";
            this.pnlGrideViewPatient.Size = new System.Drawing.Size(556, 463);
            this.pnlGrideViewPatient.TabIndex = 19;
            this.pnlGrideViewPatient.VerticalScrollbarBarColor = true;
            this.pnlGrideViewPatient.VerticalScrollbarHighlightOnWheel = false;
            this.pnlGrideViewPatient.VerticalScrollbarSize = 5;
            // 
            // dvgpatient
            // 
            this.dvgpatient.AllowUserToAddRows = false;
            this.dvgpatient.AllowUserToDeleteRows = false;
            this.dvgpatient.AllowUserToResizeRows = false;
            this.dvgpatient.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dvgpatient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgpatient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgpatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgpatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgpatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgpatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgpatient.DefaultCellStyle = dataGridViewCellStyle5;
            this.dvgpatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgpatient.EnableHeadersVisualStyles = false;
            this.dvgpatient.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dvgpatient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgpatient.Location = new System.Drawing.Point(0, 0);
            this.dvgpatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvgpatient.Name = "dvgpatient";
            this.dvgpatient.ReadOnly = true;
            this.dvgpatient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgpatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgpatient.RowHeadersWidth = 82;
            this.dvgpatient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgpatient.RowTemplate.Height = 33;
            this.dvgpatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgpatient.Size = new System.Drawing.Size(556, 463);
            this.dvgpatient.TabIndex = 17;
            // 
            // pnlRegisterPatientForm
            // 
            this.pnlRegisterPatientForm.BackColor = System.Drawing.Color.LightBlue;
            this.pnlRegisterPatientForm.Controls.Add(this.dtpDateOfBirth);
            this.pnlRegisterPatientForm.Controls.Add(this.button1);
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
            this.pnlRegisterPatientForm.Location = new System.Drawing.Point(567, 80);
            this.pnlRegisterPatientForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRegisterPatientForm.Name = "pnlRegisterPatientForm";
            this.pnlRegisterPatientForm.OutlineThickness = 1F;
            this.pnlRegisterPatientForm.PanelColor = System.Drawing.Color.LightBlue;
            this.pnlRegisterPatientForm.PanelOutlineColor = System.Drawing.Color.LightBlue;
            this.pnlRegisterPatientForm.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlRegisterPatientForm.Size = new System.Drawing.Size(288, 460);
            this.pnlRegisterPatientForm.TabIndex = 18;
            this.pnlRegisterPatientForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegisterPatientForm_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(92, 333);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "REGISTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "Date\\ Of\\ Birth";
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel2.Location = new System.Drawing.Point(17, 288);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(85, 16);
            this.cuiLabel2.TabIndex = 8;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel2.Load += new System.EventHandler(this.cuiLabel2_Load);
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "PATIENT\\ FORM";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(38, 8);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(195, 21);
            this.cuiLabel1.TabIndex = 7;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnGender
            // 
            this.btnGender.Content = "Gender";
            this.btnGender.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.btnGender.Location = new System.Drawing.Point(16, 244);
            this.btnGender.Name = "btnGender";
            this.btnGender.Size = new System.Drawing.Size(62, 19);
            this.btnGender.TabIndex = 6;
            this.btnGender.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(173, 244);
            this.rbtnFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.rbtnMale.Location = new System.Drawing.Point(92, 244);
            this.rbtnMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtAddress.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(10, 11);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(16, 194);
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
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtEmail.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(10, 11);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(16, 140);
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
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtPhone.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(10, 11);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(16, 90);
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
            this.txtboxname.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtboxname.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxname.CustomButton.Name = "";
            this.txtboxname.CustomButton.Size = new System.Drawing.Size(10, 11);
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
            // btnPatientSearch
            // 
            this.btnPatientSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPatientSearch.BackgroundImage = global::Diagnostic.Properties.Resources.Search;
            this.btnPatientSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPatientSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientSearch.ForeColor = System.Drawing.Color.Black;
            this.btnPatientSearch.Location = new System.Drawing.Point(824, 19);
            this.btnPatientSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(24, 21);
            this.btnPatientSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPatientSearch.TabIndex = 16;
            this.btnPatientSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnPatientSearch.UseCustomBackColor = true;
            this.btnPatientSearch.UseCustomForeColor = true;
            this.btnPatientSearch.UseSelectable = true;
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
            this.txtSearch.Location = new System.Drawing.Point(575, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextOffset = new System.Drawing.Size(0, 0);
            this.txtSearch.UnderlinedStyle = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEdit.BackgroundImage = global::Diagnostic.Properties.Resources.EditUserNew;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(96, 12);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 45);
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
            this.btnDelete.Location = new System.Drawing.Point(182, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 45);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseCustomForeColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdatePatient.BackgroundImage = global::Diagnostic.Properties.Resources.updated_User;
            this.btnUpdatePatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdatePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePatient.ForeColor = System.Drawing.Color.Black;
            this.btnUpdatePatient.Location = new System.Drawing.Point(268, 12);
            this.btnUpdatePatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(54, 45);
            this.btnUpdatePatient.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnUpdatePatient.TabIndex = 12;
            this.btnUpdatePatient.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnUpdatePatient.UseCustomBackColor = true;
            this.btnUpdatePatient.UseCustomForeColor = true;
            this.btnUpdatePatient.UseSelectable = true;
            this.btnUpdatePatient.Click += new System.EventHandler(this.btnUpdatePatient_Click);
            // 
            // btnAddpatient
            // 
            this.btnAddpatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddpatient.BackgroundImage = global::Diagnostic.Properties.Resources.add_user;
            this.btnAddpatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddpatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddpatient.ForeColor = System.Drawing.Color.Black;
            this.btnAddpatient.Location = new System.Drawing.Point(12, 12);
            this.btnAddpatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddpatient.Name = "btnAddpatient";
            this.btnAddpatient.Size = new System.Drawing.Size(64, 45);
            this.btnAddpatient.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAddpatient.TabIndex = 11;
            this.btnAddpatient.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAddpatient.UseCustomBackColor = true;
            this.btnAddpatient.UseCustomForeColor = true;
            this.btnAddpatient.UseSelectable = true;
            this.btnAddpatient.Click += new System.EventHandler(this.btnAddpatient_Click);
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
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "yyyy-MM-dd";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(94, 285);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(144, 19);
            this.dtpDateOfBirth.TabIndex = 94;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "PatientId";
            this.Column7.FillWeight = 30F;
            this.Column7.HeaderText = "ID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 30;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PatientName";
            this.Column1.HeaderText = "Patient Name";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "phone";
            this.Column2.HeaderText = "Phone";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Gender";
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "Gender";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Address";
            this.Column6.FillWeight = 70F;
            this.Column6.HeaderText = "Address";
            this.Column6.MinimumWidth = 10;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DateOfBirth";
            this.Column5.HeaderText = "Date of Birth";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // UcRegisterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRegisterPatient);
            this.Name = "UcRegisterPatient";
            this.Size = new System.Drawing.Size(868, 556);
            this.pnlRegisterPatient.ResumeLayout(false);
            this.btnSearch.ResumeLayout(false);
            this.pnlGrideViewPatient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgpatient)).EndInit();
            this.pnlRegisterPatientForm.ResumeLayout(false);
            this.pnlRegisterPatientForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroPanel pnlRegisterPatient;
        private CuoreUI.Controls.cuiGradientPanel btnSearch;
        private MetroButton btnEdit;
        private MetroButton btnDelete;
        private MetroButton btnUpdatePatient;
        private MetroButton btnAddpatient;
        private CuoreUI.Controls.cuiTextBox txtSearch;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private MetroGrid dvgpatient;
        private MetroButton btnPatientSearch;
        private CuoreUI.Controls.cuiPanel pnlRegisterPatientForm;
        private MetroContextMenu metroContextMenu1;
        private MetroTextBox txtboxname;
        private MetroTextBox txtAddress;
        private MetroTextBox txtEmail;
        private MetroTextBox txtPhone;
        private CuoreUI.Controls.cuiLabel btnGender;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private System.Windows.Forms.Button button1;
        private MetroPanel pnlGrideViewPatient;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
