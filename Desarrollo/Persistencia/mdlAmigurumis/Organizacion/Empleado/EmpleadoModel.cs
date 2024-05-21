using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Organizacion.Empleado
{
    public class EmpleadoModel
    {
        public Guid IdEmpleado { get; set; }
        public Guid TipoEmpleado { get; set; }
        public Guid IdSede { get; set; }
        public string TipoDeDocumento { get; set; }
        public string NumerodeDocumento { get; set; }
        public string Nombre {  get; set; }
        public string Apellido { get; set; }
        public Boolean Activo { get; set; }
        public DateTime Actualiza { get; set; }
        public string resultado { get; set; }

    }
}
