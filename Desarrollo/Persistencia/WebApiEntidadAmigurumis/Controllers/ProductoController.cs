using mdlAmigurumis.Catalogo.Producto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpPost("ConsultarProducto")]
        public ProductoModel ConsultarProducto(ProductoModel Producto)
        {
            return Producto;
        }
        [HttpPost("IngresarProducto")]
        public ProductoModel IngresarProducto(ProductoModel Producto)
        {
            return Producto;
        }
        [HttpPost("ModificarProducto")]
        public ProductoModel ModificarProducto(ProductoModel Producto)
        {
            return Producto;
        }
        [HttpPost("RetirarProducto")]
        public ProductoModel RetirarProducto(ProductoModel Producto)
        {
            return Producto;
        }
        [HttpPost("ConsultarIdProducto")]
        public ProductoModel ConsultarIdProducto(ProductoModel Producto)
        {
            return Producto;
        }
    }
}
