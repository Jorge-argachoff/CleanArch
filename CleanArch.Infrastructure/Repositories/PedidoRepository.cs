using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        AppDbContext _appDbContext;
        public PedidoRepository(AppDbContext context)
        {
                _appDbContext = context;
        }
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pedido>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Pedido> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Pedido> InsertAsync(Pedido entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Pedido entity)
        {
            throw new NotImplementedException();
        }
    }
}
