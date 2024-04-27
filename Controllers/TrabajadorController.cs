using Microsoft.AspNetCore.Mvc;
using principal.conexion;
using principal.Dto;

namespace principal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrabajadorController : ControllerBase
    {

        [HttpGet(Name = "GetTipoTrabajador")]
        public ActionResult<List<Trabajador>> GetTipoTrabajador([FromQuery] int tipo){
            var dataTrabajo = new DataTrabajador();
            var trabajadores = dataTrabajo.conexionBaseDatos();
            var trabajadoresFiltrado = trabajadores.FindAll(x => x.TipoTrabajador == tipo);
            return trabajadoresFiltrado;
        }

        [HttpPost(Name = "GetByDni")]
        public ActionResult<Trabajador> GetByDni([FromQuery] string dni)
        {
            var dataTrabajo = new DataTrabajador();
            var trabajadores = dataTrabajo.conexionBaseDatos();
            var trabajadoresFiltrado = trabajadores.Find(x => x.Dni == dni);
            return trabajadoresFiltrado;
        }




    }
}
