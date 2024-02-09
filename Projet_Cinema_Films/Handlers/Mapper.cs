using BLL_Projet_Cinema.Entities;
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
            return new CinemaPlace(
            
                0,
                entity.Name,
                entity.city,
                entity.street,
                entity.number);

        
        }

        public static CinemaPlace ToBLL(this CinemaPlaceEditForm entity)
        {
            if (entity is null) return null;
            return new CinemaPlace(

                entity.Id_CinemaPlace,
                entity.Name,
                entity.city,
                entity.street,
                entity.number);

            
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

        public static CinemaPlaceDetailsViewModel ToDetails(this CinemaPlace entity)
        {
            if (entity is null) return null;
            return new CinemaPlaceDetailsViewModel()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
                Street = entity.Street,
                Number = entity.Number,
                Diffusions = entity.Diffusions.Select(d=>d.ToListItem())
            };
        }

        public static DiffusionListItemViewModels ToListItem(this Diffusion entity)
        {
            if (entity is null) return null;
            return new DiffusionListItemViewModels()
            {

                AudioLang = entity.AudioLang,
                DiffusionDate = entity.DiffusionDate,
                DiffusionTime = entity.DiffusionTime,
                TitleMovie = entity.Movie.Title,
                Subtitle = entity.Movie.SubTitle,
                Duration = entity.Movie.Duration,
                TypeProjection = entity.CinemaRoom.Can3D ? "3DX" : "4DX",
                Id_Movie = entity.Id_Movie


            };
        }

   
    

        public static CinemaPlaceEditForm ToEdit(this CinemaPlace entity)
        {
            if (entity is null) return null;
            return new CinemaPlaceEditForm()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                city = entity.City,
                street = entity.Street,
                number = entity.Number,
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

        public static Movie ToBLL(this MovieCreateForm entity)
        {
            if (entity is null) return null;
            return new Movie(

               0,
         entity.Title,
               entity.SubTitle,
               entity.ReleaseYear,
              entity.Synopsis,
              entity.PosterUrl,
               entity.Duration);


        }

        public static MovieDetailsViewModel ToDetails(this Movie entity)
        {
            if (entity is null) return null;
            return new MovieDetailsViewModel()
            {
                Id_Movie = entity.Id_Movie,
                Title = entity.Title,
                SubTitle = entity.SubTitle,
                ReleaseYear = entity.ReleaseYear,
                Synopsis = entity.Synopsis,
                PosterUrl = entity.PosterUrl,
                Duration = entity.Duration,
                Diffusions = entity.Diffusions.Select(d => d.ToListItem())
            };
        }

        public static MovieDeleteForm ToDelete(this Movie entity)
        {
            if (entity is null) return null;
            return new MovieDeleteForm()
            {
                Id_Movie = entity.Id_Movie,
                Title = entity.Title,
                ReleaseYear = entity.ReleaseYear

            };
        }


        #endregion



        #region Diffusion
        /* Diffusion */


        public static Diffusion ToBLL(this DiffusionCreateForm entity)
        {
            if (entity is null) return null;
            return new Diffusion(

                0,
                entity.DiffusionDate,
                entity.DiffusionTime,
                entity.AudioLang,
                entity.SubTitleLang,
                entity.Id_CinemaRoom,
                entity.Id_Movie);

        }
        #endregion


        public static CinemaRoom ToBLL(this CinemaRoomCreateForm entity)
        {
            if (entity is null) return null;
            return new CinemaRoom(

                0,
                entity.SitsCount,
                entity.Number,
                entity.ScreenWidth,
                entity.ScreenHeight,
                entity.Can3D,
                entity.Can4DX,
                entity.Id_cinemaPlace);


        }


    }
}
