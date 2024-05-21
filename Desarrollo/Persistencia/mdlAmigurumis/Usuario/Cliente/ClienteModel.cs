using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Usuario.Cliente
{
    public class ClienteModel
    {
        public Guid IdCliente { get; set; }
        public Guid IdTipoDocumento { get; set; }
        public Guid IdGenero {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumerodeDocumento { get; set; }
        public string Correo {  get; set; }
        public string Direccion { get; set; }
        public Boolean Activo { get; set; }
        public DateTime Actualiza { get; set; }
        public string resultado { get; set; }
    }
}
