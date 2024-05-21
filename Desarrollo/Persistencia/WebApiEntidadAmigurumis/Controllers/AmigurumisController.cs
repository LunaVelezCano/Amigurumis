using mdlAmigurumis.Organizacion.Amigurumis;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmigurumisController : ControllerBase
    {
        [HttpPost("ConsultarAmigurumis")]
        public AmigurumisModel ConsultarAmigurumis(AmigurumisModel Amigurumis)
        {
            return Amigurumis;
        }
        [HttpPost("IngresarAmigurumis")]
        public AmigurumisModel IngresarAmigurumis(AmigurumisModel Amigurumis)
        {
            return Amigurumis;
        }
        [HttpPost("ModificarAmigurumis")]
        public AmigurumisModel ModificarAmigurumis(AmigurumisModel Amigurumis)
        {
            return Amigurumis;
        }
        [HttpPost("RetirarAmigurumis")]
        public AmigurumisModel RetirarAmigurumis(AmigurumisModel Amigurumis)
        {
            return Amigurumis;
        }
        [HttpPost("ConsultarIdAmigurumis")]
        public AmigurumisModel ConsultarIdAmigurumis(AmigurumisModel Amigurumis)
        {
            return Amigurumis;
        }
    }
}
