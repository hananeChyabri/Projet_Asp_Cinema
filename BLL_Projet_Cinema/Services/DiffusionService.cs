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

        public DiffusionService(IDiffusionRepository<DAL.Diffusion> diffusionRepository, IMovieRepository<DAL.Movie> movieRepository, ICinemaRoomRepository<DAL.CinemaRoom> cinemaRoomRepository)
        {
            _diffusionRepository = diffusionRepository;
            _movieRepository = movieRepository;
            _cinemaRoomRepository = cinemaRoomRepository;
        }

        public IEnumerable<Diffusion> GetByCinema(int id)
        {

            //return _diffusionRepository.GetByCinema(id).Select(d => d.ToBLL()
              
            //);


            return _diffusionRepository.GetByCinema(id).Select(d =>
            {
                Diffusion result = d.ToBLL();
                result.Movie = _movieRepository.Get(result.Id_Movie).ToBLL();
                result.CinemaRoom = _cinemaRoomRepository.Get(result.Id_CinemaRoom).ToBLL();
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
                return result;
            });


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
            return _diffusionRepository.Insert(data.ToDAL());
        }

        public bool Update(int id, Diffusion data)
        {
            throw new NotImplementedException();
        }
    }
}
