using mdlAmigurumis.Geografia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraestructuraAmigurumisJL.Geografia;

namespace ReglasNegocio.Geografia
{
    public class NegocioGeografia
    {
        public NegocioGeografia() { }

        public List<GeografiaModel> ConsultarGeografia(GeografiaModel geografia)
        {
            InfrastructuraGeografia infraestructurageografia = new InfrastructuraGeografia();
            return infraestructurageografia.ConsultarGeografia(geografia);
        }

        public List<GeografiaModel> ConsultarGeografiaNombre(GeografiaModel geografia)
        {
            InfrastructuraGeografia infraestructurageografia = new InfrastructuraGeografia();
            return infraestructurageografia.ConsultarGeografiaNombre(geografia);
        }
     
        }
}
