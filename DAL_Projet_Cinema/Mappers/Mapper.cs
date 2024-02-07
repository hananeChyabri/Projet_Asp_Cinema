using DAL_Projet_Cinema.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL_Projet_Cinema.Mappers
{
    internal static class Mapper
    {
        public static CinemaPlace ToCinemaPlace(this IDataRecord record)
        {
            if (record is null) return null;
            return new CinemaPlace()
            {
                Id_CinemaPlace = (int)record["Id_CinemaPlace"],
                Name = (string)record["Name"],
                City = (string)record["City"],
                Street = (string)record["Street"],
                Number = (string)record["Number"],

            };
        }

            public static Movie ToMovie(this IDataRecord record)
            {
                if (record is null) return null;
                return new Movie()
                {
                    Id_Movie = (int)record["Id_Movie"],
                    Title = (string)record["Title"],
                    SubTitle = (string)((record["Subtitle"] == DBNull.Value) ? null : (string?)record["Subtitle"]),
                    ReleaseYear = (short)record["ReleaseYear"],
                    Synopsis = (string)record["Synopsis"],
                    PosterUrl = (string)record["PosterUrl"],
                    Duration = (int)record["Duration"]

                };
            }

        public static Diffusion ToDiffusion(this IDataRecord record)
        {
            if (record is null) return null;
            return new Diffusion()
            {
                Id_Diffusion = (int)record["Id_Diffusion"],
                DiffusionDate = (DateTime)record["DiffusionDate"],
                DiffusionTime = (TimeSpan)record["DiffusionTime"],
                AudioLang = (string)record["AudioLang"],
                SubTitleLang = (string)((record["SubTitleLang"] == DBNull.Value) ? null : (string?)record["SubTitleLang"]),
                Id_CinemaRoom = (int)record["Id_CinemaRoom"],
                Id_Movie = (int)record["Id_Movie"]

            };
        }
    }
    
}
