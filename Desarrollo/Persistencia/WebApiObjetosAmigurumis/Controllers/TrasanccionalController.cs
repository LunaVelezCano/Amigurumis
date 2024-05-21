using InfraestructuraAmigurumisJL.Transaccional;
using mdlAmigurumis.Organizacion;
using mdlAmigurumis.Transaccional;
using Microsoft.AspNetCore.Mvc;
using ReglasNegocio.Organizacion;
using ReglasNegocio.Transaccional;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiObjetosAmigurumis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrasanccionalController : ControllerBase
    {
        [HttpPost("ConsultarTransaccion")]
        public List<TransaccionalModel> ConsultarTransaccional(TransaccionalModel Transaccional)
        {
            InfraestructuraTransaccional infraestructuraTransaccional = new InfraestructuraTransaccional();
            return infraestructuraTransaccional.ConsultarTransaccional(Transaccional);
        }

        [HttpPost("IngresarTransaccion")]
        public TransaccionalModel IngresarTransaccion(TransaccionalModel transaccional)
        {
            return transaccional;
        }

        [HttpPost("ModificarTransaccion")]
        public TransaccionalModel ModificarTransaccion(TransaccionalModel transaccional)
        {
            return transaccional;
        }

        [HttpPost("RetirarTransaccion")]
        public TransaccionalModel RetirarTransaccion(TransaccionalModel transaccional)
        {
            return transaccional;
        }

        [HttpPost("ConsultarTransaccionalNombre")]
        public List<TransaccionalModel> ConsultarTransaccionalNombre(TransaccionalModel Transaccional)
        {
            InfraestructuraTransaccional infraestructuraTransaccional = new InfraestructuraTransaccional();
            return infraestructuraTransaccional.ConsultarTransaccionalNombre(Transaccional);
        }
    }
}
