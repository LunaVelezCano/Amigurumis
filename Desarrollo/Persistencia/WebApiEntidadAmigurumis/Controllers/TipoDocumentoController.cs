using mdlAmigurumis.Usuario.TipoDocumento;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDocumentoController : ControllerBase
    {
        [HttpPost("ConsultarTipoDocumento")]
        public TipoDocumentoModel ConsultarTipoDocumento(TipoDocumentoModel TipoDocumento)
        {
            return TipoDocumento;
        }
        [HttpPost("IngresarTipoDocumento")]
        public TipoDocumentoModel IngresarTipoDocumento(TipoDocumentoModel TipoDocumento)
        {
            return TipoDocumento;
        }
        [HttpPost("ModificarTipoDocumento")]
        public TipoDocumentoModel ModificarTipoDocumento(TipoDocumentoModel TipoDocumento)
        {
            return TipoDocumento;
        }
        [HttpPost("RetirarTipoDocumento")]
        public TipoDocumentoModel RetirarTipoDocumento(TipoDocumentoModel TipoDocumento)
        {
            return TipoDocumento;
        }
        [HttpPost("ConsultarIdTipoDocumento")]
        public TipoDocumentoModel ConsultarIdTipoDocumento(TipoDocumentoModel TipoDocumento)
        {
            return TipoDocumento;
        }
    }
}
