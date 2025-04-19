using Core.Tasks.Models;

namespace Core.Tasks.Repositories
{
    public interface IDuckTaskRepository
    {
        Task<DuckTask> GetAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
