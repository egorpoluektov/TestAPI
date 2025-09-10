using Microsoft.AspNetCore.Mvc;
using TestAPI.Domain.Entities;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskCardController : ControllerBase
    {
        [HttpGet(Name = "TaskCard")]
        public IEnumerable<TaskCard> GetTaskCard()
        {
            return [];
        }
    }
}
