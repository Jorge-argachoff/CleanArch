using CleanArch.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Clientes.Commands
{
    public class UpdateClienteCommand : IRequest<Cliente>
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string CPF { get; set; }
    }
}
