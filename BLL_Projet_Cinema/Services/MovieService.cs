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
    public class MovieService : IMovieRepository<Movie>
    {
        private readonly IMovieRepository<DAL.Movie> _movieRepository;
        private readonly IDiffusionRepository<Diffusion> _diffusionRepository;

        public MovieService(IMovieRepository<DAL.Movie> movieRepository, IDiffusionRepository<Diffusion> diffusionRepository)
        {
            _movieRepository = movieRepository;
            _diffusionRepository = diffusionRepository;
        }
        public void Delete(int id)
        {
            _movieRepository.Delete(id);
        }

        public IEnumerable<Movie> Get()
        {
            return _movieRepository.Get().Select(d => d.ToBLL());
           
        }

        public Movie Get(int id)
        {
     

            Movie entity = _movieRepository.Get(id).ToBLL();
            IEnumerable<Diffusion> diffusion = _diffusionRepository.GetByMovie(id);
            entity.AddDiffusions(diffusion);
            return entity;

        }

        public int Insert(Movie data)
        {
           return _movieRepository.Insert(data.ToDAL());
        }

        public bool Update(int id, Movie data)
        {
            throw new NotImplementedException();
        }

      
    }
}
