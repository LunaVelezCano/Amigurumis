using mdlAmigurumis.Geografia.Departamento;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        [HttpPost("ConsultarDepartamento")]
        public DepartamentoModel ConsultarDepartamento(DepartamentoModel departamento)
        {
            return departamento;
        }

        [HttpPost("IngresarDepartamento")]
        public DepartamentoModel IngresarDepartamento(DepartamentoModel departamento)
        {
            return departamento;
        }

        [HttpPost("ModificarDepartamento")]
        public DepartamentoModel ModificarDepartamento(DepartamentoModel departamento)
        {
            return departamento;
        }

        [HttpPost("RetirarDepartamento")]
        public DepartamentoModel RetirarDepartamento(DepartamentoModel departamento)
        {
            return departamento;
        }
        [HttpPost("ConsultarIdDepartamento")]
        public DepartamentoModel ConsultarIdDepartamento(DepartamentoModel departamento)
        {
            return departamento;
        }
    
    }
}
