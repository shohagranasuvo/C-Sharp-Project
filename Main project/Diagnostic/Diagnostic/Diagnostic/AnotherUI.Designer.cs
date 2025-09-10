namespace Diagnostic
{
    partial class AnotherUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnotherUI));
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonColorButton1 = new Krypton.Toolkit.KryptonColorButton();
            this.kryptonCheckSet1 = new Krypton.Toolkit.KryptonCheckSet(this.components);
            this.kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            this.cuiGradientPanel1 = new CuoreUI.Controls.cuiGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(565, 318);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(297, 39);
            this.kryptonTextBox1.TabIndex = 0;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonColorButton1
            // 
            this.kryptonColorButton1.Location = new System.Drawing.Point(524, 179);
            this.kryptonColorButton1.Name = "kryptonColorButton1";
            this.kryptonColorButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonColorButton1.TabIndex = 1;
            this.kryptonColorButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonColorButton1.Values.Image")));
            this.kryptonColorButton1.Values.Text = "kryptonColorButton1";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownWidth = 213;
            this.kryptonComboBox1.Location = new System.Drawing.Point(693, 444);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(213, 38);
            this.kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox1.TabIndex = 2;
            this.kryptonComboBox1.Text = "kryptonComboBox1";
            // 
            // cuiGradientPanel1
            // 
            this.cuiGradientPanel1.GradientAngle = 0F;
            this.cuiGradientPanel1.Location = new System.Drawing.Point(693, 131);
            this.cuiGradientPanel1.Name = "cuiGradientPanel1";
            this.cuiGradientPanel1.OutlineThickness = 1F;
            this.cuiGradientPanel1.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiGradientPanel1.PanelColor2 = System.Drawing.Color.Transparent;
            this.cuiGradientPanel1.PanelOutlineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiGradientPanel1.PanelOutlineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiGradientPanel1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientPanel1.Size = new System.Drawing.Size(303, 188);
            this.cuiGradientPanel1.TabIndex = 3;
            // 
            // AnotherUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 696);
            this.Controls.Add(this.cuiGradientPanel1);
            this.Controls.Add(this.kryptonComboBox1);
            this.Controls.Add(this.kryptonColorButton1);
            this.Controls.Add(this.kryptonTextBox1);
            this.Name = "AnotherUI";
            this.Text = "FormGuna";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonColorButton kryptonColorButton1;
        private Krypton.Toolkit.KryptonCheckSet kryptonCheckSet1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel1;
    }
}