using mdlAmigurumis.Organizacion.Amigurumis;
using mdlAmigurumis.Organizacion.Sede;
using mdlAmigurumis.Organizacion.TipoEmpleado;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoEmpleadoController : ControllerBase
    {
        [HttpPost("ConsultarTipoEmpleado")]
        public TipoEmpleadoModel ConsultarTipoEmpleado(TipoEmpleadoModel TipoEmpleado)
        {
            return TipoEmpleado;
        }
        [HttpPost("IngresarTipoEmpleado")]
        public TipoEmpleadoModel IngresarTipoEmpleado(TipoEmpleadoModel TipoEmpleado)
        {
            return TipoEmpleado;
        }
        [HttpPost("ModificarTipoEmpleado")]
        public TipoEmpleadoModel ModificarTipoEmpleado(TipoEmpleadoModel TipoEmpleado)
        {
            return TipoEmpleado;
        }
        [HttpPost("RetirarTipoEmpleado")]
        public TipoEmpleadoModel RetirarTipoEmpleado(TipoEmpleadoModel TipoEmpleado)
        {
            return TipoEmpleado;
        }
        [HttpPost("ConsultarIdTipoEmpleado")]
        public TipoEmpleadoModel ConsultarIdTipoEmpleado(TipoEmpleadoModel TipoEmpleado)
        {
            return TipoEmpleado;
        }
    }
}
