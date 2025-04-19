using Core.Tasks.Models;

namespace Core.Tasks.Services;

public interface IDuckTaskService
{
    Task<DuckTask> GetAsync(Guid id, CancellationToken cancellationToken = default);
}
