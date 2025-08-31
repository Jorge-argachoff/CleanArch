using Microsoft.AspNetCore.Mvc;

namespace CleanArch.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string json)
        {

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] string json)
        {

            return Ok();
        }
    }
}
