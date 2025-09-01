using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanArch.Domain.Entities
{
    public class Pedido : EntityBase
    {
        public Pedido(int numero)
        {
            Validar(numero);
        }
        public int Numero { get; private set; }
        public DateTime DataPedido { get; private set; }

        public Cliente Cliente { get; set; } // Propriedade de navegação para Cliente
        public ICollection<ItemPedido> ItensPedido { get; set; }
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }

        private void Validar(int numero)
        {
            if (numero <= 0) throw new ArgumentException(nameof(numero));

            Numero = numero;
            DataPedido = DateTime.Now;
        }
    }
}
