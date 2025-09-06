using CleanArch.Application.Clientes.Commands;
using CleanArch.Application.Clientes.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var clientes = await _mediator.Send(new GetClientesQuery());

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            var result = new
            {
                Tempo = string.Format("{0:00}:{1:00}:{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds),
                Cliente = clientes
            };
            return Ok(result);
           
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var cliente = await _mediator.Send(new GetClienteByIdQuery() { Id = id });

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            var result = new
            {
                Tempo = string.Format("{0:00}:{1:00}:{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds),
                Cliente = cliente
            };
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateClienteCommand command)
        {
            var cliente = await _mediator.Send(command);

            return Ok(cliente);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateClienteCommand command)
        {
            await _mediator.Send(command);

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
