using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Organizacion.Sede
{
    public class SedeModel
    {
        public Guid IdSede { get; set; }
        public Guid IdAmigurumis { get; set; }
        public Guid IdCiudad { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public Boolean Activo { get; set; }
        public DateTime Actualiza { get; set; }
        public string resultado { get; set; }

    }
}
