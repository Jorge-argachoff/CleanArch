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
    public class GetClientesQueryHandler : IRequestHandler<GetClientesQuery, IEnumerable<Cliente>>
    {
        private readonly IClienteRepository _clienteRepository;

        public GetClientesQueryHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async  Task<IEnumerable<Cliente>> Handle(GetClientesQuery request, CancellationToken cancellationToken)
        {
            var clientes = await _clienteRepository.GetAllAsync();
            return clientes;
        }
    }
}
