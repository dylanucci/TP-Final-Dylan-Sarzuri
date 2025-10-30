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
using BCrypt.Net;

namespace Application.UseCases.Cliente
{
    public class RegistrarClienteUseCase : ICreate<ClienteDTO>
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public RegistrarClienteUseCase(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ClienteDTO> CreateAsync(ClienteDTO some)
        {
            var passHashed = BCrypt.Net.BCrypt.HashPassword(some.Contraseña);
            some.Contraseña = passHashed;
            var clienteEntity = _mapper.Map<ClienteEntity>(some);
            var clienteEntityCreated = await _repository.CreateAsync(clienteEntity);
            var clienteDTOCreated = _mapper.Map<ClienteDTO>(clienteEntityCreated);
            return clienteDTOCreated;
        }
    }
}
