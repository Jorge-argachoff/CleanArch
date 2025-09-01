using CleanArch.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Pedidos.Commands
{
    public sealed class CreatePedidoCommand:IRequest<Pedido>
    {
        public int Numero { get; set; }
        public DateTime DataPedido { get; set; }
    }
}
