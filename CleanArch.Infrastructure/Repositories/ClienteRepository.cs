using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        AppDbContext _context;
        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task DeleteAsync(int id)
        {
            var productToDelete = await _context.Clientes.FindAsync(id);
            if (productToDelete != null)
            {
                _context.Clientes.Remove(productToDelete);              
            }
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
           return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> GetByIdAsync(int id)
        {
           var cliente =  await _context.Clientes.FindAsync(id);

            if (cliente == null)
                throw new InvalidCastException("Cliente não encontrado");

            return cliente;
        }

        public async Task<Cliente> InsertAsync(Cliente entity)
        {
             await _context.Clientes.AddAsync(entity);

            return entity;
        }

        public  void Update(Cliente entity)
        {
             _context.Clientes.Update(entity);   
        }
    }
}
