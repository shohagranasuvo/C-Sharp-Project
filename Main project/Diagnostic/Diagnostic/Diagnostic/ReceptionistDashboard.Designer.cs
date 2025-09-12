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
            this.pnlDashBoard = new CuoreUI.Controls.cuiGradientPanel();
            this.lblWelcomeName = new System.Windows.Forms.Label();
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
            this.lblAccessories.ForeColor = System.Drawing.Color.Black;
            this.lblAccessories.Location = new System.Drawing.Point(24, 272);
            this.lblAccessories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccessories.Name = "lblAccessories";
            this.lblAccessories.Size = new System.Drawing.Size(141, 26);
            this.lblAccessories.TabIndex = 3;
            this.lblAccessories.Text = "Accessories";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Chocolate;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(30, 402);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(83, 33);
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
            this.lblPatientReg.Location = new System.Drawing.Point(24, 170);
            this.lblPatientReg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientReg.Name = "lblPatientReg";
            this.lblPatientReg.Size = new System.Drawing.Size(183, 26);
            this.lblPatientReg.TabIndex = 2;
            this.lblPatientReg.Text = "Register Patient";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.BackColor = System.Drawing.Color.Transparent;
            this.lblTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.ForeColor = System.Drawing.Color.Black;
            this.lblTest.Location = new System.Drawing.Point(24, 224);
            this.lblTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(69, 26);
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
            this.lblDashBoard.Location = new System.Drawing.Point(28, 120);
            this.lblDashBoard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDashBoard.Name = "lblDashBoard";
            this.lblDashBoard.Size = new System.Drawing.Size(139, 28);
            this.lblDashBoard.TabIndex = 0;
            this.lblDashBoard.Text = "Dash Board";
            this.lblDashBoard.Click += new System.EventHandler(this.lblDashBoard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlDashBoard);
            this.panel1.Controls.Add(this.lblWelcomeName);
            this.panel1.Location = new System.Drawing.Point(227, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 643);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlDashBoard
            // 
            this.pnlDashBoard.GradientAngle = 0F;
            this.pnlDashBoard.Location = new System.Drawing.Point(2, 87);
            this.pnlDashBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDashBoard.Name = "pnlDashBoard";
            this.pnlDashBoard.OutlineThickness = 1F;
            this.pnlDashBoard.PanelColor1 = System.Drawing.Color.SlateGray;
            this.pnlDashBoard.PanelColor2 = System.Drawing.Color.Transparent;
            this.pnlDashBoard.PanelOutlineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.pnlDashBoard.PanelOutlineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.pnlDashBoard.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlDashBoard.Size = new System.Drawing.Size(868, 556);
            this.pnlDashBoard.TabIndex = 11;
            // 
            // lblWelcomeName
            // 
            this.lblWelcomeName.AutoSize = true;
            this.lblWelcomeName.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeName.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeName.Location = new System.Drawing.Point(15, 21);
            this.lblWelcomeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcomeName.Name = "lblWelcomeName";
            this.lblWelcomeName.Size = new System.Drawing.Size(121, 30);
            this.lblWelcomeName.TabIndex = 10;
            this.lblWelcomeName.Text = "WELCOME";
            this.lblWelcomeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cuiGradientPanel2
            // 
            this.cuiGradientPanel2.Controls.Add(this.lblAccessories);
            this.cuiGradientPanel2.Controls.Add(this.lblPatientReg);
            this.cuiGradientPanel2.Controls.Add(this.lblDashBoard);
            this.cuiGradientPanel2.Controls.Add(this.lblTest);
            this.cuiGradientPanel2.Controls.Add(this.btnLogOut);
            this.cuiGradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiGradientPanel2.GradientAngle = 0F;
            this.cuiGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.cuiGradientPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cuiGradientPanel2.Name = "cuiGradientPanel2";
            this.cuiGradientPanel2.OutlineThickness = 1F;
            this.cuiGradientPanel2.PanelColor1 = System.Drawing.Color.DarkSlateGray;
            this.cuiGradientPanel2.PanelColor2 = System.Drawing.Color.Transparent;
            this.cuiGradientPanel2.PanelOutlineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cuiGradientPanel2.PanelOutlineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiGradientPanel2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientPanel2.Size = new System.Drawing.Size(228, 644);
            this.cuiGradientPanel2.TabIndex = 12;
            // 
            // ReceptionistDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1098, 661);
            this.Controls.Add(this.cuiGradientPanel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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