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
    public class CreateClienteCommandHandler : IRequestHandler<CreateClienteCommand, Cliente>
    {
        private readonly IUnityOfWork _unityOfWork;

        public CreateClienteCommandHandler(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public async  Task<Cliente> Handle(CreateClienteCommand request, CancellationToken cancellationToken)
        {
            var cliente =  new Cliente(request.Nome,request.CPF);
            
            await _unityOfWork.Clientes.InsertAsync(cliente);
            await _unityOfWork.SaveAsync();
            
            
            return cliente;
        }
    }
}
