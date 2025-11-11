using Application.Interfaces;
using AutoMapper;
using Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {

        private readonly GestionventasContext _context;
        private readonly IMapper _mapper;

        public ClienteRepository(GestionventasContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ClienteEntity> CreateAsync(ClienteEntity some)
        {
            var model = _mapper.Map<Cliente>(some);
            await _context.Clientes.AddAsync(model);
            await _context.SaveChangesAsync();
            return _mapper.Map<ClienteEntity>(model);
        }

        public async Task DeleteAsync(int Id)
        {
            var model = await _context.Clientes.FindAsync(Id);
            _context.Clientes.Remove(model);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ClienteEntity>> GetAllAsync()
        {
            var models = await _context.Clientes.ToListAsync();
            return _mapper.Map<IEnumerable<ClienteEntity>>(models);
        }

        public async Task<ClienteEntity?> GetByEmailAsync(string email)
        {
            var model = await _context.Clientes.FirstOrDefaultAsync(c => c.Email == email);
            return _mapper.Map<ClienteEntity>(model);
        }

        public async Task<ClienteEntity?> GetByIdAsync(int Id)
        {
            var model = await _context.Clientes.FirstOrDefaultAsync(c=> c.IdCliente == Id);
            return _mapper.Map<ClienteEntity>(model);
        }

        public async Task<ClienteEntity> UpdateAsync(ClienteEntity some)
        {
            var model = _mapper.Map<Cliente>(some);
            _context.Update(model);
            await _context.SaveChangesAsync();
            return _mapper.Map<ClienteEntity>(model);
        }

    }
}
