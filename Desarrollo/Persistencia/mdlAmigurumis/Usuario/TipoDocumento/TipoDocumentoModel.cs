﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Usuario.TipoDocumento
{
    public class TipoDocumentoModel
    {
        public Guid IdTipoDocumento { get; set; }
        public string TipoDeDocumento { get; set; }
        public Boolean Activo { get; set; }
        public DateTime Actualiza { get; set; }
        public string resultado { get; set; }
    }
}
