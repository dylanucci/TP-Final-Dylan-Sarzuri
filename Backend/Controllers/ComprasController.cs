using Application.DTOs;
using Application.Interfaces.CRUD;
using Application.Interfaces.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ComprasController : ControllerBase
    {
        private readonly IComprasByClienteUseCase _comprasByIdCliente;
        private readonly IFiltrarComprasUseCase _filtrarComprasUseCase;
        private readonly IRead<CompraDTO> _compraReadUseCase;

        public ComprasController(IComprasByClienteUseCase com, IFiltrarComprasUseCase fil, IRead<CompraDTO> compraRead)
        {
            _comprasByIdCliente = com;
            _filtrarComprasUseCase = fil;
            _compraReadUseCase = compraRead;
        }
        [HttpGet("/Clientes/{Id}")]
        [ActionName("ComprasByCliente")]
        public async Task<ActionResult<IEnumerable<CompraDTO>>> GetComprasByCliente([FromRoute] int Id)
        {
            var comprasDTO = await _comprasByIdCliente.GetByClienteIdAsync(Id);
            return Ok(comprasDTO);
        }

        [HttpGet("Filtro")]
        [ActionName("FiltrarCompras")]
        public async Task<ActionResult<IEnumerable<CompraDTO>>> FiltrarCompras(DateTime date1, DateTime date2)
        {
            var comprasDTO = await _filtrarComprasUseCase.FiltrarComprasAsync(date1, date2);
            return Ok(comprasDTO);
        }

        [HttpGet]
        [ActionName("GetCompras")]
        public async Task<ActionResult<IEnumerable<CompraDTO>>> GetCompras()
        {
            var comprasDTO = await _compraReadUseCase.GetAllAsync();
            return Ok(comprasDTO);
        }

        [HttpGet("{Id}")]
        [ActionName("GetCompraById")]
        public async Task<ActionResult<CompraDTO>> GetCompraById([FromRoute] int Id)
        {
            var compraDTO = await _compraReadUseCase.GetByIdAsync(Id);
            return Ok(compraDTO);
        }
    }
}
