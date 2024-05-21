using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Catalogo
{
    public class CatalogoModel
    {
        public ObjectId id { get; set; }
        public string? NombreCategoria { get; set; }
        public string? NombreProducto { get; set; }
        public int? Valoracion { get; set; }
        public string? ComentarioValoracion { get; set; }
        public string? NombreCliente { get; set; }
        public string Resultado { get; set; }
    }
}
