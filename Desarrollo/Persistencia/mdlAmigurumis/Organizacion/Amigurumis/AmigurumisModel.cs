using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Organizacion.Amigurumis
{
    public class AmigurumisModel
    {
        public Guid IdAmigurumis { get; set; }
        public string NIT { get; set; }
        public string Nombre { get; set;}
        public Boolean Activo { get; set; }
        public DateTime Actualiza { get; set; }
        public string resultado { get; set; }

    }
}
