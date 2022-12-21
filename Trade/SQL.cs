using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Trade
{
    class SQL
    {

        static string Conect()
        {
            string startupPath = Environment.CurrentDirectory;
            return @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MishaShop;Integrated Security=True";
        }

        public static string Qvery(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(SQL.Conect());
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter a = new SqlDataAdapter(query, con);
                DataSet tabel = new DataSet();
                a.Fill(tabel);
                return "true";
            }
            catch (Exception e)
            {
                return "" + e;

            }

        }

        public static DataSet table(string query)
        {
            DataSet table = new DataSet();
            SqlConnection con = new SqlConnection(SQL.Conect());
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter a = new SqlDataAdapter(query, con);
            a.Fill(table);
            return table;
        }


        public static DataSet tb(string query)
        {
            DataSet table = new DataSet();

            SqlConnection con = new SqlConnection(SQL.Conect());
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter a = new SqlDataAdapter(query, con);
            a.Fill(table);
            return table;
        } 
    }
}
