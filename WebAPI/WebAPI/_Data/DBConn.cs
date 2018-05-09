using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WebAPI
{
    public class DBConn
    {
        public static SqlConnection ConexionSQL()
        {
            SqlConnection ConectString = new SqlConnection(@"Data Source = LAPTOP-051\SQLEXPRESS;" +
                                                               "Initial Catalog = mapsogss;" +
                                                                "User id=sa;" +
                                                                "Password=petrovendor;");
            return ConectString;
        }
        public static DataTable ConsultaSQL(string Query)
        {
            DataTable _Consulta = new DataTable();
            SqlConnection conn = new SqlConnection();
            conn = ConexionSQL();
            SqlCommand cmd = new SqlCommand(Query, conn);
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
                else
                {
                    conn.Open();
                }
                _Consulta.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return _Consulta;
        }
    }
}
