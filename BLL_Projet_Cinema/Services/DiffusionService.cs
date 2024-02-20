using BLL_Projet_Cinema.Entities;
using DAL = DAL_Projet_Cinema.Entities;
using Shared_Projet_Cinema.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BLL_Projet_Cinema.Mappers;

namespace BLL_Projet_Cinema.Services
{
    
    public class DiffusionService : IDiffusionRepository<Diffusion>
    {
        private readonly IDiffusionRepository<DAL.Diffusion> _diffusionRepository;
        private readonly IMovieRepository<DAL.Movie> _movieRepository;
        private readonly ICinemaRoomRepository<DAL.CinemaRoom> _cinemaRoomRepository;
        private readonly ICinemaPlaceRepository<DAL.CinemaPlace> _cinemaPlaceRepository;

        public DiffusionService(IDiffusionRepository<DAL.Diffusion> diffusionRepository, IMovieRepository<DAL.Movie> movieRepository, ICinemaRoomRepository<DAL.CinemaRoom> cinemaRoomRepository, ICinemaPlaceRepository<DAL.CinemaPlace> cinemaPlaceRepository)
        {
            _diffusionRepository = diffusionRepository;
            _movieRepository = movieRepository;
            _cinemaRoomRepository = cinemaRoomRepository;
            _cinemaPlaceRepository = cinemaPlaceRepository;
        }

        public IEnumerable<Diffusion> GetByCinema(int id)
        {

            return _diffusionRepository.GetByCinema(id).Select(d =>
            {
                Diffusion result = d.ToBLL();
                result.cinemaPlace = _cinemaPlaceRepository.GetByDiffusion(id).ToBLL();
                result.Movie = _movieRepository.Get(result.Id_Movie).ToBLL();
                result.CinemaRoom = _cinemaRoomRepository.Get(result.Id_CinemaRoom).ToBLL();
                result.Id_CinemaPlace = result.cinemaPlace.Id_CinemaPlace;
                return result;
            });


        }

        public IEnumerable<Diffusion> GetByMovie(int id)
        {

            return _diffusionRepository.GetByMovie(id).Select(d =>
            {
                Diffusion result = d.ToBLL();
                result.Movie = _movieRepository.Get(result.Id_Movie).ToBLL();
                result.CinemaRoom = _cinemaRoomRepository.Get(result.Id_CinemaRoom).ToBLL();
                result.cinemaPlace = _cinemaPlaceRepository.GetByDiffusion(id).ToBLL();
                result.Id_CinemaPlace = result.cinemaPlace.Id_CinemaPlace;
                return result;
            });


        }

        public void Delete(int id)
        {
            _diffusionRepository.Delete(id);
        }

        public IEnumerable<Diffusion> Get()
        {
            return _diffusionRepository.Get().Select(d =>
            {
                Diffusion result = d.ToBLL();
                result.cinemaPlace = _cinemaPlaceRepository.GetByDiffusion(result.Id_Diffusion).ToBLL();
                result.Movie = _movieRepository.Get(result.Id_Movie).ToBLL();
                result.CinemaRoom = _cinemaRoomRepository.Get(result.Id_CinemaRoom).ToBLL();
                result.Id_CinemaPlace = result.cinemaPlace.Id_CinemaPlace;
                return result;
            });

        }

        public Diffusion Get(int id)
        {
                Diffusion result = _diffusionRepository.Get(id).ToBLL();
                result.cinemaPlace = _cinemaPlaceRepository.GetByDiffusion(id).ToBLL();
            
                result.Id_CinemaPlace = result.cinemaPlace.Id_CinemaPlace;
                return result;
          
        }

        public int Insert(Diffusion data)
        {
            return _diffusionRepository.Insert(data.ToDAL());
        }

        public bool Update(int id, Diffusion data)
        {
            throw new NotImplementedException();
        }
    }
}
