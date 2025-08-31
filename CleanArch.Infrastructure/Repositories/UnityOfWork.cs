using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Context;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        readonly AppDbContext _context;

        IPedidoRepository _pedidosRepository;
        IProdutoRepository _produtosRepository;
        IClienteRepository _clientesRepository;
        IDbContextTransaction _transacation;

        public UnityOfWork(AppDbContext context)
        {
            _context = context;
        }
        public IPedidoRepository Pedidos => _pedidosRepository ??= new PedidoRepository(_context);

        public IProdutoRepository Produtos => _produtosRepository ??= new ProdutoRepository(_context);

        public IClienteRepository Clientes => _clientesRepository ??= new ClienteRepository(_context);

        public async Task BeginTransactionAsync()
        {
            if (_transacation == null)
                _transacation = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            if (_transacation != null)
            {
                await _context.SaveChangesAsync();
                await _transacation.CommitAsync();
                await _transacation.DisposeAsync();
                _transacation = null;
            }
        }

        public async  Task RollbackAsync()
        {
            if (_transacation != null)
            {
                await _transacation.RollbackAsync();
                await _transacation.DisposeAsync();
                _transacation = null;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
