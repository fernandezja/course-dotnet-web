//using System.Data.SqlClient;

using Microsoft.Data.SqlClient;
using Starwars.Core.Entities;
using Starwars.Core.Entities.Filters;

namespace Starwars.Core.DataADONet
{
    public class JediRepository
    {
        private StarwarsConfig _starwarsConfig;

        //string connectionString =
        //            "Persist Security Info=True;Initial Catalog=CursoNETWeb;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";



        public JediRepository(StarwarsConfig starwarsConfig) {
            _starwarsConfig = starwarsConfig;
        }


        public List<Jedi> GetAll() {

            var jedis = new List<Jedi>();

            const string QUERY_SQL_JEDI_GET_ALL = @"SELECT JediId, Name, Height, Created, Edited FROM dbo.Jedi";
            //const string QUERY_SQL_JEDI_GET_ALL = @"SELECT JediId, Name, Height, Created, Edited FROM dbo.Jedi WHERE Name LIKE '%'+@Name+'%'";


            //using (var connection = new SqlConnection(connectionString))
            using (var connection = new SqlConnection(_starwarsConfig.StarwarsConnectionString))
            {
                var command = new SqlCommand(QUERY_SQL_JEDI_GET_ALL, connection);
                //command.Parameters.AddWithValue("@Name", filter.Name);


                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var jedi = new Jedi();

                        var jediId = reader.GetInt32(0);
                        var nameDemo1 = reader[1].ToString();
                        var nameDemo2 = reader.GetString(1);

                        jedi.JediId = reader.GetInt32(0);
                        jedi.Name = reader[1].ToString();
                        jedi.Height = reader.GetInt32(2); //Null
                        jedi.Created = reader.GetDateTime(3);
                        jedi.Created = reader.GetDateTime(4);


                        jedis.Add(jedi);
                    }

                    reader.Close();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    //1) Log

                    //2) Retry... 

                    //3) throw exception
                    throw ex;
                }
            }

            return jedis;
        }

        public List<Jedi> Search(JediFilter filter) { 

            var jedis = new List<Jedi>();

            const string QUERY_SQL_JEDI_SEARCH = @"SELECT JediId, Name, Height, Created, Edited FROM dbo.Jedi WHERE (@Name IS NULL OR @Name = '' OR Name LIKE '%'+@Name+'%')";

            using (var connection = new SqlConnection(_starwarsConfig.StarwarsConnectionString))
            {
                var command = new SqlCommand(QUERY_SQL_JEDI_SEARCH, connection);
                command.Parameters.AddWithValue("@Name", filter.Name);


                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var jedi = new Jedi();
                        jedi.JediId = reader.GetInt32(0);
                        jedi.Name = reader[1].ToString();
                        jedi.Height = reader.GetInt32(2); //Null
                        jedi.Created = reader.GetDateTime(3);
                        jedi.Created = reader.GetDateTime(4);

                        jedis.Add(jedi);
                    }

                    reader.Close();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    //1) Log

                    //2) Retry... 

                    //3) throw exception
                    throw ex;
                }
            }

            return jedis;
        }



        public List<Jedi> SearchWithStoreProcedure(JediFilter filter)
        {

            var jedis = new List<Jedi>();

            const string QUERY_SQL_JEDI_SEARCH_STOREPROCEDURE = @"dbo.Jedi_Search";

            using (var connection = new SqlConnection(_starwarsConfig.StarwarsConnectionString))
            {
                var command = new SqlCommand(QUERY_SQL_JEDI_SEARCH_STOREPROCEDURE, connection);
                
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Name", filter.Name);
                command.Parameters.AddWithValue("@PageIndex", filter.PageIndex);
                command.Parameters.AddWithValue("@PageSize", filter.PageSize);
             

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var jedi = new Jedi();
                        jedi.JediId = reader.GetInt32(0);
                        jedi.Name = reader[1].ToString();
                        jedi.Height = reader.GetInt32(2); //Null
                        jedi.Created = reader.GetDateTime(3);
                        jedi.Created = reader.GetDateTime(4);

                        jedis.Add(jedi);
                    }

                    reader.Close();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    //1) Log

                    //2) Retry... 

                    //3) throw exception
                    throw ex;
                }
            }

            return jedis;
        }



        public Jedi Get(int jediId)
        {

            var jedi = new Jedi();

            const string QUERY_SQL_JEDI_GET_STOREPROCEDURE = @"dbo.Jedi_Get";

            using (var connection = new SqlConnection(_starwarsConfig.StarwarsConnectionString))
            {
                var command = new SqlCommand(QUERY_SQL_JEDI_GET_STOREPROCEDURE, connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@JediId", jediId);

              

                try
                {
                    

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        jedi.JediId = reader.GetInt32(0);
                        jedi.Name = reader[1].ToString();
                        jedi.Height = reader.GetInt32(2); //Null
                        jedi.Created = reader.GetDateTime(3);
                        jedi.Edited = reader.GetDateTime(4);

                        
                    }

                    reader.Close();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    //1) Log

                    //2) Retry... 

                    //3) throw exception
                    throw ex;
                }
            }

            return jedi;
        }
    }

}
