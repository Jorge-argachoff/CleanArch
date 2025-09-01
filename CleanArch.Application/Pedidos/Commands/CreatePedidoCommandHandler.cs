using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Pedidos.Commands
{
    public class CreatePedidoCommandHandler : IRequestHandler<CreatePedidoCommand,Pedido>
    {
        private readonly IUnityOfWork _unityOfWork;

        public CreatePedidoCommandHandler(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

      

        public async Task<Pedido> Handle(CreatePedidoCommand request, CancellationToken cancellationToken)
        {
            var pedido = new Pedido(request.Numero);

            await _unityOfWork.Pedidos.InsertAsync(pedido);
            await _unityOfWork.SaveAsync();

            return pedido;
           
        }

       
    }
}
