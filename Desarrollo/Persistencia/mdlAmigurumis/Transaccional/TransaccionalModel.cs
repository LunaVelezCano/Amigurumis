using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Transaccional
{
    public class TransaccionalModel
    {
         public ObjectId id{ get; set; }
        public string NombreCliente { get; set; }
        public string MetodoDePago { get; set; }
        public int ValorTotalVenta {  get; set; }
        public string Resultado { get; set; }
    }
}
