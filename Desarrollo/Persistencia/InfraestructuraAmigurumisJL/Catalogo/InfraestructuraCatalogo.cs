using mdlAmigurumis.Catalogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using mdlAmigurumis.Geografia;

namespace InfraestructuraAmigurumisJL.Catalogo
{
    public class InfraestructuraCatalogo
    {
        public string ConnectionString { get; set; } = @"mongodb+srv://dbaUsername:dbaPassword@cluster0.dvxojym.mongodb.net/AmigurumisJL?retryWrites=true&w=majority";
        public InfraestructuraCatalogo() { }
        public List<CatalogoModel> ConsultarCatalogo(CatalogoModel Catalogo)
        {
            List<CatalogoModel> listaCatalogo = new List<CatalogoModel> { Catalogo };

            MongoClient mongoclient = new MongoClient(ConnectionString);
            try
            {
                listaCatalogo = mongoclient.GetDatabase("dbaAmigurumisJL").GetCollection<CatalogoModel>("Catalogo").AsQueryable().ToList<CatalogoModel>();
            }
            catch (MongoException ex)
            {
                throw ex;
            }
            return listaCatalogo;
        }
        public CatalogoModel IngresarCatalogo(CatalogoModel Catalogo)
        {
            return Catalogo;

        }
        public CatalogoModel ModificarCatalogo(CatalogoModel Catalogo)
        {
            return Catalogo;

        }
        public CatalogoModel RetirarCatalogo(CatalogoModel Catalogo)
        {
            return Catalogo;

        }
        public List<CatalogoModel> ConsultarCatalogoNombre(CatalogoModel Catalogo)
        {
            List<CatalogoModel> listaCatalogo = new List<CatalogoModel> { Catalogo };

            MongoClient mongoclient = new MongoClient(ConnectionString);
            try
            {
                var filter = new BsonDocument { { "NombreProducto", Catalogo.NombreProducto } };
                listaCatalogo = mongoclient.GetDatabase("dbaAmigurumisJL")
                    .GetCollection<CatalogoModel>("Catalogo")
                    .Find(filter)
                    .ToList<CatalogoModel>();
            }
            catch (MongoException ex)
            {
                throw ex;
            }
            return listaCatalogo;
        }


    }
}
