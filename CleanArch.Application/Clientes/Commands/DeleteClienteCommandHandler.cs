using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Clientes.Commands
{
    public class DeleteClienteCommandHandler : IRequestHandler<DeleteClienteCommand>
    {
        private readonly IUnityOfWork _unityOfWork;

        public DeleteClienteCommandHandler(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public async Task Handle(DeleteClienteCommand request, CancellationToken cancellationToken)
        {
            await _unityOfWork.Clientes.DeleteAsync(request.Id);
            await _unityOfWork.SaveAsync();
        }
    }
}
