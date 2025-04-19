using Core.Tasks.Models;
using Core.Tasks.Repositories;

namespace Duck.Service.Tasks.Repositories;

public class DuckTaskRepository : IDuckTaskRepository
{
    public Task<DuckTask> GetAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
