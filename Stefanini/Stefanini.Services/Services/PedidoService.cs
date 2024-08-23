using Stefanini.Domain.Entities;
using Stefanini.Services.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefanini.Services.Services
{
    public class PedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public async Task<Pedido> GetPedidoByIdAsync(int id)
        {
            return await _pedidoRepository.GetByIdAsync(id);
        }

        public async Task<Pedido> CreatePedidoAsync(Pedido pedido)
        {
            return await _pedidoRepository.CreateAsync(pedido);
        }

        public async Task UpdatePedidoAsync(Pedido pedido)
        {
            await _pedidoRepository.UpdateAsync(pedido);
        }

        public async Task DeletePedidoAsync(int id)
        {
            await _pedidoRepository.DeleteAsync(id);
        }
    }
}