using CleanArch.Application.Clientes.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Clientes.Validators
{
    public class UpdateClienteCommandValidator : AbstractValidator<UpdateClienteCommand>
    {
        public UpdateClienteCommandValidator()
        {
            RuleFor(x => x.Id).NotNull()
            .GreaterThan(0)
            .WithMessage("O ID é invalido");

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Nome não pode ser vazio")
                .Length(1, 200).WithMessage("Nome deve conter entre 1 e 200 caracteres");

            RuleFor(c => c.CPF).NotEmpty().WithMessage("CPF não pode ser vazio")
                                .MinimumLength(11).WithMessage("CPF deve conter 11 caracteres");
                            
        }
    }
}
