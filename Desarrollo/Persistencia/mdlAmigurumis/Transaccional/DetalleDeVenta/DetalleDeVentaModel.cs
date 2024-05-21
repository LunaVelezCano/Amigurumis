using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Transaccional.DetalleDeVenta
{
    public class DetalleDeVentaModel
    {
        public Guid IdDetalleDeVenta { get; set; }
        public Guid IdVenta { get; set; }
        public Guid IdFormadePago { get; set; }
        public Guid IdCliente { get; set; }
        public Guid IdProducto { get; set; }
        public string Concepto { get; set; }
        public int ValorUnidad { get; set; }
        public int TotalVenta { get; set; }
        public string resultado { get; set; }
    }
}
