using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Clientes.Queries
{
    public class GetClienteByIdQueryHandler : IRequestHandler<GetClienteByIdQuery, Cliente>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly ICacheService _cache;

        public GetClienteByIdQueryHandler(IClienteRepository clienteRepository, ICacheService cache)
        {
            _clienteRepository = clienteRepository;
            _cache = cache;
        }

        public async Task<Cliente> Handle(GetClienteByIdQuery request, CancellationToken cancellationToken)
        {
            string key = $"clienteId-{request.Id}";

            if (await _cache.ExistsAsync(key))
            {
                return await _cache.GetAsync<Cliente>(key);
            }

            var cliente = await _clienteRepository.GetByIdAsync(request.Id);
            Thread.Sleep(1000);

            if (cliente != null)
            {
                await _cache.SetAsync(key, cliente, TimeSpan.FromSeconds(30));
            }

            return cliente;
        }
    }
}
