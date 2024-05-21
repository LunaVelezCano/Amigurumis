using mdlAmigurumis.Transaccional.Venta;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpPost("ConsultarVenta")]
        public VentaModel ConsultarVenta(VentaModel Venta)
        {
            return Venta;
        }
        [HttpPost("IngresarVenta")]
        public VentaModel IngresarVenta(VentaModel Venta)
        {
            return Venta;
        }
        [HttpPost("ModificarVenta")]
        public VentaModel ModificarVenta(VentaModel Venta)
        {
            return Venta;
        }
        [HttpPost("RetirarVenta")]
        public VentaModel RetirarVenta(VentaModel Venta)
        {
            return Venta;
        }
        [HttpPost("ConsultarIdVenta")]
        public VentaModel ConsultarIdVenta(VentaModel Venta)
        {
            return Venta;
        }
    }
}
