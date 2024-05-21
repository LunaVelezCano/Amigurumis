using mdlAmigurumis.Transaccional.Pedido;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        [HttpPost("ConsultarPedido")]
        public PedidoModel ConsultarPedido(PedidoModel Pedido)
        {
            return Pedido;
        }
        [HttpPost("IngresarPedido")]
        public PedidoModel IngresarPedido(PedidoModel Pedido)
        {
            return Pedido;
        }
        [HttpPost("ModificarPedido")]
        public PedidoModel ModificarPedido(PedidoModel Pedido)
        {
            return Pedido;
        }
        [HttpPost("RetirarPedido")]
        public PedidoModel RetirarPedido(PedidoModel Pedido)
        {
            return Pedido;
        }
        [HttpPost("ConsultarIdPedido")]
        public PedidoModel ConsultarIdPedido(PedidoModel Pedido)
        {
            return Pedido;
        }
    }
}
