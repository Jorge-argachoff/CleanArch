using CleanArch.Application.Clientes.Commands;
using CleanArch.Application.Clientes.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClienteController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var clientes = await _mediator.Send(new GetClientesQuery());

            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cliente = await _mediator.Send(new GetClienteByIdQuery() { Id = id });

            return Ok(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateClienteCommand command)
        {
            var cliente = await _mediator.Send(command);

            return Ok(cliente);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] string json)
        {

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteClienteCommand() { Id = id });

            return Ok();
        }
    }
}
