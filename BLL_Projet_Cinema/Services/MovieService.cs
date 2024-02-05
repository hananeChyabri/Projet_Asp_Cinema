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
        private readonly IMovieRepository<DAL.Movie> _repository;
        public MovieService(IMovieRepository<DAL.Movie> repository)
        {
            _repository = repository;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());
           
        }

        public Movie Get(int id)
        {
            throw new NotImplementedException();

        }

        public int Insert(Movie data)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Movie data)
        {
            throw new NotImplementedException();
        }
    }
}
