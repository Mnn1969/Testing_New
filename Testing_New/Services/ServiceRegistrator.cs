using Microsoft.Extensions.DependencyInjection;
using Testing_New.Services.Interfaces;

namespace Testing_New.Services
{
    internal static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IDataService, DataService>()
            .AddTransient<IUserDialog, UserDialog>();
    }
}
