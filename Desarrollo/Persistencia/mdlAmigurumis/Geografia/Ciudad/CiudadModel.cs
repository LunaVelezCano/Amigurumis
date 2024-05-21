using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Geografia.Ciudad
{
    public class CiudadModel
    {
        public Guid IdCiudad {  get; set; }
        public Guid IdDepartamento { get; set; }
        public string? Nombre { get; set; }
        public Boolean Activo { get; set; }
        public DateTime Actualiza {  get; set; }
        public string resultado { get; set; }
    }
}
