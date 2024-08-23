using AutoMapper;
using Stefanini.Domain.Entities;
using Stefanini.Services.IRepositories;
using Stefanini.Services.IServices;
using Stefanini.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefanini.Services.Services
{
    public class ItensPedidoService : IItensPedidoService
    {
        private readonly IItensPedidoRepository _repository;

        public ItensPedidoService(IItensPedidoRepository repository)
        {
            _repository = repository;
        }

        public async Task<ItensPedido> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<ItensPedido>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task AddAsync(ItensPedido itensPedido)
        {
            await _repository.AddAsync(itensPedido);
        }

        public async Task UpdateAsync(ItensPedido itensPedido)
        {
            await _repository.UpdateAsync(itensPedido);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}