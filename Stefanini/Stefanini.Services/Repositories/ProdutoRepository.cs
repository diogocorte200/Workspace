using Microsoft.EntityFrameworkCore;
using Stefanini.Domain.Entities;
using Stefanini.Infrastructure;
using Stefanini.Services.IRepositories;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefanini.Services.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProdutoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Produto> GetByIdAsync(int id)
        {
            return await _context.Produto.FindAsync(id);
        }

        public async Task<List<Produto>> GetAllAsync()
        {
            return await _context.Produto.ToListAsync();
        }

        public async Task AddAsync(Produto produto)
        {
            await _context.Produto.AddAsync(produto);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Produto produto)
        {
            _context.Produto.Update(produto);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var produto = await _context.Produto.FindAsync(id);
            if (produto != null)
            {
                _context.Produto.Remove(produto);
                await _context.SaveChangesAsync();
            }
        }
    }
}