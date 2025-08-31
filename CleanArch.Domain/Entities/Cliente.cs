using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public sealed class Cliente : EntityBase
    {
        public Cliente(string nome, string cpf)
        {
            Validar(nome, cpf);
        }
        public string Nome { get; private set; }

        public string CPF { get; private set; }

        private void Validar(string nome, string cpf)
        {
            if (string.IsNullOrEmpty(nome)) throw new ArgumentNullException(nameof(nome));
            if (string.IsNullOrEmpty(CPF)) throw new ArgumentNullException(nameof(cpf));

            Nome = nome;
            CPF = cpf;
        }
    }
}
