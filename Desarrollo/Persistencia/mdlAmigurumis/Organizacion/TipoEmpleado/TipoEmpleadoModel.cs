using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Organizacion.TipoEmpleado
{
    public class TipoEmpleadoModel
    {
        public Guid IdTipoEmpleado { get; set; }
        public string Nombre { get; set;}
        public Boolean Activo { get; set; }
        public DateTime Actualiza { get; set; }
        public string resultado { get; set; }
    }
}
