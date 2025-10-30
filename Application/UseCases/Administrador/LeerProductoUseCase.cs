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
    public class LeerProductoUseCase : IRead<ProductoDTO>
    {
        private readonly IProductoRepository _repository;
        private readonly IMapper _mapper;

        public LeerProductoUseCase(IProductoRepository repository, IMapper mapper)
        {
            this._mapper = mapper;
            this._repository = repository;
        }
        public async Task<IEnumerable<ProductoDTO>> GetAllAsync()
        {
            var productos = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductoDTO>>(productos);
        }

        public async Task<ProductoDTO> GetByIdAsync(int Id)
        {
            var producto = await _repository.GetByIdAsync(Id);
            if (producto != null)
            {
                return _mapper.Map<ProductoDTO>(producto);
            }
            else throw new NotImplementedException();
        }
    }
}
