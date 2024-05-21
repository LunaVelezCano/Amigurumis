using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Organizacion
{
    public class OrganizacionModel
    {
        public ObjectId id
        { get; set; }
        public String? NombreAmigurumis { get; set; }
        public String? NombreSede {  get; set; }
        public String? NombreEmpleado { get; set; }
        public String? TipoEmpleado { get; set; }
        public string Resultado { get; set; }
    }
}