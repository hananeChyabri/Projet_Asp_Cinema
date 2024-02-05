using System;
using System.Collections.Generic;
using System.Text;
using DAL_Projet_Cinema.Entities;
using Shared_Projet_Cinema.Repositories;
using System.Data.SqlClient;
using System.Data;
using DAL_Projet_Cinema.Mappers;
using Microsoft.Extensions.Configuration;

namespace DAL_Projet_Cinema.Services
{
    public class CinemaPlaceService : BaseService, ICinemaPlaceRepository<CinemaPlace>
    {
        public CinemaPlaceService(IConfiguration configuration) : base(configuration, "DBSlide")
        {
        }
        public IEnumerable<CinemaPlace> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaPlace_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToCinemaPlace();
                        }
                    }
                }

            }
        }

        public int Insert(CinemaPlace data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaPlace_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("name", data.Name);
                    command.Parameters.AddWithValue("city", data.City);
                    command.Parameters.AddWithValue("street", data.Street);
                    command.Parameters.AddWithValue("number", data.Number);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public CinemaPlace Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaPlace_GetById";
                    command.CommandType= CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_cinemaPlace", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToCinemaPlace();
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                    }

                }
            }
        }

        public bool Update(int id, CinemaPlace data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaPlace_Update";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_cinemaPlace",id);
                    command.Parameters.AddWithValue("name", data.Name);
                    command.Parameters.AddWithValue("city", data.City);
                    command.Parameters.AddWithValue("street", data.Street);
                    command.Parameters.AddWithValue("number", data.Number);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_CinemaPlace), $"L'identifiant {data.Id_CinemaPlace} n'est pas das la base de données");
                    return command.ExecuteNonQuery() > 0;
                }

            }
          
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaPlace_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_cinemaPlace", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'est pas dans la base de données");
                }
            }
        }
    }
}
