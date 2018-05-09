using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
namespace WebAPI
{
    public class WebAPI
    {
        public Usuario BuscarPorId(int IdUsuario)
        {
            Usuario InformacionUsuario = new Usuario();
            DataTable _consulta = new DataTable();
            try
            {
                _consulta = DBConn.ConsultaSQL("select * from Usuarios where idusuario = "+IdUsuario+"");
                if (_consulta.Rows.Count>0)
                {
                    InformacionUsuario.IdUsuario = Convert.ToInt32(_consulta.Rows[0].ItemArray[0]);
                    InformacionUsuario.Nombre = _consulta.Rows[0].ItemArray[1].ToString();
                    InformacionUsuario.Apellido = _consulta.Rows[0].ItemArray[2].ToString();
                    InformacionUsuario.FechaNacimiento= Convert.ToDateTime(_consulta.Rows[0].ItemArray[3]);
                }
            }
            catch (Exception)
            {
            }
            return InformacionUsuario;
        }
    }
}
