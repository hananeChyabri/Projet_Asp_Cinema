using BLL_Projet_Cinema.Entities;
using DAL = DAL_Projet_Cinema.Entities;
using Shared_Projet_Cinema.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using BLL_Projet_Cinema.Mappers;
using System.Linq;

namespace BLL_Projet_Cinema.Services
{
    public class CinemaRoomService : ICinemaRoomRepository<CinemaRoom>
    {
        private readonly ICinemaRoomRepository<DAL.CinemaRoom> _cinemaRoomRepository;

        public CinemaRoomService(ICinemaRoomRepository<DAL.CinemaRoom> cinemaRoomRepository)
        {
            _cinemaRoomRepository = cinemaRoomRepository;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CinemaRoom> Get()
        {
       
            return _cinemaRoomRepository.Get().Select(d => d.ToBLL());
        }

        public CinemaRoom Get(int id)
        {
            return _cinemaRoomRepository.Get(id).ToBLL(); 


        }

        public IEnumerable<CinemaRoom> GetByCinemaPlace(int id)
        {
        
            return _cinemaRoomRepository.GetByCinemaPlace(id).Select(d => d.ToBLL());

        }

        public int Insert(CinemaRoom data)
        {
           return _cinemaRoomRepository.Insert(data.ToDAL());
        }

        public bool Update(int id, CinemaRoom data)
        {
            throw new NotImplementedException();
        }
    }
}
