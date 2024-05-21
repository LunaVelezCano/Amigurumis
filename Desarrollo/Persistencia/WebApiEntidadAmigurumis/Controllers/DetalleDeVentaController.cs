using mdlAmigurumis.Transaccional.DetalleDeVenta;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleDeVentaController : ControllerBase
    {
        [HttpPost("ConsultarDetalleDeVenta")]
        public DetalleDeVentaModel ConsultarDetalleDeVenta(DetalleDeVentaModel DetalleDeVenta)
        {
            return DetalleDeVenta;
        }
        [HttpPost("IngresarDetalleDeVenta")]
        public DetalleDeVentaModel IngresarDetalleDeVenta(DetalleDeVentaModel DetalleDeVenta)
        {
            return DetalleDeVenta;
        }
        [HttpPost("ModificarDetalleDeVenta")]
        public DetalleDeVentaModel ModificarDetalleDeVenta(DetalleDeVentaModel DetalleDeVenta)
        {
            return DetalleDeVenta;
        }
        [HttpPost("RetirarDetalleDeVenta")]
        public DetalleDeVentaModel RetirarDetalleDeVenta(DetalleDeVentaModel DetalleDeVenta)
        {
            return DetalleDeVenta;
        }
        [HttpPost("ConsultarIdDetalleDeVenta")]
        public DetalleDeVentaModel ConsultarIdDetalleDeVenta(DetalleDeVentaModel DetalleDeVenta)
        {
            return DetalleDeVenta;
        }
    }
}
