using AutoMapper;
using Stefanini.Domain.Entities;
using Stefanini.Services.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefanini.Services.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public async Task<Produto> GetByIdAsync(int id)
        {
            var produto = await _produtoRepository.GetByIdAsync(id);
            return _mapper.Map<Produto>(produto);
        }

        //public async Task<List<Produto>> GetAllAsync()
        //{
        //    var produtos = await _produtoRepository.GetAllAsync();
        //    return _mapper.Map<IEnumerable<Produto>>(produtos);
        //}

        public async Task AddAsync(Produto produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            await _produtoRepository.AddAsync(produto);
        }

        public async Task UpdateAsync(Produto produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            await _produtoRepository.UpdateAsync(produto);
        }

        public async Task DeleteAsync(int id)
        {
            await _produtoRepository.DeleteAsync(id);
        }
    }
}

