using Core.Tasks.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;


namespace Duck.Service.Tasks.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.TryAddTransient<IDuckTaskService, DuckTaskService>();

        return services;
    }
}
