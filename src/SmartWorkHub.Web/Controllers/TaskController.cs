using MediatR;
using Microsoft.AspNetCore.Mvc;
using SmartWorkHub.Application.Features.Tasks.Commands;

namespace SmartWorkHub.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TasksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTaskCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("test")]
        public IActionResult Test() => Ok("MediatR wired!");
    }
}
