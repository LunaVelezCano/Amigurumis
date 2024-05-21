using mdlAmigurumis.Catalogo.Categoria;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        [HttpPost("ConsultarCategoria")]
        public CategoriaModel ConsultarCategoria(CategoriaModel Categoria)
        {
            return Categoria;
        }
        [HttpPost("IngresarCategoria")]
        public CategoriaModel IngresarCategoria(CategoriaModel Categoria)
        {
            return Categoria;
        }
        [HttpPost("ModificarCategoria")]
        public CategoriaModel ModificarCategoria(CategoriaModel Categoria)
        {
            return Categoria;
        }
        [HttpPost("RetirarCategoria")]
        public CategoriaModel RetirarCategoria(CategoriaModel Categoria)
        {
            return Categoria;
        }
        [HttpPost("ConsultarIdCategoria")]
        public CategoriaModel ConsultarIdCategoria(CategoriaModel Categoria)
        {
            return Categoria;
        }
    }
}
