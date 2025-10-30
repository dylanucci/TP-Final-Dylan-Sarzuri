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

namespace Application.UseCases.Administrador
{

    public class EliminarProductoUseCase : IDelete<ProductoDTO>
    {
        private readonly IProductoRepository _repository;
        private readonly IMapper _mapper;

        public EliminarProductoUseCase(IProductoRepository repository, IMapper mapper)
        {
            this._mapper = mapper;
            this._repository = repository;
        }
        public async Task DeleteAsync(int Id)
        {
            var producto = await _repository.GetByIdAsync(Id);
            if (producto != null)
            {
                await _repository.DeleteAsync(Id);
            }
            else throw new NotImplementedException();
        }
    }
}
