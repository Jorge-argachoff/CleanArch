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
    public class GetPedidoQueryHandler : IRequestHandler<GetPedidosQuery, IEnumerable<Pedido>>
    {
        private readonly IPedidoRepository _pedidoRepository;

        public GetPedidoQueryHandler(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public async  Task<IEnumerable<Pedido>> Handle(GetPedidosQuery request, CancellationToken cancellationToken)
        {
            var pedidos = await _pedidoRepository.GetAllAsync();
            return pedidos;
        }
    }
}
