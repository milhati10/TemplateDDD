using Microsoft.Extensions.DependencyInjection;
using ProjectTemplate.Interface.Services;
using ProjectTemplate.Service.Service;

namespace ProjectTemplate.InfraEstructure.CrossCutting.InversionOfControl
{
    public static  class ServiceDependency
    {
        public static void AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICustomerService, CustomerService>();
        }
    }
}
