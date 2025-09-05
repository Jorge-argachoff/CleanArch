using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Clientes.Commands
{
    public class UpdateClienteCommandHandler : IRequestHandler<UpdateClienteCommand, Cliente>
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IValidator<UpdateClienteCommand> _validator;

        public UpdateClienteCommandHandler(IUnityOfWork unityOfWork, IValidator<UpdateClienteCommand> validator = null)
        {
            _unityOfWork = unityOfWork;
            _validator = validator;
        }

        public async  Task<Cliente> Handle(UpdateClienteCommand request, CancellationToken cancellationToken)
        {
             _validator.ValidateAndThrow(request);

            var cliente =  new Cliente(request.Nome,request.CPF);
            cliente.Id = request.Id;

             _unityOfWork.Clientes.Update(cliente);
            await _unityOfWork.SaveAsync();            
            
            return cliente;
        }
    }
}
