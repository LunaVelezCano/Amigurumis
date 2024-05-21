using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Catalogo.Categoria
{
    public class CategoriaModel
    {
        public Guid IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string resultado { get; set; }
    }
}
