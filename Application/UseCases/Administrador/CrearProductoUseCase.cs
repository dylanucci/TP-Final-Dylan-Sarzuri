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
    public class CrearProductoUseCase : ICreate<ProductoDTO>
    {
        private readonly IProductoRepository _repository;
        private readonly IMapper _mapper;

        public CrearProductoUseCase(IProductoRepository repository, IMapper mapper)
        {
            this._mapper = mapper;
            this._repository = repository;
        }
        public async Task<ProductoDTO> CreateAsync(ProductoDTO some)
        {
            var producto = await _repository.CreateAsync(_mapper.Map<ProductoEntity>(some));
            return _mapper.Map<ProductoDTO>(producto);
        }
    }
}
