namespace CRUDOPERATION
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMovieTpe = new System.Windows.Forms.TextBox();
            this.lblMovieType = new System.Windows.Forms.Label();
            this.txtBooxOffice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtIMDB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 529);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 279);
            this.panel1.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.income});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 82;
            this.dgv.RowTemplate.Height = 33;
            this.dgv.Size = new System.Drawing.Size(1117, 279);
            this.dgv.TabIndex = 0;
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Movie ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 200;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "title";
            this.Title.HeaderText = "Movie Title";
            this.Title.MinimumWidth = 10;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 200;
            // 
            // income
            // 
            this.income.DataPropertyName = "income";
            this.income.HeaderText = "Box Office";
            this.income.MinimumWidth = 10;
            this.income.Name = "income";
            this.income.ReadOnly = true;
            this.income.ToolTipText = "Collection";
            this.income.Width = 200;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 100);
            this.panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(444, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 31);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 31);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(904, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "SHOW DETAILS>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(12, 45);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(132, 25);
            this.lblMovieName.TabIndex = 2;
            this.lblMovieName.Text = "Movie Name";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(186, 42);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(192, 31);
            this.txtMovieName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // txtMovieTpe
            // 
            this.txtMovieTpe.Location = new System.Drawing.Point(194, 289);
            this.txtMovieTpe.Name = "txtMovieTpe";
            this.txtMovieTpe.Size = new System.Drawing.Size(192, 31);
            this.txtMovieTpe.TabIndex = 7;
            // 
            // lblMovieType
            // 
            this.lblMovieType.AutoSize = true;
            this.lblMovieType.Location = new System.Drawing.Point(20, 295);
            this.lblMovieType.Name = "lblMovieType";
            this.lblMovieType.Size = new System.Drawing.Size(124, 25);
            this.lblMovieType.TabIndex = 6;
            this.lblMovieType.Text = "Movie Type";
            // 
            // txtBooxOffice
            // 
            this.txtBooxOffice.Location = new System.Drawing.Point(186, 134);
            this.txtBooxOffice.Name = "txtBooxOffice";
            this.txtBooxOffice.Size = new System.Drawing.Size(192, 31);
            this.txtBooxOffice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Box Office";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(186, 86);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(192, 31);
            this.txtId.TabIndex = 11;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 89);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(96, 25);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "Movie ID";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(188, 192);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 31);
            this.Date.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(194, 245);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 31);
            this.textBox3.TabIndex = 14;
            // 
            // txtIMDB
            // 
            this.txtIMDB.AutoSize = true;
            this.txtIMDB.Location = new System.Drawing.Point(20, 245);
            this.txtIMDB.Name = "txtIMDB";
            this.txtIMDB.Size = new System.Drawing.Size(64, 25);
            this.txtIMDB.TabIndex = 13;
            this.txtIMDB.Text = "IMDB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 808);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtIMDB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtBooxOffice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMovieTpe);
            this.Controls.Add(this.lblMovieType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn income;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMovieTpe;
        private System.Windows.Forms.Label lblMovieType;
        private System.Windows.Forms.TextBox txtBooxOffice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtIMDB;
    }
}

