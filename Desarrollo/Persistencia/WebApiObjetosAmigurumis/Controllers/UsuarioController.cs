using mdlAmigurumis.Organizacion;
using mdlAmigurumis.Transaccional;
using mdlAmigurumis.Usuario;
using Microsoft.AspNetCore.Mvc;
using ReglasNegocio.Organizacion;
using ReglasNegocio.Usuario;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiObjetosAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPost("ConsultarUsuario")]
        public List<UsuarioModel> ConsultarUsuario(UsuarioModel Usuario)
        {
            NegocioUsuario negocioUsuario = new NegocioUsuario();
            return negocioUsuario.ConsultarUsuario(Usuario);
        }
        [HttpPost("IngresarUsuario")]
        public UsuarioModel IngresarUsuario(UsuarioModel Usuario)
        {
            return Usuario;
        }
        [HttpPost("ModificarUsuario")]
        public UsuarioModel ModificarUsuario(UsuarioModel Usuario)
        {
            return Usuario;
        }
        [HttpPost("RetirarUsuario")]
        public UsuarioModel RetirarUsuario(UsuarioModel Usuario)
        {
            return Usuario;
        }
        [HttpPost("ConsultarUsuarioNombre")]
        public List<UsuarioModel> ConsultarUsuarioNombre(UsuarioModel Usuario)
        {
            NegocioUsuario negocioUsuario = new NegocioUsuario();
            return negocioUsuario.ConsultarUsuarioNombre(Usuario);
        }
    }
}
