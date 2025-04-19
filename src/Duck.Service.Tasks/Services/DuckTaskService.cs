using Core.Tasks.Models;
using Core.Tasks.Services;

namespace Duck.Service.Tasks.Services;

public class DuckTaskService : IDuckTaskService
{
    public Task<DuckTask> GetAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
