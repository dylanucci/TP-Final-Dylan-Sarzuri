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
    public class ActualizarProductoUseCase : IUpdate<ProductoDTO>
    {
        private readonly IProductoRepository _repository;
        private readonly IMapper _mapper;

        public ActualizarProductoUseCase(IProductoRepository repository, IMapper mapper)
        {
            this._mapper = mapper;
            this._repository = repository;
        }

        public async Task<ProductoDTO> UpdateAsync(ProductoDTO some)
        {
            var productoEntity = await _repository.UpdateAsync(_mapper.Map<ProductoEntity>(some));
            return _mapper.Map<ProductoDTO>(productoEntity);
        }
    }
}
