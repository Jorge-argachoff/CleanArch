using CleanArch.Domain.Entities;
using MediatR;

namespace CleanArch.Application.Pedidos.Commands
{
    public sealed class CreatePedidoCommand : IRequest<Pedido>
    {
        public int Numero { get; set; }
        public DateTime DataPedido { get; set; }
    }
}
