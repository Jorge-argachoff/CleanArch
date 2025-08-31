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
    public class ProdutoRepository : IProdutoRepository
    {
        AppDbContext _appDbContext;
        public ProdutoRepository(AppDbContext context)
        {
                _appDbContext = context;
        }
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Produto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> InsertAsync(Produto entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Produto entity)
        {
            throw new NotImplementedException();
        }
    }
}
