using Application.DTOs;
using Application.Interfaces.CRUD;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly IRead<ProductoDTO> _readUseCase;
        private readonly ICreate<ProductoDTO> _createUseCase;
        private readonly IUpdate<ProductoDTO> _updateUseCase;
        private readonly IDelete<ProductoDTO> _deleteUseCase;
        private readonly IRead<CategoriaDTO> _readCategoria;
        public ProductosController(IRead<ProductoDTO> readUseCase,ICreate<ProductoDTO> createUseCase,IUpdate<ProductoDTO> updateUseCase,IDelete<ProductoDTO> deleteUseCase, IRead<CategoriaDTO> leerCategoria)
        {
            _readUseCase = readUseCase;
            _createUseCase = createUseCase;
            _updateUseCase = updateUseCase;
            _deleteUseCase = deleteUseCase;
            _readCategoria = leerCategoria; 
        }

        [HttpGet("{Id}")]
        [ActionName("GetProductoById")]
        public async Task<ActionResult<ProductoDTO>> GetById([FromRoute] int Id)
        {
            var productoDTO = await _readUseCase.GetByIdAsync(Id);
            return Ok(productoDTO);
        }
        [HttpGet]
        [ActionName("GetProductos")]
        public async Task<ActionResult<IEnumerable<ProductoDTO>>> GetAll()
        {
            var productosDTO = await _readUseCase.GetAllAsync();
            return Ok(productosDTO);
        }

        [HttpPost]
        [ActionName("CreateProducto")]
        public async Task<ActionResult<ProductoDTO>> Create([FromBody] ProductoDTO productoDTO)
        {
            var productoDTOCreated = await _createUseCase.CreateAsync(productoDTO);
            return Ok(productoDTOCreated);
        }

        [HttpPut]
        [ActionName("UpdateProducto")]
        public async Task<ActionResult<ProductoDTO>> Update([FromBody] ProductoDTO productoDTO)
        {
            var productoDTOUpdated = await _updateUseCase.UpdateAsync(productoDTO);
            return Ok(productoDTOUpdated);
        }

        [HttpDelete("{Id}")]
        [ActionName("DeleteProducto")]
        public async Task<ActionResult> DeleteAsync([FromRoute] int Id)
        {
            await _deleteUseCase.DeleteAsync(Id);
            return Ok();
        }

        [HttpGet("Categorias")]
        [ActionName("GetCategorias")]
        public async Task<ActionResult<IEnumerable<CategoriaDTO>>> GetCategorias()
        {
            var categoriasDTO = await _readCategoria.GetAllAsync();
            return Ok(categoriasDTO);
        }
    }
}
