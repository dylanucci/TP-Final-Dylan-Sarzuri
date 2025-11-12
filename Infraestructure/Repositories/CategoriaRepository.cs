using Application.Interfaces.CRUD;
using AutoMapper;
using Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class CategoriaRepository : IRead<CategoriaEntity>
    {
        private readonly GestionventasContext _context;
        private readonly IMapper _mapper;

        public CategoriaRepository(GestionventasContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoriaEntity>> GetAllAsync()
        {
            var categoriaModel = await _context.Categorias.ToListAsync();
            return _mapper.Map<IEnumerable<CategoriaEntity>>(categoriaModel);
        }

        public Task<CategoriaEntity?> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
