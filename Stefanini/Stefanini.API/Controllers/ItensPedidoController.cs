using Microsoft.AspNetCore.Mvc;
using Stefanini.Domain.Entities;
using Stefanini.Services.IServices;
using Stefanini.Services.Services;


namespace Stefanini.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItensPedidoController : ControllerBase
    {
        private readonly IItensPedidoService _itensPedidoService;

        public ItensPedidoController(IItensPedidoService itensPedidoService)
        {
            _itensPedidoService = itensPedidoService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _itensPedidoService.GetByIdAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var itensPedidos = await _itensPedidoService.GetAllAsync();
            return Ok(itensPedidos);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ItensPedido itensPedido)
        {
            await _itensPedidoService.AddAsync(itensPedido);
            return CreatedAtAction(nameof(GetById), new { id = itensPedido.Id }, itensPedido);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ItensPedido itensPedido)
        {
            if (id != itensPedido.Id)
            {
                return BadRequest();
            }

            await _itensPedidoService.UpdateAsync(itensPedido);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _itensPedidoService.DeleteAsync(id);
            return NoContent();
        }
    }
}