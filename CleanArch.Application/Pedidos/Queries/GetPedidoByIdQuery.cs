using CleanArch.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Pedidos.Queries
{
    public class GetPedidoByIdQuery:IRequest<Pedido>
    {
        public int Id { get; set; }
    }
}
