using ProjectTemplate.Domain.Entities;
using ProjectTemplate.Domain.Repositories;
using ProjectTemplate.InfraEstructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectTemplate.InfraEstructure.Data.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : Entity
    {
        protected readonly DbContextData DBContextData;

        public BaseRepository(DbContextData dbContextData)
        {
            DBContextData = dbContextData; 
        }

        public Task<T> Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> Find(Func<T, bool> func)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Save(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
