using mdlAmigurumis.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace InfraestructuraAmigurumisJL.Usuario
{
    public class InfraestructuraUsuario
    {
        public string ConnectionString { get; set; } = @"mongodb+srv://dbaUsername:dbaPassword@cluster0.dvxojym.mongodb.net/AmigurumisJL?retryWrites=true&w=majority";
        public InfraestructuraUsuario() { }
        public List<UsuarioModel> ConsultarUsuario(UsuarioModel Usuario)
        {
            List<UsuarioModel> listaUsuario = new List<UsuarioModel> { Usuario };

            MongoClient mongoclient = new MongoClient(ConnectionString);
            try
            {
                listaUsuario = mongoclient.GetDatabase("dbaAmigurumisJL").GetCollection<UsuarioModel>("Usuario").AsQueryable().ToList<UsuarioModel>();
            }
            catch (MongoException ex)
            {
                throw ex;
            }
            return listaUsuario;
        }
        public UsuarioModel IngresarUsuario(UsuarioModel Usuario)
        {
            return Usuario;

        }
        public UsuarioModel ModificarUsuario(UsuarioModel Usuario)
        {
            return Usuario;

        }
        public UsuarioModel RetirarUsuario(UsuarioModel Usuario)
        {
            return Usuario;

        }
        public List<UsuarioModel> ConsultarUsuarioNombre(UsuarioModel Usuario)
        {
            List<UsuarioModel> listaUsuario = new List<UsuarioModel> { Usuario };

            MongoClient mongoclient = new MongoClient(ConnectionString);
            try
            {
                var filter = new BsonDocument { { "Nombre", Usuario.Nombre } };
                listaUsuario = mongoclient.GetDatabase("dbaAmigurumisJL")
                    .GetCollection<UsuarioModel>("Usuario")
                    .Find(filter)
                    .ToList<UsuarioModel>();
            }
            catch (MongoException ex)
            {
                throw ex;
            }
            return listaUsuario;
        }
    }
}
