﻿using DAL_Projet_Cinema.Entities;
using Projet_Cinema_Films.Models;
using System.ComponentModel;

namespace Projet_Cinema_Films.Handlers
{
    public static class Mapper
    {

        #region CinemaPlace
        public static CinemaPlaceListItemViewModels ToListItem(this CinemaPlace entity)
        {
            if (entity is null) return null;
            return new CinemaPlaceListItemViewModels()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
                Street = entity.Street,
                Number = entity.Number,
            };
        }

        public static CinemaPlace ToBLL(this CinemaPlaceCreateForm entity)
        {
            if (entity is null) return null;
            return new CinemaPlace()
            {
                Id_CinemaPlace = 0,
                Name = entity.Name,
                City = entity.city,
                Street = entity.street,
                Number = entity.number,

            };
        }

        public static CinemaPlace ToBLL(this CinemaPlaceEditForm entity)
        {
            if (entity is null) return null;
            return new CinemaPlace()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.city,
                Street = entity.street,
                Number = entity.number,

            };
        }

        public static CinemaPlaceDelete ToDelete(this CinemaPlace entity)
        {
            if (entity is null) return null;
            return new CinemaPlaceDelete()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name
            };
        }

        public static CinemaPlaceDetails ToDetails(this CinemaPlace entity)
        {
            if (entity is null) return null;
            return new CinemaPlaceDetails()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
                Street = entity.Street,
                Number = entity.Number,
            };
        }

        #endregion

        #region Movie
        public static MovieListItemViewModels ToListItem(this Movie entity)
        {
            if (entity is null) return null;
            return new MovieListItemViewModels()
            {
                Id_Movie = entity.Id_Movie,
                Title = entity.Title,
                Subtitle = entity.SubTitle,
                ReleaseYear = entity.ReleaseYear,
                Synopsis = entity.Synopsis,
                PosterUrl = entity.PosterUrl,
                Duration = entity.Duration
            };
        }



        #endregion

    }
}
