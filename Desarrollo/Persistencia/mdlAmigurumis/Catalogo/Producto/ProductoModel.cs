using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Catalogo.Producto
{
    public class ProductoModel
    {
        public Guid IdProducto { get; set; }
        public Guid IdCategoria { get; set; }
        public string Nombre { get; set; }
        public Boolean Activo { get; set; }
        public int UnidadesenExistencia { get; set; }
        public string resultado { get; set; }

    }
}
