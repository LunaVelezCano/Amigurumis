using mdlAmigurumis.Geografia.Ciudad;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CiudadController : ControllerBase
    {
        [HttpPost("ConsultarCiudad")]
        public CiudadModel ConsultarCiudad(CiudadModel Ciudad)
        {
            return Ciudad;
        }
        [HttpPost("IngresarCiudad")]
        public CiudadModel IngresarCiudad(CiudadModel Ciudad)
        {
            return Ciudad;
        }

        [HttpPost("ModificarCiudad")]
        public CiudadModel ModificarCiudad(CiudadModel Ciudad)
        {
            return Ciudad;
        }
        [HttpPost("RetirarCiudad")]
        public CiudadModel RetirarCiudad(CiudadModel Ciudad)
        {
            return Ciudad;
        }
        [HttpPost("ConsultarIdCiudad")]
        public CiudadModel ConsultarIdCiudad(CiudadModel Ciudad)
        {
            return Ciudad;
        }
    }
}
