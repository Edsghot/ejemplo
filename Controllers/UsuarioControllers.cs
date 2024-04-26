using Microsoft.AspNetCore.Mvc;
using principal._05_DataAcces.context;
using principal._05_DataAcces.entity;

namespace principal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioControllers : ControllerBase
    {
    

        private readonly UsuarioContext dbContext;

        public UsuarioControllers(UsuarioContext dbContext)
        {

            this.dbContext = dbContext;
        }

        [HttpGet(Name = "GetUsuarios")]
        public ActionResult<IEnumerable<Usuario>> Get()
        {
            var usuarios = dbContext.Usuarios.ToList();
            return usuarios;
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
