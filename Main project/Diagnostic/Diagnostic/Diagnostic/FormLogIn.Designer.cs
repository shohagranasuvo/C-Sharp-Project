namespace Diagnostic
{
    partial class FormLogIn
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
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.Color.Transparent;
            this.pnlWelcome.Controls.Add(this.btnLogIn);
            this.pnlWelcome.Controls.Add(this.txtPassword);
            this.pnlWelcome.Controls.Add(this.txtName);
            this.pnlWelcome.Controls.Add(this.lblPass);
            this.pnlWelcome.Controls.Add(this.lblName);
            this.pnlWelcome.Controls.Add(this.lblWelcome);
            this.pnlWelcome.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pnlWelcome.Location = new System.Drawing.Point(343, 136);
            this.pnlWelcome.Margin = new System.Windows.Forms.Padding(2);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(438, 345);
            this.pnlWelcome.TabIndex = 8;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(148, 212);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(74, 24);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.button1_Click_1);
            this.btnLogIn.MouseLeave += new System.EventHandler(this.btnLogIn_MouseLeave);
            this.btnLogIn.MouseHover += new System.EventHandler(this.btnLogIn_MouseHover);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(131, 157);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(126, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "123";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 110);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 20);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "U002";
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(33, 157);
            this.lblPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(96, 17);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "PASSWORD";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(33, 110);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NAME";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblWelcome.Location = new System.Drawing.Point(127, 45);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(98, 20);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME";
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diagnostic.Properties.Resources.LogInBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1094, 657);
            this.Controls.Add(this.pnlWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogIn;
    }
}

