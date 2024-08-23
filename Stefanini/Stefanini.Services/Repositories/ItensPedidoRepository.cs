using Microsoft.EntityFrameworkCore;
using Stefanini.Domain.Entities;
using Stefanini.Infrastructure;
using Stefanini.Services.IRepositories;

namespace Stefanini.Services.Repositories
{
    public class ItensPedidoRepository : IItensPedidoRepository
    {
        private readonly ApplicationDbContext _context;

        public ItensPedidoRepository(ApplicationDbContext context)
        {
            _context = context;
        }


       
                 public async Task<ItensPedido> GetByIdAsync(int id)
        {
            return await _context.ItensPedido
                .FirstOrDefaultAsync(ip => ip.Id == id);
        }

        public async Task<IEnumerable<ItensPedido>> GetAllAsync()
        {
            return await _context.ItensPedido
                .ToListAsync();
        }

        public async Task AddAsync(ItensPedido itensPedido)
        {
            _context.ItensPedido.Add(itensPedido);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ItensPedido itensPedido)
        {
            _context.ItensPedido.Update(itensPedido);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var item = await GetByIdAsync(id);
            if (item != null)
            {
                _context.ItensPedido.Remove(item);
                await _context.SaveChangesAsync();
            }
        }
    }
}