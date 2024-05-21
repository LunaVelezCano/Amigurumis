using mdlAmigurumis.Transaccional.FormaDePago;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormaDePagoController : ControllerBase
    {
        [HttpPost("ConsultarFormaDePago")]
        public FormaDePagoModel ConsultarFormaDePago(FormaDePagoModel FormaDePago)
        {
            return FormaDePago;
        }
        [HttpPost("IngresarFormaDePago")]
        public FormaDePagoModel IngresarFormaDePago(FormaDePagoModel FormaDePago)
        {
            return FormaDePago;
        }
        [HttpPost("ModificarFormaDePago")]
        public FormaDePagoModel ModificarFormaDePago(FormaDePagoModel FormaDePago)
        {
            return FormaDePago;
        }
        [HttpPost("RetirarFormaDePago")]
        public FormaDePagoModel RetirarGenero(FormaDePagoModel FormaDePago)
        {
            return FormaDePago;
        }
        [HttpPost("ConsultarIdFormaDePago")]
        public FormaDePagoModel ConsultarIdFormaDePago(FormaDePagoModel FormaDePago)
        {
            return FormaDePago;
        }
    }
}
