using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Geografia.Pais
{
    public class PaisModel
    {
        public Guid IdPais { get; set; }
        public string Nombre { get; set; }
        public Boolean Activo { get; set; }
        public DateTime Actualiza {  get; set; }
        public string resultado { get; set; }

    }
}
