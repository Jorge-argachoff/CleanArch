using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Pedidos.Queries
{
    public class GetPedidoByIdQueryHandler : IRequestHandler<GetPedidoByIdQuery, Pedido>
    {
        private readonly IPedidoRepository _pedidoRepository;

        public GetPedidoByIdQueryHandler(IPedidoRepository clienteRepository)
        {
            _pedidoRepository = clienteRepository;
        }

        public async Task<Pedido> Handle(GetPedidoByIdQuery request, CancellationToken cancellationToken)
        {
            var cliente = await _pedidoRepository.GetByIdAsync(request.Id);
            return cliente;
        }
    }
}
