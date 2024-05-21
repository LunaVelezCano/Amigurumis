using mdlAmigurumis.Usuario.Cliente;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpPost("ConsultarCliente")]
        public ClienteModel ConsultarCliente(ClienteModel Cliente)
        {
            return Cliente;
        }
        [HttpPost("IngresarCliente")]
        public ClienteModel IngresarCliente(ClienteModel Cliente)
        {
            return Cliente;
        }
        [HttpPost("ModificarCliente")]
        public ClienteModel ModificarCliente(ClienteModel Cliente)
        {
            return Cliente;
        }
        [HttpPost("RetirarCliente")]
        public ClienteModel RetirarCliente(ClienteModel Cliente)
        {
            return Cliente;
        }
        [HttpPost("ConsultarIdCliente")]
        public ClienteModel ConsultarIdCliente(ClienteModel Cliente)
        {
            return Cliente;
        }
    }
}
