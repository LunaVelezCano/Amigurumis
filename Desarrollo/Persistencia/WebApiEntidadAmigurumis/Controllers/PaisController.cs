using mdlAmigurumis.Geografia.Pais;
using ReglasNegocio.Geografia.Pais;
using Microsoft.AspNetCore.Mvc;
using ReglasNegocio.Geografia;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntidadAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisController : ControllerBase
    {

    [HttpPost("IngresarPais")]
    public PaisModel IngresarPais(PaisModel pais)
    {
        NegocioPais negociopais = new NegocioPais();
        return negociopais.IngresarPais(pais);
            
    }

    [HttpPost("ModificarPais")]
    public PaisModel ModificarPais(PaisModel pais)
    {
        NegocioPais negociopais = new NegocioPais();
        return negociopais.ModificarPais(pais);
    }
    [HttpPost("RetirarPais")]
    public PaisModel RetirarPais(PaisModel pais)
    {
         NegocioPais negociopais = new NegocioPais();
         return negociopais.RetirarPais(pais);
    }
    [HttpPost("ConsultarPais")]
    public List<PaisModel> ConsultarPais(PaisModel pais)
    {
         NegocioPais negociopais = new NegocioPais();
         return negociopais.ConsultarPais(pais);
    }
        [HttpPost("ConsultarPaisId")]
        public List<PaisModel> ConsultarPaisId(PaisModel pais)
        {
            NegocioPais negociopais = new NegocioPais();
            return negociopais.ConsultarPaisId(pais);
        
    }

    [HttpPost("ConsultarPaisNombre")]
    public List<PaisModel> ConsultarPaisNombre(PaisModel pais)
    {
         NegocioPais negociopais = new NegocioPais();
         return negociopais.ConsultarPaisNombre(pais);
    }
    }
}
