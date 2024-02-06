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
        private readonly IDiffusionRepository<DAL.Diffusion> _repository;

        public DiffusionService(IDiffusionRepository<DAL.Diffusion> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Diffusion> GetByCinema(int id)
        {
            return _repository.GetByCinema(id).Select(d => d.ToBLL());
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
            throw new NotImplementedException();
        }

        public bool Update(int id, Diffusion data)
        {
            throw new NotImplementedException();
        }
    }
}
