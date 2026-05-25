using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkFlowProNew.API.DTOs.Project;
using WorkFlowProNew.API.Interfaces;

namespace WorkFlowProNew.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : Controller
    {

        private readonly IProjectService _service;

        public ProjectController(IProjectService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create(CreateProjectDto request)
        {
            _service.Create(request);

            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(
                _service.GetAll());
        }


        [HttpGet("{id}")]
        public IActionResult GetById(
            int id)
        {
            var result =
                _service.GetById(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

    }
}
