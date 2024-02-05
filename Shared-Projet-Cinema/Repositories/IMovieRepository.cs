using System;
using System.Collections.Generic;
using System.Text;

namespace Shared_Projet_Cinema.Repositories
{
    public interface IMovieRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {
     
    }
}
