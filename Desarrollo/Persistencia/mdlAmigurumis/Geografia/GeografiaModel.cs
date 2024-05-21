using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Geografia
{
    public class GeografiaModel
        {public ObjectId id
        { get; set;}
        public Guid IdCiudad { get; set; }
        public string? NombreCiudad { get; set; }
        public Guid IdDepartamento { get; set; }
        public string? NombreDepartamento { get; set; }
        public Guid IdPais { get; set;  }
        public String? NombrePais { get;set; }

    }
}
