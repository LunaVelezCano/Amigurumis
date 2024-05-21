using mdlAmigurumis.Catalogo;

using mdlAmigurumis.Geografia;
using Microsoft.AspNetCore.Mvc;
using ReglasNegocio.Catalogo;
using ReglasNegocio.Geografia;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiObjetosAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoController : ControllerBase
    {
        [HttpPost("ConsultarCatalogo")]
        public List<CatalogoModel> ConsultarCatalogo(CatalogoModel Catalogo)
        {
            NegocioCatalogo negocioCatalogo = new NegocioCatalogo();
            return negocioCatalogo.ConsultarCatalogo(Catalogo);
        }

        [HttpPost("ConsultarCatalogoNombre")]
        public List<CatalogoModel> ConsultarCatalogoNombre(CatalogoModel Catalogo)
        {
            NegocioCatalogo negocioCatalogo = new NegocioCatalogo();
            return negocioCatalogo.ConsultarCatalogoNombre(Catalogo);
        }

        [HttpPost("IngresarCatalogo")]
        public CatalogoModel IngresarCatalogo(CatalogoModel Catalogo)
        {
            return Catalogo;
        }

        [HttpPost("ModificarCatalogo")]
        public CatalogoModel ModificarCatalogo(CatalogoModel Catalogo)
        {
            return Catalogo;
        }
        [HttpPost("RetirarCatalogo")]
        public CatalogoModel RetirarCatalogo(CatalogoModel Catalogo)
        {
            return Catalogo;
        }
    
    }
}
