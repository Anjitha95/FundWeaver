using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FundWeaverApp
{
    class DbOperations
    {
        public DbOperations()
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell-PC\Documents\Fundweaverdb.mdf;Integrated Security=True;Connect Timeout=30");
        public void nonreturn(string s)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = s;
            con.Close();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable ret(string s)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = s;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return (dt);
        }
        public int maxid(string s)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = s;
            con.Open();
            int id;
            try
            {
                id = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
            }
            catch
            {
                id = 1;
            }
            finally
            {
                con.Close();
            }
            return id;
        }
    }
}
