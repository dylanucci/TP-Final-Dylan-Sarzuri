using Application.DTOs;
using Application.Interfaces;
using Application.Interfaces.CRUD;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Cliente
{
    public class ActualizarClienteUseCase : IUpdate<ClienteDTO>
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public ActualizarClienteUseCase(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ClienteDTO> UpdateAsync(ClienteDTO some)
        {
            var clienteUpdated = await _repository.UpdateAsync(_mapper.Map<ClienteEntity>(some));
            return _mapper.Map<ClienteDTO>(clienteUpdated);
        }
    }
}
