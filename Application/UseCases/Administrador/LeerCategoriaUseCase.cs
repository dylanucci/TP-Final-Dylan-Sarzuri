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
    public class LeerCategoriaUseCase : IRead<CategoriaDTO>
    {
        private readonly IRead<CategoriaEntity> _repository;
        private readonly IMapper _mapper;

        public LeerCategoriaUseCase(IRead<CategoriaEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoriaDTO>> GetAllAsync()
        {
            try
            {
                var categoriaEntity = await _repository.GetAllAsync();
                return _mapper.Map<IEnumerable<CategoriaDTO>>(categoriaEntity);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Task<CategoriaDTO?> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
