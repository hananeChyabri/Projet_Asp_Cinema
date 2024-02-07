﻿using DAL_Projet_Cinema.Entities;
using System;
using BLL = BLL_Projet_Cinema.Entities;
using DAL = DAL_Projet_Cinema.Entities;


namespace BLL_Projet_Cinema.Mappers
{
    internal static class Mapper
    {
        public static BLL.CinemaPlace ToBLL(this DAL.CinemaPlace entity)
        {
            if (entity is null) return null;
            return new BLL.CinemaPlace(
                entity.Id_CinemaPlace,
                entity.Name,
                entity.City,
                entity.Street,
                entity.Number);
          
        }

   
        public static DAL.CinemaPlace ToDAL(this BLL.CinemaPlace entity)
        {
            if (entity is null) return null;
            return new DAL.CinemaPlace()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
                Street = entity.Street,
                Number = entity.Number            };
        }

        /*Mappers Movie*/

        public static BLL.Movie ToBLL(this DAL.Movie entity)
        {
            if (entity is null) return null;
            return new BLL. Movie(
                entity.Id_Movie,
                entity.Title,
                entity.SubTitle,
                entity.ReleaseYear,
                entity.Synopsis,
                entity.PosterUrl,
                entity.Duration);

        }

        public static DAL.Movie ToDAL(this BLL.Movie entity)
        {
            if (entity is null) return null;
            return new DAL.Movie()
            {
                Id_Movie = entity.Id_Movie,
                Title = entity.Title,
                SubTitle = entity.SubTitle,
                ReleaseYear = entity.ReleaseYear,
                Synopsis = entity.Synopsis,
                PosterUrl = entity.PosterUrl,
                Duration = entity.Duration
            };
        }

        /*Mappers Diffusion*/

        public static BLL.Diffusion ToBLL(this DAL.Diffusion entity)
        {
            if (entity is null) return null;
            return new BLL.Diffusion(
                entity.Id_Diffusion,
                entity.DiffusionDate,
                entity.DiffusionTime,
                Enum.Parse<Languages>(entity.AudioLang),
                toLanguageSubTitlleLang(entity.SubTitleLang),
                entity.Id_CinemaRoom,
                entity.Id_Movie);

        }



        private static Languages? toLanguageSubTitlleLang(string subTitleLang)
        {
            if (subTitleLang is null) return null;

            return Enum.Parse<Languages>(subTitleLang);
        }
    }
}
