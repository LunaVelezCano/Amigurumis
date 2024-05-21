using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Transaccional.Venta
{
    public class VentaModel
    {
        public Guid IdVenta { get; set; }
        public Guid IdEmpleado { get; set; }
        public Guid IdCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public int TotalVenta { get; set; }
        public string resultado { get; set; }
    }
}
