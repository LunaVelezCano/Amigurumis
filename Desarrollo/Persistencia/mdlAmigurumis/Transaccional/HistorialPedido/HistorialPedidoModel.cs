using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Transaccional.HistorialPedido
{
    public class HistorialPedidoModel
    {
        public Guid IdHistorialPedido { get; set; }
        public Guid IdCliente { get; set; }
        public Guid IdPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public int ValorTotalPedido { get; set; }
        public string resultado { get; set; }
    }
}
