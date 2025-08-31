using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanArch.Domain.Entities
{
    public sealed class Produto : EntityBase
    {
        public Produto(int codigoBarras, string nome, decimal preco)
        {
            Validar(CodigoBarras, nome, preco);
        }
        public int CodigoBarras { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }

        private void Validar(int codigoBarras, string nome, decimal preco)
        {
            if (codigoBarras <= 0) throw new ArgumentException(nameof(codigoBarras));
            if (string.IsNullOrEmpty(nome)) throw new ArgumentNullException(nameof(nome));
            if (preco <= 0) throw new ArgumentNullException(nameof(preco));

            CodigoBarras = codigoBarras;
            Nome = nome;
            Preco = preco;
        }
    }
}
