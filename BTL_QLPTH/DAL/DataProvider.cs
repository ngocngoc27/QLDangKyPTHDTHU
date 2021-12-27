using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLPTH.DAL
{
    class DataProvider
    {
        static string chuoikn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLPTH;Integrated Security=True";
        SqlConnection conn = new SqlConnection(chuoikn);
        public DataTable GetData(string sql)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public void Excute(string sql)
        {
            conn.Open();
            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
