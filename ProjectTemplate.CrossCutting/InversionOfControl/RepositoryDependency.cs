using Microsoft.Extensions.DependencyInjection;
using ProjectTemplate.Domain.Repositories;
using ProjectTemplate.InfraEstructure.Data.Repositories;

namespace ProjectTemplate.InfraEstructure.CrossCutting.InversionOfControl
{
    public static class RepositoryDependency
    {
        public static void AddRepository(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}
