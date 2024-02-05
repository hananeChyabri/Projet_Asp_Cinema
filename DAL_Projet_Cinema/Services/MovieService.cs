using DAL_Projet_Cinema.Entities;
using Microsoft.Extensions.Configuration;
using Shared_Projet_Cinema.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using DAL_Projet_Cinema.Mappers;

namespace DAL_Projet_Cinema.Services
{
    public class MovieService : BaseService, IMovieRepository<Movie>
    {
        public MovieService(IConfiguration configuration, string dbname) : base(configuration, dbname)
        {
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Movie_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToMovie();
                        }
                    }
                }

            }
        }

        public Movie Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Movie data)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Movie data)
        {
            throw new NotImplementedException();
        }
    }
}
