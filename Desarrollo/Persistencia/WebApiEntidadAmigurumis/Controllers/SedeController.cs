using mdlAmigurumis.Organizacion.Amigurumis;
using mdlAmigurumis.Organizacion.Sede;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SedeController : ControllerBase
    {
        [HttpPost("ConsultarSede")]
        public SedeModel ConsultarSede(SedeModel Sede)
        {
            return Sede;
        }
        [HttpPost("IngresarSede")]
        public SedeModel IngresarSede(SedeModel Sede)
        {
            return Sede;
        }
        [HttpPost("ModificarSede")]
        public SedeModel ModificarSede(SedeModel Sede)
        {
            return Sede;
        }
        [HttpPost("RetirarAmigurumis")]
        public SedeModel RetirarSede(SedeModel Sede)
        {
            return Sede;
        }
        [HttpPost("ConsultarIdSede")]
        public SedeModel ConsultarIdSede(SedeModel Sede)
        {
            return Sede;
        }
    }
}
