using DAL_Projet_Cinema.Entities;
using System;
using BLL = BLL_Projet_Cinema.Entities;
using DAL = DAL_Projet_Cinema.Entities;


namespace BLL_Projet_Cinema.Mappers
{
    internal static class Mapper
    {
        #region CinemaPlace
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
                Number = entity.Number
            };
        }
        #endregion

        #region Movie
        /*Mappers Movie*/

        public static BLL.Movie ToBLL(this DAL.Movie entity)
        {
            if (entity is null) return null;
            return new BLL.Movie(
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
        #endregion

        #region Diffusion
        /*Mappers Diffusion*/


       

        private static BLL.Languages? toLanguageSubTitlleLang(string subTitleLang)
        {
            if (subTitleLang is null) return null;

            return Enum.Parse<BLL.Languages>(subTitleLang);
        }
        #endregion


        public static BLL.CinemaRoom ToBLL(this DAL.CinemaRoom entity)
        {
            if (entity is null) return null;
            return new BLL.CinemaRoom(
                entity.Id_CinemaRoom,
                entity.SitsCount,
                entity.Number,
                entity.ScreenWidth,
                entity.ScreenHeight,
                entity.Can3D,
                entity.Can4DX,
                entity.Id_CinemaPlace
                );

        }

        public static DAL.CinemaRoom ToDAL(this BLL.CinemaRoom entity)
        {
            if (entity is null) return null;
            return new DAL.CinemaRoom()
            {
                Id_CinemaRoom = entity.Id_CinemaRoom,
                SitsCount = entity.SitsCount,
                Number = entity.Number,
                ScreenWidth = entity.ScreenWidth,
                ScreenHeight = entity.ScreenHeight,
                Can3D = entity.Can3D,
                Can4DX = entity.Can4DX,
                Id_CinemaPlace = entity.Id_CinemaPlace

            };
        }
    }
}
