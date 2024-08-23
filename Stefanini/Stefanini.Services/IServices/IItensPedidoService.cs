using Stefanini.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefanini.Services.IServices
{
    public interface IItensPedidoService
    {
        Task<ItensPedido> GetByIdAsync(int id);
        Task<IEnumerable<ItensPedido>> GetAllAsync();
        Task AddAsync(ItensPedido itensPedido);
        Task UpdateAsync(ItensPedido itensPedido);
        Task DeleteAsync(int id);
    }
}
