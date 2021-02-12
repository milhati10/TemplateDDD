using ProjectTemplate.Domain.Entities;
using ProjectTemplate.Domain.Repositories;
using ProjectTemplate.InfraEstructure.Data.Context;

namespace ProjectTemplate.InfraEstructure.Data.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContextData dbContextData) : base(dbContextData)
        {
        }
    }
}
