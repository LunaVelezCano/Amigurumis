using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Usuario.Genero
{
    public class GeneroModel
    {
        public Guid IdGenero {  get; set; }
        public string Genero { get; set; }
        public Boolean Activo { get; set; }
        public DateTime Actualiza { get; set; }
        public string resultado { get; set; }
    }
}
