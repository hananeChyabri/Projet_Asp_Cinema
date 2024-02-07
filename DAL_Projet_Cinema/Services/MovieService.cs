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
        public MovieService(IConfiguration configuration) : base(configuration, "DBSlide")
        {
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Movie_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_movie", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'est pas dans la base de données");

                }
            }
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
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Movie_GetById";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_movie", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToMovie();
                        throw new ArgumentOutOfRangeException(nameof(id), $"L'identifiant {id} ne correspond à aucune valeur");
                    }

                }    
            }    
        }

        public int Insert(Movie data)
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Movie_Insert";
                    command.Parameters.AddWithValue("title", data.Title);
                    command.Parameters.AddWithValue("subTitle", (object?)data.SubTitle ?? DBNull.Value);
                    command.Parameters.AddWithValue("releaseYear", data.ReleaseYear);
                    command.Parameters.AddWithValue("synopsis", data.Synopsis);
                    command.Parameters.AddWithValue("posterUrl", data.PosterUrl);
                    command.Parameters.AddWithValue("duration", data.Duration);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(int id, Movie data)
        {
            throw new NotImplementedException();
        }
    }
}
