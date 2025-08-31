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
    public class ClienteRepository : IClienteRepository
    {
        AppDbContext _appDbContext;
        public ClienteRepository(AppDbContext context)
        {
                _appDbContext = context;
        }
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cliente>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> InsertAsync(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
