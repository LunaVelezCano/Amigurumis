using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Usuario
{
    public class UsuarioModel
    {
        public ObjectId id { get; set; }
        public Guid IdCliente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NumerodeDocumento { get; set; }
        public string? Correo {  get; set; }
        public string? Direccion { get; set; }
        public string? Genero { get; set; }
        public string? TipoDeDocumento { get; set; }
        public string? resultado { get; set; }
    }
}