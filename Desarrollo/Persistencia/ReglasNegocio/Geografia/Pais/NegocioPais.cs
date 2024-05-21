using mdlAmigurumis.Geografia.Pais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraestructuraAmigurumisJL.Geografia.Pais;

namespace ReglasNegocio.Geografia.Pais
{
    public class NegocioPais
    {
        public NegocioPais() { }

        public PaisModel IngresarPais(PaisModel paismodel)
        {
            InfraestructuraPais infraestructurapais = new InfraestructuraPais();
            return infraestructurapais.IngresarPais(paismodel);
        }
        public PaisModel ModificarPais(PaisModel paismodel)
        {
            InfraestructuraPais infraestructurapais = new InfraestructuraPais();
            return infraestructurapais.ModificarPais(paismodel);
        }
        public PaisModel RetirarPais(PaisModel paismodel)
        {
            InfraestructuraPais infraestructurapais = new InfraestructuraPais();
            return infraestructurapais.RetirarPais(paismodel);
        }
        public List<PaisModel> ConsultarPais(PaisModel paismodel)
        {
            InfraestructuraPais infraestructurapais = new InfraestructuraPais();
            return infraestructurapais.ConsultarPais(paismodel);
        }
        public List<PaisModel> ConsultarPaisId(PaisModel paismodel)
        {
            InfraestructuraPais infraestructurapais = new InfraestructuraPais();
            return infraestructurapais.ConsultarPaisId(paismodel);
        }
        public List<PaisModel> ConsultarPaisNombre(PaisModel paismodel)
        {
            InfraestructuraPais infraestructurapais = new InfraestructuraPais();
            return infraestructurapais.ConsultarPaisNombre(paismodel);
        }

    }
}
