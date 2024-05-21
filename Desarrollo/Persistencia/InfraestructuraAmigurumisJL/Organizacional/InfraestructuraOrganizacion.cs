using mdlAmigurumis.Organizacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using mdlAmigurumis.Geografia;

namespace InfraestructuraAmigurumisJL.Organizacional
{
    public class InfraestructuraOrganizacion
    {
        public string ConnectionString { get; set; } = @"mongodb+srv://dbaUsername:dbaPassword@cluster0.dvxojym.mongodb.net/AmigurumisJL?retryWrites=true&w=majority";
        public InfraestructuraOrganizacion() { }
        public List<OrganizacionModel> ConsultarOrganizacion(OrganizacionModel Organizacion)
        {
            List<OrganizacionModel> listaOrganizacion = new List<OrganizacionModel> { Organizacion };

            MongoClient mongoclient = new MongoClient(ConnectionString);
            try
            {
                listaOrganizacion = mongoclient.GetDatabase("dbaAmigurumisJL").GetCollection<OrganizacionModel>("Organizacion").AsQueryable().ToList<OrganizacionModel>();
            }
            catch (MongoException ex)
            {
                throw ex;
            }
            return listaOrganizacion;
        }
        public OrganizacionModel IngresarOrganizacion(OrganizacionModel Organizacion)
        {
            return Organizacion;
        }
        public OrganizacionModel ModificarOrganizacion(OrganizacionModel Organizacion)
        {
            return Organizacion;
        }
        public OrganizacionModel RetirarOrganizacion(OrganizacionModel Organizacion)
        {
            return Organizacion;
        }
        public List<OrganizacionModel> ConsultarOrganizacionNombre(OrganizacionModel Organizacion)
        {
            List<OrganizacionModel> listaOrganizacion = new List<OrganizacionModel> { Organizacion };

            MongoClient mongoclient = new MongoClient(ConnectionString);
            try
            {
                var filter = new BsonDocument { { "NombreSede", Organizacion.NombreSede } };
                listaOrganizacion = mongoclient.GetDatabase("dbaAmigurumisJL")
                    .GetCollection<OrganizacionModel>("Organizacion")
                    .Find(filter)
                    .ToList<OrganizacionModel>();
            }
            catch (MongoException ex)
            {
                throw ex;
            }
            return listaOrganizacion;
        }
    }
}
