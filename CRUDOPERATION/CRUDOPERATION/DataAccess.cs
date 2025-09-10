using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDOPERATION
{
    public class DataAccess 
    {
        // 🔹 Core ADO.NET objects
        public SqlConnection SqlConn { get; private set; }
        public SqlCommand SqlCmd { get; private set; }
        public SqlDataAdapter SqlAdapter { get; private set; }
        public DataSet DataSet { get; private set; }
        public SqlCommand Sqlcom { get; private set; }

        // 🔹 Connection String
        private readonly string connectionString ="Data Source=SHOHAGRANASUVO\\SQLEXPRESS;Initial Catalog=SHOHAG;Integrated Security=True";

        // 🔹 Constructor
        public DataAccess()
        {
            SqlConn = new SqlConnection(connectionString);
            DataSet = new DataSet();
        }

        // ✅ Open Connection
        private void Open()
        {
            if (SqlConn.State == ConnectionState.Closed)
                SqlConn.Open();
        }

        // ✅ Close Connection
        private void Close()
        {
            if (SqlConn.State == ConnectionState.Open)
                SqlConn.Close();
        }

        // ✅ SELECT query → fills DataSet
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                Open();
                SqlCmd = new SqlCommand(query, SqlConn);

                if (parameters != null)
                    SqlCmd.Parameters.AddRange(parameters);

                SqlAdapter = new SqlDataAdapter(SqlCmd);
                DataSet = new DataSet();
                SqlAdapter.Fill(DataSet);

                dt = DataSet.Tables[0];
            }
            finally
            {
                Close();
            }
            return dt;
        }

        public int ExecuteDMLQuery(string sql)
        {
            this.Sqlcom =new SqlCommand(sql,this.SqlConn);
            int u = this.Sqlcom.ExecuteNonQuery();
            if (u == 1)
            {
                MessageBox.Show("Row Update");
            }
            else
            {
                MessageBox.Show("Row  Not Updated");

            }
                return u;
        }
    }
}
