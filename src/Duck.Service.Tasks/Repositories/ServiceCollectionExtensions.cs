using Microsoft.Extensions.DependencyInjection.Extensions;
using Tasks.Core.Repositories;

namespace Duck.Service.Tasks.Repositories;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.TryAddTransient<IDuckTaskRepository, DuckTaskRepository>();

        return services;
    }
}
