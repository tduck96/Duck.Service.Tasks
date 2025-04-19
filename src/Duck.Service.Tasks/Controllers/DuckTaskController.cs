using Core.Tasks.Services;
using Microsoft.AspNetCore.Mvc;

namespace Duck.Service.Tasks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DuckTaskController(IDuckTaskService taskService, ILogger<DuckTaskController> logger) : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDuckTask([FromRoute] Guid id, CancellationToken cancellationToken = default)
        {
            var result = await taskService.GetTaskAsync(id, cancellationToken);

            return Ok(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray());
        }
    }
}
