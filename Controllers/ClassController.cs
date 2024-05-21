using final_exam;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/class")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IClassService _classService;

        public ClassController(IClassService classService)
        {
            _classService = classService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddClass([FromBody] AddClassDto addClassDto)
        {
            return Ok(await _classService.AddClass(addClassDto));
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllClasses(
            [FromQuery] FilterPaginationDto paginationDto
        )
        {
            return Ok(await _classService.GetAllClasses(paginationDto));
        }
    }
}
