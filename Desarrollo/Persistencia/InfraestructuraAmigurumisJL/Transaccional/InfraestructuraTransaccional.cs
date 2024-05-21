using mdlAmigurumis.Transaccional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace InfraestructuraAmigurumisJL.Transaccional
{
    public class InfraestructuraTransaccional
    {
        public string ConnectionString { get; set; } = @"mongodb+srv://dbaUsername:dbaPassword@cluster0.dvxojym.mongodb.net/AmigurumisJL?retryWrites=true&w=majority";
        public InfraestructuraTransaccional() { }
        public List<TransaccionalModel> ConsultarTransaccional(TransaccionalModel Transaccional)
        {
            List<TransaccionalModel> listaTransaccional = new List<TransaccionalModel> { Transaccional };

            MongoClient mongoclient = new MongoClient(ConnectionString);
            try
            {
                listaTransaccional = mongoclient.GetDatabase("dbaAmigurumisJL").GetCollection<TransaccionalModel>("Transaccional").AsQueryable().ToList<TransaccionalModel>();
            }
            catch (MongoException ex)
            {
                throw ex;
            }
            return listaTransaccional;
        }
        public TransaccionalModel IngresarTransaccional(TransaccionalModel Transaccional)
        {
            return Transaccional;

        }
        public TransaccionalModel ModificarTransaccional(TransaccionalModel Transaccional)
        {
            return Transaccional;

        }
        public TransaccionalModel RetirarTransaccional(TransaccionalModel Transaccional)
        {
            return Transaccional;

        }
        public List<TransaccionalModel> ConsultarTransaccionalNombre(TransaccionalModel Transaccional)
        {
            List<TransaccionalModel> listaTransaccional = new List<TransaccionalModel> { Transaccional };

            MongoClient mongoclient = new MongoClient(ConnectionString);
            try
            {
                var filter = new BsonDocument { { "NombreMetodoDePago", Transaccional.MetodoDePago } };
                listaTransaccional = mongoclient.GetDatabase("dbaAmigurumisJL")
                    .GetCollection<TransaccionalModel>("Transaccional")
                    .Find(filter)
                    .ToList<TransaccionalModel>();
            }
            catch (MongoException ex)
            {
                throw ex;
            }
            return listaTransaccional;
        }

    }
}
