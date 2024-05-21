using mdlAmigurumis.Catalogo;
using mdlAmigurumis.Geografia;
using Microsoft.AspNetCore.Mvc;
using ReglasNegocio.Geografia;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiObjetosAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeografiaController : ControllerBase
    {
        [HttpPost("ConsultarGeografia")]
        public List<GeografiaModel> ConsultarGeografia(GeografiaModel geografia)
        {
            NegocioGeografia negociogeografia = new NegocioGeografia();
            return negociogeografia.ConsultarGeografia(geografia);
        }

        [HttpPost("ConsultarGeografiaNombre")]
        public List<GeografiaModel> ConsultarGeografiaNombre(GeografiaModel geografia)
        {
            NegocioGeografia negociogeografia = new NegocioGeografia();
            return negociogeografia.ConsultarGeografiaNombre(geografia);
        }
         [HttpPost("IngresarGeografia")]
        public GeografiaModel IngresarGeografia(GeografiaModel Geografia)
        {
            return Geografia;
        }
        [HttpPost("ModificarGeografia")]
        public GeografiaModel ModificarGeografia(GeografiaModel Geografia)
        {
            return Geografia;
        }
        [HttpPost("RetirarGeografia")]
        public GeografiaModel RetirarGeografia(GeografiaModel Geografia)
        {
            return Geografia;
        }
    }
}
