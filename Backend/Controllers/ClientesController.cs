using Application.DTOs;
using Application.UseCases.Cliente;
using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.UseCases;
using Application.Interfaces.CRUD;
using Backend.Utilidades;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IRead<ClienteDTO> _readUseCase;
        private readonly ICreate<ClienteDTO> _createUseCase;
        private readonly IUpdate<ClienteDTO> _updateUseCase;
        private readonly IDelete<ClienteDTO> _deleteUseCase;
        private readonly ILoginUseCase _loginUseCase;
        private readonly IRealizarCompra _compraUseCase;

        public ClientesController(IRead<ClienteDTO> readUseCase,ICreate<ClienteDTO> createUseCase,IUpdate<ClienteDTO> updateUseCase,IDelete<ClienteDTO> deleteUseCase,ILoginUseCase loginUseCase,IRealizarCompra compraUseCase)
        {
            _readUseCase = readUseCase;
            _createUseCase = createUseCase;
            _updateUseCase = updateUseCase;
            _deleteUseCase = deleteUseCase;
            _loginUseCase = loginUseCase;
            _compraUseCase = compraUseCase;
        }

        
        [HttpGet("{Id}")]
        [ActionName("GetClienteById")]
        public async Task<ActionResult<ClienteDTO>> GetById([FromRoute] int Id)
        {
            var clienteDTO = await _readUseCase.GetByIdAsync(Id);
            return Ok(clienteDTO);
        }

        [HttpGet]
        [ActionName("GetClientes")]
        public async Task<ActionResult<IEnumerable<ClienteDTO>>> GetAll()
        {
            var clientesDTO = await _readUseCase.GetAllAsync();
            return Ok(clientesDTO);
        }

        [HttpPost]
        [ActionName("CreateCliente")]
        public async Task<ActionResult<ClienteDTO>> Create([FromBody] ClienteDTO clienteDTO)
        {
            var clienteDTOCreated = await _createUseCase.CreateAsync(clienteDTO);
            return Ok(clienteDTOCreated);
        }

        [HttpPut]
        [ActionName("UpdateCliente")]
        public async Task<ActionResult<ClienteDTO>> Update([FromBody] ClienteDTO clienteDTO)
        {
            var clienteDTOUpdated = await _updateUseCase.UpdateAsync(clienteDTO);
            return Ok(clienteDTOUpdated);
        }

        [HttpDelete("{Id}")]
        [ActionName("DeleteCliente")]
        public async Task<ActionResult> DeleteAsync([FromRoute] int Id)
        {
            await _deleteUseCase.DeleteAsync(Id);
            return Ok();
        }

        [HttpPost("MakePurchase")]
        [ActionName("RealizarCompra")]
        public async Task<ActionResult<CompraDTO>> MakePurchase([FromBody] CompraDTO compraDTO)
        {
            var compraDTOCreated = await _compraUseCase.RealizarCompra(compraDTO);
            return Ok(compraDTOCreated);
        }

        [HttpPost("Login")]
        [ActionName("LoginCliente")]
        public async Task<ActionResult<ClienteDTO>> Login([FromBody] LoginRequest loginRequest)
        {
            var clienteDTO = await _loginUseCase.Login(loginRequest.Email, loginRequest.Password);
            return Ok(clienteDTO);
        }

    }
}
