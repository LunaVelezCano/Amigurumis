using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlAmigurumis.Transaccional.FormaDePago
{
    public class FormaDePagoModel
    {
        public Guid IdFormadePago {  get; set; }
        public string MetodoDePago { get; set; }
        public string Descripcion { get; set; }
        public string resultado { get; set; }
    }
}
