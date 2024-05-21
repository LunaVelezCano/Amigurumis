using mdlAmigurumis.Catalogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraestructuraAmigurumisJL.Catalogo;


namespace ReglasNegocio.Catalogo
{
    public class NegocioCatalogo
    {
        public NegocioCatalogo() { }

        public List<CatalogoModel> ConsultarCatalogo(CatalogoModel Catalogo)
        {
            InfraestructuraCatalogo infraestructuraCatalogo = new InfraestructuraCatalogo();
            return infraestructuraCatalogo.ConsultarCatalogo(Catalogo);
        }
        public List<CatalogoModel> ConsultarCatalogoNombre(CatalogoModel Catalogo)
        {
            InfraestructuraCatalogo infraestructuraCatalogo = new InfraestructuraCatalogo();
            return infraestructuraCatalogo.ConsultarCatalogoNombre(Catalogo);
        }

    }
}
