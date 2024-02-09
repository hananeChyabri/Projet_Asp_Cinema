using DAL_Projet_Cinema.Entities;
using Microsoft.Extensions.Configuration;
using Shared_Projet_Cinema.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using DAL_Projet_Cinema.Mappers;

namespace DAL_Projet_Cinema.Services
{
    public class DiffusionService : BaseService, IDiffusionRepository<Diffusion>
    {
        public DiffusionService(IConfiguration configuration) : base(configuration, "DBSlide")
        {
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Diffusion> Get()
        {
            throw new NotImplementedException();
        }

        public Diffusion Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Diffusion data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Diffusion_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("diffusionDate", data.DiffusionDate);
                    command.Parameters.AddWithValue("diffusionTime", data.DiffusionTime);
                    command.Parameters.AddWithValue("audioLang", data.AudioLang);
                    command.Parameters.AddWithValue("subtitleLang", data.SubTitleLang);
                    command.Parameters.AddWithValue("id_cinemaRoom", data.Id_CinemaRoom);
                    command.Parameters.AddWithValue("id_movie", data.Id_Movie);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(int id, Diffusion data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Diffusion> GetByCinema(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Diffusion_GetByCinemaPlace";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_cinemaPlace", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToDiffusion();
                        }
                    }
                }

            }
        }


        public IEnumerable<Diffusion> GetByMovie(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM [Diffusion] WHERE [Id_Movie] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToDiffusion();
                        }
                    }
                }
            }
        }
    }
}
