using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DEV
{
    public class AcessoDB
    {
        string _connString = "";

        public AcessoDB(string conn)
        {
            _connString = conn;
        }
        public DataTable executarQuery(string sql)
        {
            DataTable dt = new DataTable("dtVeiculos");
            using (SqlConnection conn = new SqlConnection(_connString))
            using (SqlCommand cmd = new SqlCommand())
            {
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                da.SelectCommand = cmd;

                da.Fill(dt);
           
                conn.Close();
            }
            return dt;
        }
        public void executarComando(string sql)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            using (SqlCommand cmd = new SqlCommand())
            {
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                conn.Close();
            }

        }
    }
}