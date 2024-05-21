using mdlAmigurumis.Geografia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace InfraestructuraAmigurumisJL.Geografia
{
    public class InfrastructuraGeografia
    {
        public string ConnectionString { get; set; } = @"mongodb+srv://dbaUsername:dbaPassword@cluster0.dvxojym.mongodb.net/AmigurumisJL?retryWrites=true&w=majority";
        public InfrastructuraGeografia() { }
        public List<GeografiaModel> ConsultarGeografia(GeografiaModel geografia)
        {
            List<GeografiaModel> listageografia = new List<GeografiaModel> { geografia };

            MongoClient mongoclient = new MongoClient(ConnectionString);
            try
            {
                listageografia = mongoclient.GetDatabase("dbaAmigurumisJL").GetCollection<GeografiaModel>("Geografia").AsQueryable().ToList<GeografiaModel>();
            }
            catch (MongoException ex)
            {
                throw ex;
            }
            return listageografia;
        }
        public GeografiaModel IngresarGeografia(GeografiaModel Geografia)
        {
            return Geografia;

        }
        public GeografiaModel ModificarGeografia(GeografiaModel Geografia)
        {
            return Geografia;

        }
        public GeografiaModel RetirarGeografia(GeografiaModel Geografia)
        {
            return Geografia;

        }
        public List<GeografiaModel> ConsultarGeografiaNombre(GeografiaModel geografia)
        {
            List<GeografiaModel> listageografia = new List<GeografiaModel> { geografia };

            MongoClient mongoclient = new MongoClient(ConnectionString);
            try
            {
                var filter = new BsonDocument { { "NombreCiudad", geografia.NombreCiudad } };
                listageografia = mongoclient.GetDatabase("dbaAmigurumisJL")
                    .GetCollection<GeografiaModel>("Geografia")
                    .Find(filter)
                    .ToList<GeografiaModel>();
            }
            catch (MongoException ex)
            {
                throw ex;
            }
            return listageografia;
        }


    }
}