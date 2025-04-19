using Duck.Service.Tasks.Repositories;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Tasks.Core.Interfaces;
using Tasks.Core.Repositories;

namespace Duck.Service.Tasks.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.TryAddTransient<IDuckTaskService, DuckTaskService>();

            return services;
        }
    }
}
