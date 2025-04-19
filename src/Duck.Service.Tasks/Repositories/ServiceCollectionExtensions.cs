using Core.Tasks.Repositories;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Duck.Service.Tasks.Repositories;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.TryAddTransient<IDuckTaskRepository, DuckTaskRepository>();

        return services;
    }
}
