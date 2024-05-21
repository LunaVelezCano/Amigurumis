using mdlAmigurumis.Catalogo;
using mdlAmigurumis.Organizacion;
using Microsoft.AspNetCore.Mvc;
using ReglasNegocio.Catalogo;
using ReglasNegocio.Organizacion;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiObjetosAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizacionController : ControllerBase
    {
        [HttpPost("ConsultarOrganizacion")]
        public List<OrganizacionModel> ConsultarOrganizacion(OrganizacionModel Organizacion)
        {
            NegocioOrganizacion negocioOrganizacion = new NegocioOrganizacion();
            return negocioOrganizacion.ConsultarOrganizacion(Organizacion);
        }
        [HttpPost("ConsultarOrganizacionNombre")]
        public List<OrganizacionModel> ConsultarOrganizacionNombre(OrganizacionModel Organizacion)
        {
            NegocioOrganizacion negocioOrganizacion = new NegocioOrganizacion();
            return negocioOrganizacion.ConsultarOrganizacionNombre(Organizacion);
        }

        [HttpPost("IngresarOrganizacion")]
        public OrganizacionModel IngresarOrganizacion(OrganizacionModel organizacion)
        {
            return organizacion;
        }
        [HttpPost("ModificarOrganizacion")]
        public OrganizacionModel ModificarOrganizacion(OrganizacionModel organizacion)
        {
            return organizacion;
        }

        [HttpPost("RetirarOrganizacion")]
        public OrganizacionModel RetirarOrganizacion(OrganizacionModel organizacion)
        {
            return organizacion;
        }
      
    }
}
