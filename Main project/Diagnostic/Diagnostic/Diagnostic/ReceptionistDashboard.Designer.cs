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
            this.pnlforUcReceptionist = new System.Windows.Forms.Panel();
            this.lblWelcomeName = new System.Windows.Forms.Label();
            this.cuiGradientPanel2 = new CuoreUI.Controls.cuiGradientPanel();
            this.btnBilling = new System.Windows.Forms.Label();
            this.cuiGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccessories
            // 
            this.lblAccessories.AutoSize = true;
            this.lblAccessories.BackColor = System.Drawing.Color.Transparent;
            this.lblAccessories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAccessories.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessories.ForeColor = System.Drawing.Color.Black;
            this.lblAccessories.Location = new System.Drawing.Point(48, 523);
            this.lblAccessories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccessories.Name = "lblAccessories";
            this.lblAccessories.Size = new System.Drawing.Size(268, 51);
            this.lblAccessories.TabIndex = 3;
            this.lblAccessories.Text = "Accessories";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Chocolate;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(60, 773);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(166, 63);
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
            this.lblPatientReg.ForeColor = System.Drawing.Color.Black;
            this.lblPatientReg.Location = new System.Drawing.Point(48, 327);
            this.lblPatientReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientReg.Name = "lblPatientReg";
            this.lblPatientReg.Size = new System.Drawing.Size(345, 51);
            this.lblPatientReg.TabIndex = 2;
            this.lblPatientReg.Text = "Register Patient";
            this.lblPatientReg.Click += new System.EventHandler(this.lblPatientReg_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.BackColor = System.Drawing.Color.Transparent;
            this.lblTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.ForeColor = System.Drawing.Color.Black;
            this.lblTest.Location = new System.Drawing.Point(48, 431);
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
            this.lblDashBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashBoard.ForeColor = System.Drawing.Color.Black;
            this.lblDashBoard.Location = new System.Drawing.Point(56, 231);
            this.lblDashBoard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDashBoard.Name = "lblDashBoard";
            this.lblDashBoard.Size = new System.Drawing.Size(261, 53);
            this.lblDashBoard.TabIndex = 0;
            this.lblDashBoard.Text = "Dash Board";
            this.lblDashBoard.Click += new System.EventHandler(this.lblDashBoard_Click);
            // 
            // pnlforUcReceptionist
            // 
            this.pnlforUcReceptionist.Location = new System.Drawing.Point(454, 0);
            this.pnlforUcReceptionist.Margin = new System.Windows.Forms.Padding(4);
            this.pnlforUcReceptionist.Name = "pnlforUcReceptionist";
            this.pnlforUcReceptionist.Size = new System.Drawing.Size(1736, 1271);
            this.pnlforUcReceptionist.TabIndex = 9;
            this.pnlforUcReceptionist.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblWelcomeName
            // 
            this.lblWelcomeName.AutoSize = true;
            this.lblWelcomeName.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeName.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeName.Location = new System.Drawing.Point(30, 77);
            this.lblWelcomeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcomeName.Name = "lblWelcomeName";
            this.lblWelcomeName.Size = new System.Drawing.Size(235, 59);
            this.lblWelcomeName.TabIndex = 10;
            this.lblWelcomeName.Text = "WELCOME";
            this.lblWelcomeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cuiGradientPanel2
            // 
            this.cuiGradientPanel2.Controls.Add(this.btnBilling);
            this.cuiGradientPanel2.Controls.Add(this.lblWelcomeName);
            this.cuiGradientPanel2.Controls.Add(this.lblAccessories);
            this.cuiGradientPanel2.Controls.Add(this.lblPatientReg);
            this.cuiGradientPanel2.Controls.Add(this.lblDashBoard);
            this.cuiGradientPanel2.Controls.Add(this.lblTest);
            this.cuiGradientPanel2.Controls.Add(this.btnLogOut);
            this.cuiGradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiGradientPanel2.GradientAngle = 0F;
            this.cuiGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.cuiGradientPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.cuiGradientPanel2.Name = "cuiGradientPanel2";
            this.cuiGradientPanel2.OutlineThickness = 1F;
            this.cuiGradientPanel2.PanelColor1 = System.Drawing.Color.CornflowerBlue;
            this.cuiGradientPanel2.PanelColor2 = System.Drawing.Color.Transparent;
            this.cuiGradientPanel2.PanelOutlineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cuiGradientPanel2.PanelOutlineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiGradientPanel2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientPanel2.Size = new System.Drawing.Size(456, 1271);
            this.cuiGradientPanel2.TabIndex = 12;
            // 
            // btnBilling
            // 
            this.btnBilling.AutoSize = true;
            this.btnBilling.BackColor = System.Drawing.Color.Transparent;
            this.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilling.ForeColor = System.Drawing.Color.Black;
            this.btnBilling.Location = new System.Drawing.Point(51, 628);
            this.btnBilling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(146, 51);
            this.btnBilling.TabIndex = 11;
            this.btnBilling.Text = "Billing";
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // ReceptionistDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2196, 1271);
            this.Controls.Add(this.cuiGradientPanel2);
            this.Controls.Add(this.pnlforUcReceptionist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReceptionistDashboard";
            this.Text = "ReceptionistDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReceptionistDashboard_FormClosed);
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
        private System.Windows.Forms.Panel pnlforUcReceptionist;
        private System.Windows.Forms.Label lblWelcomeName;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel2;
        private System.Windows.Forms.Label btnBilling;
    }
}