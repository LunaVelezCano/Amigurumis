using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Transaccional.Pedido
{
    public class PedidoModel
    {
        public Guid IdPedido { get; set; }
        public Guid IdVenta { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string DireccionEntrega { get; set; }
        public string Estado {  get; set; }
        public string resultado { get; set; }
    }
}
