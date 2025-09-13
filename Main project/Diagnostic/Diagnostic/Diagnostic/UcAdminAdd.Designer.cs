namespace Diagnostic
{
    partial class UcAdminAdd
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
            this.tableAdapterManager1 = new Diagnostic.DiagnosticDataSetTableAdapters.TableAdapterManager();
            this.accessoriesTableAdapter1 = new Diagnostic.DiagnosticDataSetTableAdapters.AccessoriesTableAdapter();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.AdminSearchBox = new MetroFramework.Controls.MetroTextBox();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosticDataSet2 = new Diagnostic.DiagnosticDataSet2();
            this.AddNewAdmin = new CuoreUI.Controls.cuiButton();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.adminTableAdapter = new Diagnostic.DiagnosticDataSet2TableAdapters.AdminTableAdapter();
            this.dvgAdminTable = new MetroFramework.Controls.MetroGrid();
            this.pnlAdminTable = new MetroFramework.Controls.MetroPanel();
            this.AdminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAdminTable)).BeginInit();
            this.pnlAdminTable.SuspendLayout();
            this.SuspendLayout();
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
            // cuiPanel1
            // 
            this.cuiPanel1.BackColor = System.Drawing.Color.Gray;
            this.cuiPanel1.Controls.Add(this.cuiButton1);
            this.cuiPanel1.Controls.Add(this.AdminSearchBox);
            this.cuiPanel1.Location = new System.Drawing.Point(3, 22);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.Gray;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.Gray;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel1.Size = new System.Drawing.Size(862, 34);
            this.cuiPanel1.TabIndex = 3;
            // 
            // cuiButton1
            // 
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.Content = "";
            this.cuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton1.ForeColor = System.Drawing.Color.Black;
            this.cuiButton1.HoverBackground = System.Drawing.Color.White;
            this.cuiButton1.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton1.HoverImageTint = System.Drawing.Color.White;
            this.cuiButton1.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Image = null;
            this.cuiButton1.ImageAutoCenter = true;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Location = new System.Drawing.Point(835, 0);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.White;
            this.cuiButton1.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton1.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton1.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.OutlineThickness = 1F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton1.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton1.Size = new System.Drawing.Size(24, 29);
            this.cuiButton1.TabIndex = 2;
            this.cuiButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // AdminSearchBox
            // 
            this.AdminSearchBox.BackColor = System.Drawing.Color.Gray;
            // 
            // 
            // 
            this.AdminSearchBox.CustomButton.Image = null;
            this.AdminSearchBox.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.AdminSearchBox.CustomButton.Name = "";
            this.AdminSearchBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AdminSearchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AdminSearchBox.CustomButton.TabIndex = 1;
            this.AdminSearchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AdminSearchBox.CustomButton.UseSelectable = true;
            this.AdminSearchBox.CustomButton.Visible = false;
            this.AdminSearchBox.Lines = new string[0];
            this.AdminSearchBox.Location = new System.Drawing.Point(663, 3);
            this.AdminSearchBox.MaxLength = 32767;
            this.AdminSearchBox.Name = "AdminSearchBox";
            this.AdminSearchBox.PasswordChar = '\0';
            this.AdminSearchBox.PromptText = "Search Admin";
            this.AdminSearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AdminSearchBox.SelectedText = "";
            this.AdminSearchBox.SelectionLength = 0;
            this.AdminSearchBox.SelectionStart = 0;
            this.AdminSearchBox.ShortcutsEnabled = true;
            this.AdminSearchBox.Size = new System.Drawing.Size(166, 23);
            this.AdminSearchBox.TabIndex = 1;
            this.AdminSearchBox.UseSelectable = true;
            this.AdminSearchBox.WaterMark = "Search Admin";
            this.AdminSearchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AdminSearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // AddNewAdmin
            // 
            this.AddNewAdmin.AccessibleDescription = "";
            this.AddNewAdmin.AccessibleName = "";
            this.AddNewAdmin.CheckButton = false;
            this.AddNewAdmin.Checked = false;
            this.AddNewAdmin.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.AddNewAdmin.CheckedForeColor = System.Drawing.Color.White;
            this.AddNewAdmin.CheckedImageTint = System.Drawing.Color.White;
            this.AddNewAdmin.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.AddNewAdmin.Content = "Add New Admin";
            this.AddNewAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewAdmin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddNewAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.AddNewAdmin.ForeColor = System.Drawing.Color.Black;
            this.AddNewAdmin.HoverBackground = System.Drawing.Color.White;
            this.AddNewAdmin.HoverForeColor = System.Drawing.Color.Black;
            this.AddNewAdmin.HoverImageTint = System.Drawing.Color.White;
            this.AddNewAdmin.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddNewAdmin.Image = null;
            this.AddNewAdmin.ImageAutoCenter = true;
            this.AddNewAdmin.ImageExpand = new System.Drawing.Point(0, 0);
            this.AddNewAdmin.ImageOffset = new System.Drawing.Point(0, 0);
            this.AddNewAdmin.Location = new System.Drawing.Point(723, 54);
            this.AddNewAdmin.Name = "AddNewAdmin";
            this.AddNewAdmin.NormalBackground = System.Drawing.Color.Turquoise;
            this.AddNewAdmin.NormalForeColor = System.Drawing.Color.Black;
            this.AddNewAdmin.NormalImageTint = System.Drawing.Color.White;
            this.AddNewAdmin.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddNewAdmin.OutlineThickness = 1F;
            this.AddNewAdmin.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.AddNewAdmin.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.AddNewAdmin.PressedImageTint = System.Drawing.Color.White;
            this.AddNewAdmin.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddNewAdmin.Rounding = new System.Windows.Forms.Padding(8);
            this.AddNewAdmin.Size = new System.Drawing.Size(145, 32);
            this.AddNewAdmin.TabIndex = 4;
            this.AddNewAdmin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AddNewAdmin.TextOffset = new System.Drawing.Point(0, 0);
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
            this.Modify,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgAdminTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgAdminTable.EnableHeadersVisualStyles = false;
            this.dvgAdminTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dvgAdminTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgAdminTable.Location = new System.Drawing.Point(0, 0);
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
            this.dvgAdminTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgAdminTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgAdminTable.Size = new System.Drawing.Size(865, 354);
            this.dvgAdminTable.TabIndex = 5;
            // 
            // pnlAdminTable
            // 
            this.pnlAdminTable.Controls.Add(this.dvgAdminTable);
            this.pnlAdminTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdminTable.HorizontalScrollbarBarColor = true;
            this.pnlAdminTable.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAdminTable.HorizontalScrollbarSize = 10;
            this.pnlAdminTable.Location = new System.Drawing.Point(0, 145);
            this.pnlAdminTable.Name = "pnlAdminTable";
            this.pnlAdminTable.Size = new System.Drawing.Size(868, 516);
            this.pnlAdminTable.TabIndex = 6;
            this.pnlAdminTable.VerticalScrollbarBarColor = true;
            this.pnlAdminTable.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAdminTable.VerticalScrollbarSize = 10;
            // 
            // AdminId
            // 
            this.AdminId.DataPropertyName = "AdminId";
            this.AdminId.HeaderText = "ID";
            this.AdminId.Name = "AdminId";
            this.AdminId.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Modify
            // 
            this.Modify.HeaderText = "Modify";
            this.Modify.Name = "Modify";
            this.Modify.ReadOnly = true;
            this.Modify.Text = "Modify";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            // 
            // UcAdminAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAdminTable);
            this.Controls.Add(this.cuiPanel1);
            this.Controls.Add(this.AddNewAdmin);
            this.Margin = new System.Windows.Forms.Padding(2);
           
            this.Size = new System.Drawing.Size(868, 661);
            this.Load += new System.EventHandler(this.UcAdminAdd_Load);
            this.cuiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAdminTable)).EndInit();
            this.pnlAdminTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DiagnosticDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private DiagnosticDataSetTableAdapters.AccessoriesTableAdapter accessoriesTableAdapter1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private MetroFramework.Controls.MetroTextBox AdminSearchBox;
        private CuoreUI.Controls.cuiButton AddNewAdmin;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private DiagnosticDataSet2 diagnosticDataSet2;
        private DiagnosticDataSet2TableAdapters.AdminTableAdapter adminTableAdapter;
        private MetroFramework.Controls.MetroGrid dvgAdminTable;
        private MetroFramework.Controls.MetroPanel pnlAdminTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewButtonColumn Modify;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
