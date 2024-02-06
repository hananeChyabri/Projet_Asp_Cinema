using System;
using System.Collections.Generic;
using System.Text;

namespace Shared_Projet_Cinema.Repositories
{
    public interface IDiffusionRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {
        public IEnumerable<TEntity> GetByCinema(int id);

    }
}
