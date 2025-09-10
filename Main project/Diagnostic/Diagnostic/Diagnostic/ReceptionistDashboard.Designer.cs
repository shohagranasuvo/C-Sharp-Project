namespace Diagnostic
{
    partial class ReceptionistDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAccessories = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblPatientReg = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblDashBoard = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcomeName = new System.Windows.Forms.Label();
            this.pnlDashBoard = new CuoreUI.Controls.cuiGradientPanel();
            this.cuiGradientPanel2 = new CuoreUI.Controls.cuiGradientPanel();
            this.panel1.SuspendLayout();
            this.cuiGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccessories
            // 
            this.lblAccessories.AutoSize = true;
            this.lblAccessories.BackColor = System.Drawing.Color.Transparent;
            this.lblAccessories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAccessories.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessories.ForeColor = System.Drawing.Color.Transparent;
            this.lblAccessories.Location = new System.Drawing.Point(49, 524);
            this.lblAccessories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccessories.Name = "lblAccessories";
            this.lblAccessories.Size = new System.Drawing.Size(268, 51);
            this.lblAccessories.TabIndex = 3;
            this.lblAccessories.Text = "Accessories";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(61, 774);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(166, 64);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblPatientReg
            // 
            this.lblPatientReg.AutoSize = true;
            this.lblPatientReg.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPatientReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientReg.ForeColor = System.Drawing.Color.Transparent;
            this.lblPatientReg.Location = new System.Drawing.Point(49, 327);
            this.lblPatientReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientReg.Name = "lblPatientReg";
            this.lblPatientReg.Size = new System.Drawing.Size(345, 51);
            this.lblPatientReg.TabIndex = 2;
            this.lblPatientReg.Text = "Register Patient";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.BackColor = System.Drawing.Color.Transparent;
            this.lblTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.ForeColor = System.Drawing.Color.Transparent;
            this.lblTest.Location = new System.Drawing.Point(49, 424);
            this.lblTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(133, 51);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "Tests";
            // 
            // lblDashBoard
            // 
            this.lblDashBoard.AutoSize = true;
            this.lblDashBoard.BackColor = System.Drawing.Color.Transparent;
            this.lblDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashBoard.ForeColor = System.Drawing.Color.Transparent;
            this.lblDashBoard.Location = new System.Drawing.Point(49, 223);
            this.lblDashBoard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDashBoard.Name = "lblDashBoard";
            this.lblDashBoard.Size = new System.Drawing.Size(259, 51);
            this.lblDashBoard.TabIndex = 0;
            this.lblDashBoard.Text = "Dash Board";
            this.lblDashBoard.Click += new System.EventHandler(this.lblDashBoard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlDashBoard);
            this.panel1.Controls.Add(this.lblWelcomeName);
            this.panel1.Location = new System.Drawing.Point(454, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 927);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblWelcomeName
            // 
            this.lblWelcomeName.AutoSize = true;
            this.lblWelcomeName.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeName.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeName.Location = new System.Drawing.Point(30, 41);
            this.lblWelcomeName.Name = "lblWelcomeName";
            this.lblWelcomeName.Size = new System.Drawing.Size(235, 59);
            this.lblWelcomeName.TabIndex = 10;
            this.lblWelcomeName.Text = "WELCOME";
            this.lblWelcomeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDashBoard
            // 
            this.pnlDashBoard.GradientAngle = 0F;
            this.pnlDashBoard.Location = new System.Drawing.Point(0, 171);
            this.pnlDashBoard.Name = "pnlDashBoard";
            this.pnlDashBoard.OutlineThickness = 1F;
            this.pnlDashBoard.PanelColor1 = System.Drawing.SystemColors.MenuHighlight;
            this.pnlDashBoard.PanelColor2 = System.Drawing.Color.Transparent;
            this.pnlDashBoard.PanelOutlineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.pnlDashBoard.PanelOutlineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.pnlDashBoard.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlDashBoard.Size = new System.Drawing.Size(1226, 747);
            this.pnlDashBoard.TabIndex = 11;
            // 
            // cuiGradientPanel2
            // 
            this.cuiGradientPanel2.Controls.Add(this.lblAccessories);
            this.cuiGradientPanel2.Controls.Add(this.lblPatientReg);
            this.cuiGradientPanel2.Controls.Add(this.lblDashBoard);
            this.cuiGradientPanel2.Controls.Add(this.lblTest);
            this.cuiGradientPanel2.Controls.Add(this.btnLogOut);
            this.cuiGradientPanel2.GradientAngle = 0F;
            this.cuiGradientPanel2.Location = new System.Drawing.Point(-9, 2);
            this.cuiGradientPanel2.Name = "cuiGradientPanel2";
            this.cuiGradientPanel2.OutlineThickness = 1F;
            this.cuiGradientPanel2.PanelColor1 = System.Drawing.SystemColors.MenuHighlight;
            this.cuiGradientPanel2.PanelColor2 = System.Drawing.Color.Transparent;
            this.cuiGradientPanel2.PanelOutlineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cuiGradientPanel2.PanelOutlineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiGradientPanel2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientPanel2.Size = new System.Drawing.Size(457, 927);
            this.cuiGradientPanel2.TabIndex = 12;
            // 
            // ReceptionistDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1687, 929);
            this.Controls.Add(this.cuiGradientPanel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReceptionistDashboard";
            this.Text = "ReceptionistDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cuiGradientPanel2.ResumeLayout(false);
            this.cuiGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAccessories;
        private System.Windows.Forms.Label lblPatientReg;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblDashBoard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcomeName;
        private CuoreUI.Controls.cuiGradientPanel pnlDashBoard;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel2;
    }
}