using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces
{
    public interface IUnityOfWork
    {
        public IPedidoRepository Pedidos { get; }
        public IProdutoRepository Produtos { get; }
        public IClienteRepository Clientes { get; }

        Task CommitAsync();
        Task RollbackAsync();
        Task BeginTransactionAsync();
        Task SaveAsync();
    }
}
