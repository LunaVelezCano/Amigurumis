using mdlAmigurumis.Usuario.Genero;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        [HttpPost("ConsultarGenero")]
        public GeneroModel ConsultarGenero(GeneroModel Genero)
        {
            return Genero;
        }
        [HttpPost("IngresarGenero")]
        public GeneroModel IngresarGenero(GeneroModel Genero)
        {
            return Genero;
        }
        [HttpPost("ModificarGenero")]
        public GeneroModel ModificarGenero(GeneroModel Genero)
        {
            return Genero;
        }
        [HttpPost("RetirarGenero")]
        public GeneroModel RetirarGenero(GeneroModel Genero)
        {
            return Genero;
        }
        [HttpPost("ConsultarIdGenero")]
        public GeneroModel ConsultarIdGenero(GeneroModel Genero)
        {
            return Genero;
        }
    }
}
