
using Microsoft.AspNetCore.Mvc;
using SmartWorkHub.Domain.Interfaces;

namespace SmartWorkHub.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {

        private readonly ITaskRepository _repository;

        public TestController(ITaskRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("test")]
        public ActionResult Index()
        {
            return Ok("Repository wired");
        }

    }
}