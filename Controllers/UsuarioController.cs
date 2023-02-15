using Microsoft.AspNetCore.Mvc;
using crud_api.Model;

namespace crud_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private static List<Usuario> listaUsuario()
        {
            return new List<Usuario>{
                    new Usuario{ Nome = "Cristhian", Id = 1}
                };
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(listaUsuario());
        }
        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            var retornaUsuarios = listaUsuario();
            retornaUsuarios.Add(usuario);
            return Ok(retornaUsuarios);
        }
    }
}