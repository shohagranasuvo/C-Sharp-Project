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
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lbltotaltaka = new System.Windows.Forms.Label();
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
            this.pnlSelecteditem.Size = new System.Drawing.Size(938, 730);
            this.pnlSelecteditem.TabIndex = 2;
            // 
            // lvSelectedItemView
            // 
            this.lvSelectedItemView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lvSelectedItemView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name,
            this.Count,
            this.itemsprice,
            this.Total});
            this.lvSelectedItemView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSelectedItemView.HideSelection = false;
            this.lvSelectedItemView.Location = new System.Drawing.Point(0, 0);
            this.lvSelectedItemView.Name = "lvSelectedItemView";
            this.lvSelectedItemView.Size = new System.Drawing.Size(938, 730);
            this.lvSelectedItemView.TabIndex = 0;
            this.lvSelectedItemView.UseCompatibleStateImageBehavior = false;
            this.lvSelectedItemView.View = System.Windows.Forms.View.Details;
            this.lvSelectedItemView.SelectedIndexChanged += new System.EventHandler(this.lvSelectedItemView_SelectedIndexChanged);
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
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 80;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pnlSelecteditem);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 9;
            this.metroPanel1.Location = new System.Drawing.Point(46, 94);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(938, 730);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(92, 855);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(187, 31);
            this.lblTotalCost.TabIndex = 5;
            this.lblTotalCost.Text = "Total Amount";
            // 
            // lbltotaltaka
            // 
            this.lbltotaltaka.AutoSize = true;
            this.lbltotaltaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaltaka.Location = new System.Drawing.Point(666, 855);
            this.lbltotaltaka.Name = "lbltotaltaka";
            this.lbltotaltaka.Size = new System.Drawing.Size(30, 31);
            this.lbltotaltaka.TabIndex = 7;
            this.lbltotaltaka.Text = "0";
            this.lbltotaltaka.Click += new System.EventHandler(this.lbltotaltaka_Click);
            // 
            // cuiGradientPanel1
            // 
            this.cuiGradientPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cuiGradientPanel1.Controls.Add(this.metroPanel1);
            this.cuiGradientPanel1.Controls.Add(this.lblTotalCost);
            this.cuiGradientPanel1.Controls.Add(this.lbltotaltaka);
            this.cuiGradientPanel1.GradientAngle = 0F;
            this.cuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.cuiGradientPanel1.Name = "cuiGradientPanel1";
            this.cuiGradientPanel1.OutlineThickness = 1F;
            this.cuiGradientPanel1.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cuiGradientPanel1.PanelColor2 = System.Drawing.Color.Transparent;
            this.cuiGradientPanel1.PanelOutlineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiGradientPanel1.PanelOutlineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiGradientPanel1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientPanel1.Size = new System.Drawing.Size(1736, 1270);
            this.cuiGradientPanel1.TabIndex = 12;
            // 
            // UcBillConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cuiGradientPanel1);
           // this.Name = "UcBillConfirm";
            this.Size = new System.Drawing.Size(1736, 1270);
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
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lbltotaltaka;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel1;
        private System.Windows.Forms.ColumnHeader Total;
    }
}
