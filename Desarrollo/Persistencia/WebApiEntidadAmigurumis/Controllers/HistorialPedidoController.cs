using mdlAmigurumis.Transaccional.HistorialPedido;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorialPedidoController : ControllerBase
    {
        [HttpPost("ConsultarHistorialPedido")]
        public HistorialPedidoModel ConsultarHistorialPedido(HistorialPedidoModel HistorialPedido)
        {
            return HistorialPedido;
        }
        [HttpPost("IngresarHistorialPedido")]
        public HistorialPedidoModel IngresarHistorialPedido(HistorialPedidoModel HistorialPedido)
        {
            return HistorialPedido;
        }
        [HttpPost("ModificarHistorialPedido")]
        public HistorialPedidoModel ModificarHistorialPedido(HistorialPedidoModel HistorialPedido)
        {
            return HistorialPedido;
        }
        [HttpPost("RetirarHistorialPedido")]
        public HistorialPedidoModel RetirarHistorialPedido(HistorialPedidoModel HistorialPedido)
        {
            return HistorialPedido;
        }
        [HttpPost("ConsultarIdHistorialPedido")]
        public HistorialPedidoModel ConsultarIdHistorialPedido(HistorialPedidoModel HistorialPedido)
        {
            return HistorialPedido;
        }
    }
}
