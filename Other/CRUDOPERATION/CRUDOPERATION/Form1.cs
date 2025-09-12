using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDOPERATION
{
    public partial class Form1 : Form
    {

        private DataAccess da;
        public Form1()
        {
            InitializeComponent();
            this.da = new DataAccess();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=SHOHAGRANASUVO\\SQLEXPRESS;Initial Catalog=SHOHAG;Integrated Security=True");
            sqlConn.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from Movie ", sqlConn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            this.dgv.AutoGenerateColumns = false;
            this.dgv.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
           //  SqlCommand sqlCommand = new SqlCommand("select * from Movie where genre = '" + this.textBox1.Text + "';", sqlConn);
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=SHOHAGRANASUVO\\SQLEXPRESS;Initial Catalog=SHOHAG;Integrated Security=True");
            sqlConn.Open();

            SqlCommand sqlCommand = new SqlCommand("select * from Movie where genre = '" + this.textBox1.Text + "';", sqlConn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            this.dgv.AutoGenerateColumns = false;
            this.dgv.DataSource = ds.Tables[0];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Sql = @"insert into table Movie values('"+this.txtId.Text+ "','"+this.txtMovieName.Text+ "','"+this.txtMovieName.Text+"','"+this.txtIMDB.Text+ "' , '"+this.Date.Text+"')";
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            this.txtMovieName.Text = dgv.CurrentRow.Cells[1].Value.ToString();
        }
    }
    }

