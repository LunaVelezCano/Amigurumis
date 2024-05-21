using mdlAmigurumis.Organizacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraestructuraAmigurumisJL.Organizacional;

namespace ReglasNegocio.Organizacion
{
    public class NegocioOrganizacion
    {
        public NegocioOrganizacion() { }

        public List<OrganizacionModel> ConsultarOrganizacion(OrganizacionModel Organizacion)
        {
            InfraestructuraOrganizacion infraestructuraOrganizacion = new InfraestructuraOrganizacion();
            return infraestructuraOrganizacion.ConsultarOrganizacion(Organizacion);
        }
        public List<OrganizacionModel> ConsultarOrganizacionNombre(OrganizacionModel Organizacion)
        {
            InfraestructuraOrganizacion infraestructuraOrganizacion = new InfraestructuraOrganizacion();
            return infraestructuraOrganizacion.ConsultarOrganizacionNombre(Organizacion);
        }

    }
}
