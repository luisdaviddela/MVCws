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
            SqlConnection ConectString = new SqlConnection("Data Source=servidor;" +
                                                                "Initial Catalog=PruebaWebApi;" + //Base de datos
                                                                "User id=desarrollo;" +
                                                                "Password=Contraseña;");
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
