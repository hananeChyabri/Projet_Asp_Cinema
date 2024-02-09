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
    public class CinemaRoomService : BaseService, ICinemaRoomRepository<CinemaRoom>
    {
        public CinemaRoomService(IConfiguration configuration) : base(configuration, "DBSlide")
        {
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CinemaRoom> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaRoom_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToCinemaRoom();
                        }
                    }
                }

            }
        }

        public CinemaRoom Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaRoom_GetById";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_cinemaroom", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToCinemaRoom();
                           
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                    }

                }
            }
        }

        public int Insert(CinemaRoom data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_CinemaRoom_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("seatsCount", data.SitsCount);
                    command.Parameters.AddWithValue("number", data.Number);
                    command.Parameters.AddWithValue("screenWidth", data.ScreenWidth);
                    command.Parameters.AddWithValue("screenHeight", data.ScreenHeight);
                    command.Parameters.AddWithValue("can3D", data.Can3D);
                    command.Parameters.AddWithValue("can4DX", data.Can4DX);
                    command.Parameters.AddWithValue("id_cinemaPlace",data.Id_CinemaPlace);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(int id, CinemaRoom data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CinemaRoom> GetByCinemaPlace(int id)
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT DISTINCT  * FROM [CinemaRoom] WHERE [Id_CinemaPlace] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToCinemaRoom();
                        }
                    }
                }
            }

        }
    }
}
