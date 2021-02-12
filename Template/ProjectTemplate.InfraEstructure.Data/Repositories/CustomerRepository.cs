using $ext_projectname$.Domain.Entities;
using $ext_projectname$.Domain.Repositories;
using $ext_projectname$.InfraEstructure.Data.Context;

namespace $safeprojectname$.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContextData dbContextData) : base(dbContextData)
        {
        }
    }
}
