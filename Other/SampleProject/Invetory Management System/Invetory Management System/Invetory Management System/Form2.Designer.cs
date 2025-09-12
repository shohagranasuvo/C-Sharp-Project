namespace Invetory_Management_System
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            close = new Button();
            panel1 = new Panel();
            register_showPassword = new CheckBox();
            pictureBox4 = new PictureBox();
            register_cPassword = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            register_label = new Label();
            label2 = new Label();
            login_btn = new Button();
            register_password = new TextBox();
            register_username = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // close
            // 
            close.BackColor = Color.Firebrick;
            close.FlatAppearance.BorderColor = Color.Black;
            close.FlatStyle = FlatStyle.Flat;
            close.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.ForeColor = Color.White;
            close.Location = new Point(712, 12);
            close.Name = "close";
            close.Size = new Size(33, 29);
            close.TabIndex = 1;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(register_showPassword);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(register_cPassword);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(register_label);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(register_password);
            panel1.Controls.Add(register_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(105, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 425);
            panel1.TabIndex = 2;
            // 
            // register_showPassword
            // 
            register_showPassword.AutoSize = true;
            register_showPassword.Location = new Point(337, 280);
            register_showPassword.Name = "register_showPassword";
            register_showPassword.Size = new Size(134, 24);
            register_showPassword.TabIndex = 11;
            register_showPassword.Text = "Show password";
            register_showPassword.UseVisualStyleBackColor = true;
            register_showPassword.CheckedChanged += register_showPassword_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_lock_26px;
            pictureBox4.Location = new Point(144, 244);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 30);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // register_cPassword
            // 
            register_cPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_cPassword.Location = new Point(182, 244);
            register_cPassword.Name = "register_cPassword";
            register_cPassword.PasswordChar = '*';
            register_cPassword.Size = new Size(289, 30);
            register_cPassword.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_lock_26px;
            pictureBox3.Location = new Point(145, 199);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 30);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(144, 152);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 30);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_user_80px;
            pictureBox1.Location = new Point(254, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // register_label
            // 
            register_label.AutoSize = true;
            register_label.BackColor = Color.White;
            register_label.Cursor = Cursors.Hand;
            register_label.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_label.ForeColor = SystemColors.Highlight;
            register_label.Location = new Point(383, 373);
            register_label.Name = "register_label";
            register_label.Size = new Size(103, 20);
            register_label.TabIndex = 5;
            register_label.Text = "Sign in here ";
            register_label.Click += register_label_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(144, 373);
            label2.Name = "label2";
            label2.Size = new Size(201, 20);
            label2.TabIndex = 4;
            label2.Text = "Already have an account?";
            label2.Click += label2_Click;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(85, 113, 73);
            login_btn.FlatAppearance.BorderColor = Color.White;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.ButtonHighlight;
            login_btn.Location = new Point(194, 319);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(248, 40);
            login_btn.TabIndex = 3;
            login_btn.Text = "Signup";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // register_password
            // 
            register_password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_password.Location = new Point(182, 199);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(289, 30);
            register_password.TabIndex = 2;
            // 
            // register_username
            // 
            register_username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_username.Location = new Point(182, 152);
            register_username.Name = "register_username";
            register_username.Size = new Size(289, 30);
            register_username.TabIndex = 1;
            register_username.TextChanged += login_username_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 105);
            label1.Name = "label1";
            label1.Size = new Size(208, 27);
            label1.TabIndex = 0;
            label1.Text = "Register Account";
            label1.Click += label1_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(85, 113, 73);
            ClientSize = new Size(768, 517);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button close;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label register_label;
        private Label label2;
        private Button login_btn;
        private TextBox register_password;
        private TextBox register_username;
        private Label label1;
        private PictureBox pictureBox4;
        private TextBox register_cPassword;
        private CheckBox register_showPassword;
    }
}