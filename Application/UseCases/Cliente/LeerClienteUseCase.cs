using Application.DTOs;
using Application.Interfaces;
using Application.Interfaces.CRUD;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Cliente
{
    public class LeerClienteUseCase : IRead<ClienteDTO>
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public LeerClienteUseCase(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ClienteDTO>> GetAllAsync()
        {
            var clientesEntity = await _repository.GetAllAsync();
            var clientesDTO = _mapper.Map<IEnumerable<ClienteDTO>>(clientesEntity);
            return clientesDTO;

        }

        public async Task<ClienteDTO> GetByIdAsync(int Id)
        {
            var clienteEntity = await _repository.GetByIdAsync(Id);

            if (clienteEntity != null)
            {
                var clienteDTO = _mapper.Map<ClienteDTO>(clienteEntity);
                return clienteDTO;
            }
            else throw new KeyNotFoundException($"Cliente con id {Id} no existente");
            
        }
    }
}
