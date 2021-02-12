using Microsoft.Extensions.DependencyInjection;
using $ext_projectname$.Interface.Services;
using $ext_projectname$.Service.Service;

namespace $safeprojectname$.InversionOfControl
{
    public static  class ServiceDependency
    {
        public static void AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICustomerService, CustomerService>();
        }
    }
}
