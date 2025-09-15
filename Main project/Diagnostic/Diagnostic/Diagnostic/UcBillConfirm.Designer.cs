namespace Diagnostic
{
    partial class UcBillConfirm
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
            this.pnlSelecteditem = new CuoreUI.Controls.cuiPanel();
            this.lvSelectedItemView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemsprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lbltotaltaka = new System.Windows.Forms.Label();
            this.cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cuiGradientPanel1 = new CuoreUI.Controls.cuiGradientPanel();
            this.pnlSelecteditem.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.cuiGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSelecteditem
            // 
            this.pnlSelecteditem.Controls.Add(this.lvSelectedItemView);
            this.pnlSelecteditem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelecteditem.Location = new System.Drawing.Point(0, 0);
            this.pnlSelecteditem.Name = "pnlSelecteditem";
            this.pnlSelecteditem.OutlineThickness = 1F;
            this.pnlSelecteditem.PanelColor = System.Drawing.Color.White;
            this.pnlSelecteditem.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.pnlSelecteditem.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlSelecteditem.Size = new System.Drawing.Size(938, 729);
            this.pnlSelecteditem.TabIndex = 2;
            // 
            // lvSelectedItemView
            // 
            this.lvSelectedItemView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name,
            this.Count,
            this.itemsprice});
            this.lvSelectedItemView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSelectedItemView.HideSelection = false;
            this.lvSelectedItemView.Location = new System.Drawing.Point(0, 0);
            this.lvSelectedItemView.Name = "lvSelectedItemView";
            this.lvSelectedItemView.Size = new System.Drawing.Size(938, 729);
            this.lvSelectedItemView.TabIndex = 0;
            this.lvSelectedItemView.UseCompatibleStateImageBehavior = false;
            this.lvSelectedItemView.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 150;
            // 
            // Count
            // 
            this.Count.DisplayIndex = 3;
            this.Count.Text = "Quantity";
            this.Count.Width = 100;
            // 
            // itemsprice
            // 
            this.itemsprice.DisplayIndex = 2;
            this.itemsprice.Text = "Price";
            this.itemsprice.Width = 100;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pnlSelecteditem);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(47, 93);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(938, 729);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(90, 926);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(129, 31);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "Discount";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(90, 863);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(187, 31);
            this.lblTotalCost.TabIndex = 5;
            this.lblTotalCost.Text = "Total Amount";
            // 
            // lbltotaltaka
            // 
            this.lbltotaltaka.AutoSize = true;
            this.lbltotaltaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaltaka.Location = new System.Drawing.Point(666, 854);
            this.lbltotaltaka.Name = "lbltotaltaka";
            this.lbltotaltaka.Size = new System.Drawing.Size(30, 31);
            this.lbltotaltaka.TabIndex = 7;
            this.lbltotaltaka.Text = "0";
            // 
            // cuiTextBox1
            // 
            this.cuiTextBox1.BackgroundColor = System.Drawing.Color.White;
            this.cuiTextBox1.Content = "";
            this.cuiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTextBox1.FocusBackgroundColor = System.Drawing.Color.White;
            this.cuiTextBox1.FocusImageTint = System.Drawing.Color.White;
            this.cuiTextBox1.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.cuiTextBox1.Image = null;
            this.cuiTextBox1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiTextBox1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiTextBox1.Location = new System.Drawing.Point(632, 912);
            this.cuiTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.cuiTextBox1.Multiline = false;
            this.cuiTextBox1.Name = "cuiTextBox1";
            this.cuiTextBox1.NormalImageTint = System.Drawing.Color.White;
            this.cuiTextBox1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiTextBox1.Padding = new System.Windows.Forms.Padding(29, 8, 29, 0);
            this.cuiTextBox1.PasswordChar = false;
            this.cuiTextBox1.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.cuiTextBox1.PlaceholderText = "";
            this.cuiTextBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiTextBox1.Size = new System.Drawing.Size(75, 45);
            this.cuiTextBox1.TabIndex = 8;
            this.cuiTextBox1.TextOffset = new System.Drawing.Size(0, 0);
            this.cuiTextBox1.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 1012);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Net Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(717, 919);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(666, 999);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "0";
            // 
            // cuiGradientPanel1
            // 
            this.cuiGradientPanel1.Controls.Add(this.metroPanel1);
            this.cuiGradientPanel1.Controls.Add(this.label4);
            this.cuiGradientPanel1.Controls.Add(this.lblDiscount);
            this.cuiGradientPanel1.Controls.Add(this.label3);
            this.cuiGradientPanel1.Controls.Add(this.lblTotalCost);
            this.cuiGradientPanel1.Controls.Add(this.label2);
            this.cuiGradientPanel1.Controls.Add(this.lbltotaltaka);
            this.cuiGradientPanel1.Controls.Add(this.cuiTextBox1);
            this.cuiGradientPanel1.GradientAngle = 0F;
            this.cuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.cuiGradientPanel1.Name = "cuiGradientPanel1";
            this.cuiGradientPanel1.OutlineThickness = 1F;
            this.cuiGradientPanel1.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cuiGradientPanel1.PanelColor2 = System.Drawing.Color.Transparent;
            this.cuiGradientPanel1.PanelOutlineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiGradientPanel1.PanelOutlineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiGradientPanel1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientPanel1.Size = new System.Drawing.Size(1736, 1271);
            this.cuiGradientPanel1.TabIndex = 12;
            // 
            // UcBillConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cuiGradientPanel1);
         //   this.Name = "UcBillConfirm";
            this.Size = new System.Drawing.Size(1736, 1271);
            this.pnlSelecteditem.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.cuiGradientPanel1.ResumeLayout(false);
            this.cuiGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel pnlSelecteditem;
        private System.Windows.Forms.ListView lvSelectedItemView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.ColumnHeader itemsprice;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lbltotaltaka;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel1;
    }
}
