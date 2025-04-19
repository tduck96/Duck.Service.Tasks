#nullable enable

namespace Core.Tasks.Models;

public class DuckTask
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

    public DateTime? DueDate { get; set; }

    public bool IsCompleted { get; set; }
}
