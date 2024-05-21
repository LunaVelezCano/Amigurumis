using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Catalogo.ValoracionProducto
{
    public class ValoracionProductoModel
    {
        public Guid IdValoracionProducto { get; set; }
        public Guid IdCliente { get; set; }
        public Guid IdProducto { get; set; }
        public int Puntuacion { get; set; }
        public string Comentario { get; set; }
        public string resultado { get; set; }
    }
}
