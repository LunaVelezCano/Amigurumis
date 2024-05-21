using mdlAmigurumis.Organizacion.Empleado;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        [HttpPost("ConsultarEmpleado")]
        public EmpleadoModel ConsultarEmpleado(EmpleadoModel Empleado)
        {
            return Empleado;
        }
        [HttpPost("IngresarEmpleado")]
        public EmpleadoModel IngresarEmpleado(EmpleadoModel Empleado)
        {
            return Empleado;
        }
        [HttpPost("ModificarEmpleado")]
        public EmpleadoModel ModificarEmpleado(EmpleadoModel Empleado)
        {
            return Empleado;
        }
        [HttpPost("RetirarEmpleado")]
        public EmpleadoModel RetirarEmpleado(EmpleadoModel Empleado)
        {
            return Empleado;
        }
        [HttpPost("ConsultarIdEmpleado")]
        public EmpleadoModel ConsultarIdEmpleado(EmpleadoModel Empleado)
        {
            return Empleado;
        }
    }
}
