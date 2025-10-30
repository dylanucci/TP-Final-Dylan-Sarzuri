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
    public class EliminarClienteUseCase : IDelete<ClienteDTO>
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public EliminarClienteUseCase(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task DeleteAsync(int Id)
        {
            var cliente = await _repository.GetByIdAsync(Id);
            if (cliente != null)
            {
                await _repository.DeleteAsync(Id);
            }
            else throw new KeyNotFoundException($"Cliente con Id {Id} no existente");
        }
    }
}
