using BLL_Projet_Cinema.Entities;
using DAL = DAL_Projet_Cinema.Entities;
using System;
using System.Collections.Generic;
using Shared_Projet_Cinema.Repositories;
using System.Linq;
using BLL_Projet_Cinema.Mappers;

namespace BLL_Projet_Cinema.Services
{
    public class CinemaPlaceService : ICinemaPlaceRepository<CinemaPlace>
    {
        private readonly ICinemaPlaceRepository<DAL.CinemaPlace> _cinemaPlacerepository;
        private readonly IDiffusionRepository<DAL.Diffusion> _diffusionRepository;

        public CinemaPlaceService(ICinemaPlaceRepository<DAL.CinemaPlace> cinemaPlacerepository, IDiffusionRepository<DAL.Diffusion> diffusionRepository)
        {
            _cinemaPlacerepository = cinemaPlacerepository;
            _diffusionRepository = diffusionRepository;
        }


        public IEnumerable<CinemaPlace> Get()
        {
           return _cinemaPlacerepository.Get().Select(d=>d.ToBLL());
        }

        public CinemaPlace Get(int id)
        {
            CinemaPlace entity = _cinemaPlacerepository.Get(id).ToBLL();
            entity.AddDiffusions(_diffusionRepository.GetByCinema(id).Select(d => d.ToBLL()));
            return entity;

        }

        public int Insert(CinemaPlace data)
        {
            return _cinemaPlacerepository.Insert(data.ToDAL());
        }

      



        public bool Update(int id,CinemaPlace data)
        {
            return _cinemaPlacerepository.Update(id,data.ToDAL());
        }
        //pas de conversion donc pas besoin de passer par le mapper
        public void Delete(int id)
        {
            _cinemaPlacerepository.Delete(id);
        }
    }
}

