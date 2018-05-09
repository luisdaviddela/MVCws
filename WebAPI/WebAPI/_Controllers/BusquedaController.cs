using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI
{
    [Route("api/[controller]")]
    public class BusquedaController : Controller
    {
        // GET: api/<controller>
        [HttpGet("{usuarioId}")]
        public string Busqueda(int usuarioId)
        {
            Usuario InformacionUsuario = new Usuario();
            try
            {
                InformacionUsuario = WebAPI.BuscarPorId(usuarioId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            var jsonConver = JsonConvert.SerializeObject(InformacionUsuario);
            return jsonConver.ToString();
        }

        [HttpPost]
        public string Nuevo([FromBody]Materia materia)
        {
            Usuario InformacionUsuario = new Usuario();
            try
            {
                //InformacionUsuario = WebAPI.BuscarPorId(usuarioId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            var jsonConver = JsonConvert.SerializeObject(InformacionUsuario);
            return jsonConver.ToString();
        }
    }
}
