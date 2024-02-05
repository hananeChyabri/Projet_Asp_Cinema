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
        private readonly ICinemaPlaceRepository<DAL.CinemaPlace> _repository;

        public CinemaPlaceService(ICinemaPlaceRepository<DAL.CinemaPlace> repository)
        {
            _repository = repository;
        }


        public IEnumerable<CinemaPlace> Get()
        {
          return _repository.Get().Select(d=>d.ToBLL());
          
        }

        public int Insert(CinemaPlace data)
        {
            return _repository.Insert(data.ToDAL());
        }

        public CinemaPlace Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }



        public bool Update(int id,CinemaPlace data)
        {
            return _repository.Update(id,data.ToDAL());
        }
        //pas de conversion donc pas besoin de passer par le mapper
        public void Delete(int id)
        {
           _repository.Delete(id);
        }
    }
}

