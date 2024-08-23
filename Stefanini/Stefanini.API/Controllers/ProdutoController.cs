using Microsoft.AspNetCore.Mvc;
using Stefanini.Domain.Entities;
using Stefanini.Services.Services;

namespace Stefanini.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _produtoService;

        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetById(int id)
        {
            var produto = await _produtoService.GetByIdAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Produto>>> GetAll()
        //{
        //    var produtos = await _produtoService.GetAllAsync();
        //    return Ok(produtos);
        //}

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Produto produtoDto)
        {
            await _produtoService.AddAsync(produtoDto);
            return CreatedAtAction(nameof(GetById), new { id = produtoDto.Id }, produtoDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] Produto produtoDto)
        {
            if (id != produtoDto.Id)
            {
                return BadRequest();
            }

            await _produtoService.UpdateAsync(produtoDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _produtoService.DeleteAsync(id);
            return NoContent();
        }
    }
}