using Microsoft.Extensions.DependencyInjection;
using $ext_projectname$.Domain.Repositories;
using $ext_projectname$.InfraEstructure.Data.Repositories;

namespace $safeprojectname$.InversionOfControl
{
    public static class RepositoryDependency
    {
        public static void AddRepository(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}
