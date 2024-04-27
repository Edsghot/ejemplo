using Microsoft.AspNetCore.Mvc;
using principal._05_DataAcces.context;
using principal._05_DataAcces.entity;
using principal.conexion;

namespace principal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioControllers : ControllerBase
    {
    

        private readonly UsuarioContext dbContext;
        private Data data;

        public UsuarioControllers(UsuarioContext dbContext)
        {

            this.dbContext = dbContext;
        }

        [HttpGet(Name = "Trabajadores")]
        public ActionResult<string> Get()
        {
            data = new Data();

            return data.conexionBaseDatos();
        }

        [HttpPost(Name = "createUsuario")]
        public ActionResult<Usuario> createUsuario([FromForm] Usuario usuario)
        {
            usuario.idUsuario = Guid.NewGuid().ToString();
            dbContext.Usuarios.Add(usuario);
            dbContext.SaveChanges();
            return usuario;
        }




    }
}
