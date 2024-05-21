using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;
using mdlAmigurumis.Geografia.Pais;

namespace InfraestructuraAmigurumisJL.Geografia.Pais
{
    public class InfraestructuraPais
    {
        public SqlConnection connection = null;
        public SqlCommand command = null;
        public SqlDataReader datareader = null;
        public SqlDataAdapter dataadapter = null;
        public DataSet dataset = null;
        public string ConnectionString { get; set; } = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Amigurumis;Integrated Security=True;Persist Security Info=False;Pooling=False;Connect Timeout=30";

        public InfraestructuraPais() { }

        public PaisModel IngresarPais(PaisModel paismodel)
        {
            int cantidad = 0;
            connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "IngresarPais";
                command.Parameters.AddWithValue("@Nombre", paismodel.Nombre);
                cantidad = command.ExecuteNonQuery();

                if (cantidad > 0)
                    paismodel.resultado = "Ingreso Pais Existoso";
                else
                    paismodel.resultado = "Ingreso Pais Fallido";
            }
            catch (SqlException ex)
            {
                paismodel.resultado = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return paismodel;
        }
        public PaisModel ModificarPais(PaisModel paismodel)
        {
            int cantidad = 0;
            connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ModificarPais";
                command.Parameters.AddWithValue("@IdPais", paismodel.IdPais);
                command.Parameters.AddWithValue("@Nombre", paismodel.Nombre);
                cantidad = command.ExecuteNonQuery();

                if (cantidad > 0)
                    paismodel.resultado = "Modificar Pais Existoso";
                else
                    paismodel.resultado = "Modificar Pais Fallido";
            }
            catch (SqlException ex)
            {
                paismodel.resultado = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return paismodel;
        }
        public PaisModel RetirarPais(PaisModel paismodel)
        {
            int cantidad = 0;
            connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "RetirarPais";
                command.Parameters.AddWithValue("@IdPais", paismodel.IdPais);
                cantidad = command.ExecuteNonQuery();

                if (cantidad > 0)
                    paismodel.resultado = "Retirar Pais Existoso";
                else
                    paismodel.resultado = "Retirar Pais Fallido";
            }
            catch (SqlException ex)
            {
                paismodel.resultado = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return paismodel;
        }
        public List<PaisModel> ConsultarPais(PaisModel paismodel)
        {
            List<PaisModel> paislist = new List<PaisModel>();
            connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ConsultarPais";

                dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = command;

                dataset = new DataSet();
                dataadapter.Fill(dataset);

                for(int i = 0; i < dataset.Tables[0].Rows.Count; i++) 
                { 
                    paismodel = new PaisModel();

                    paismodel.IdPais = Guid.Parse(dataset.Tables[0].Rows[i]["IdPais"].ToString());

                    paismodel.Nombre = dataset.Tables[0].Rows[i]["Nombre"].ToString();

                    paismodel.Activo = Convert.ToBoolean(dataset.Tables[0].Rows[i]["Activo"].ToString());

                    paismodel.Actualiza = Convert.ToDateTime(dataset.Tables[0].Rows[i]["Actualiza"].ToString());


                    paislist.Add(paismodel);
                        
                }
            }
            catch (SqlException ex)
            {
                paismodel.resultado = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return paislist;
        }

        public List<PaisModel> ConsultarPaisId(PaisModel paismodel)
        {

            List<PaisModel> paislist = new List<PaisModel>();
            connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ConsultarPaisId";
                command.Parameters.AddWithValue("@IdPais", paismodel.IdPais);

                dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = command;

                dataset = new DataSet();
                dataadapter.Fill(dataset);

                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    paismodel = new PaisModel();

                    paismodel.IdPais = Guid.Parse(dataset.Tables[0].Rows[i]["IdPais"].ToString());

                    paismodel.Nombre = dataset.Tables[0].Rows[i]["Nombre"].ToString();

                    paismodel.Activo = Convert.ToBoolean(dataset.Tables[0].Rows[i]["Activo"].ToString());

                    paismodel.Actualiza = Convert.ToDateTime(dataset.Tables[0].Rows[i]["Actualiza"].ToString());


                    paislist.Add(paismodel);
                }
            }
            catch (SqlException ex)
            {
                paismodel.resultado = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return paislist;
        }


        public List<PaisModel> ConsultarPaisNombre(PaisModel paismodel)
        {
 
            List<PaisModel>paislist = new List<PaisModel>();
            connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ConsultarPaisNombre";
                command.Parameters.AddWithValue("@Nombre", paismodel.Nombre);

                dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = command;

                dataset = new DataSet();
                dataadapter.Fill(dataset);

                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    paismodel = new PaisModel();

                    paismodel.IdPais = Guid.Parse(dataset.Tables[0].Rows[i]["IdPais"].ToString());

                    paismodel.Nombre = dataset.Tables[0].Rows[i]["Nombre"].ToString();

                    paismodel.Activo = Convert.ToBoolean(dataset.Tables[0].Rows[i]["Activo"].ToString());

                    paismodel.Actualiza = Convert.ToDateTime(dataset.Tables[0].Rows[i]["Actualiza"].ToString());


                    paislist.Add(paismodel);
                }
            }
            catch (SqlException ex)
            {
                paismodel.resultado = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return paislist;
        }

    }
}
