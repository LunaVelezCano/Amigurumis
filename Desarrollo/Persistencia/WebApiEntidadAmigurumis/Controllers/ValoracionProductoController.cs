using mdlAmigurumis.Catalogo.ValoracionProducto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValoracionProductoController : ControllerBase
    {
        [HttpPost("ConsultarValoracionProducto")]
        public ValoracionProductoModel ConsultarValoracionProducto(ValoracionProductoModel ValoracionProducto)
        {
            return ValoracionProducto;
        }
        [HttpPost("IngresarValoracionProducto")]
        public ValoracionProductoModel IngresarValoracionProducto(ValoracionProductoModel ValoracionProducto)
        {
            return ValoracionProducto;
        }
        [HttpPost("ModificarValoracionProducto")]
        public ValoracionProductoModel ModificarValoracionProducto(ValoracionProductoModel ValoracionProducto)
        {
            return ValoracionProducto;
        }
        [HttpPost("RetirarValoracionProducto")]
        public ValoracionProductoModel RetirarValoracionProducto(ValoracionProductoModel ValoracionProducto)
        {
            return ValoracionProducto;
        }
        [HttpPost("ConsultarIdValoracionProducto")]
        public ValoracionProductoModel ConsultarIdValoracionProducto(ValoracionProductoModel ValoracionProducto)
        {
            return ValoracionProducto;
        }
    }
}
