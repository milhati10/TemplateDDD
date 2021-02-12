using $ext_projectname$.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace $safeprojectname$.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        Task<T> Save(T entity);
        Task<T> GetByID(Guid id);
        Task<IEnumerable<T>> Find(Func<T, bool> func);
        Task<T> Edit(T entity);
    }
}
