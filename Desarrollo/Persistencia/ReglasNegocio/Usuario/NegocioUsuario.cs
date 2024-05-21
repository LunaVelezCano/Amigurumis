using mdlAmigurumis.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraestructuraAmigurumisJL.Usuario;

namespace ReglasNegocio.Usuario
{
    public class NegocioUsuario
    {
        public NegocioUsuario() { }

        public List<UsuarioModel> ConsultarUsuario(UsuarioModel Usuario)
        {
            InfraestructuraUsuario infraestructuraUsuario = new InfraestructuraUsuario();
            return infraestructuraUsuario.ConsultarUsuario(Usuario);
        }
        public List<UsuarioModel> ConsultarUsuarioNombre(UsuarioModel Usuario)
        {
            InfraestructuraUsuario infraestructuraUsuario = new InfraestructuraUsuario();
            return infraestructuraUsuario.ConsultarUsuarioNombre(Usuario);
        }
    }
}
