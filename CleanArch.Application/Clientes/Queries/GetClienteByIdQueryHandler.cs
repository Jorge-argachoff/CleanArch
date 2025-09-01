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

        public GetClienteByIdQueryHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async  Task<Cliente> Handle(GetClienteByIdQuery request, CancellationToken cancellationToken)
        {
            var cliente = await _clienteRepository.GetByIdAsync(request.Id);
            return cliente;
        }
    }
}
