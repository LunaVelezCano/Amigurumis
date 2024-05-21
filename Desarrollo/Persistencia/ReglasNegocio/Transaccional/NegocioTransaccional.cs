using mdlAmigurumis.Transaccional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraestructuraAmigurumisJL.Transaccional;

namespace ReglasNegocio.Transaccional
{
    public class NegocioTransaccional
    {
        public NegocioTransaccional() { }

        public List<TransaccionalModel> ConsultarTransaccional(TransaccionalModel Transaccional)
        {
            InfraestructuraTransaccional infraestructuraTransaccional = new InfraestructuraTransaccional();
            return infraestructuraTransaccional.ConsultarTransaccional(Transaccional);
        }
        public List<TransaccionalModel> ConsultarTransaccionalNombre(TransaccionalModel Transaccional)
        {
            InfraestructuraTransaccional infraestructuraTransaccional = new InfraestructuraTransaccional();
            return infraestructuraTransaccional.ConsultarTransaccionalNombre(Transaccional);
        }
    }
}
