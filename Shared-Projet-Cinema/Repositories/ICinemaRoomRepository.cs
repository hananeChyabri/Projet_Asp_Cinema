using System;
using System.Collections.Generic;
using System.Text;

namespace Shared_Projet_Cinema.Repositories
{
    public interface ICinemaRoomRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {

        public IEnumerable<TEntity> GetByCinemaPlace(int id);
    }
}
