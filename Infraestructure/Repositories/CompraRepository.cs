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
    public class CompraRepository : ICompraRepository
    {

        private readonly GestionventasContext _context;
        private readonly IMapper _mapper;

        public CompraRepository(GestionventasContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CompraEntity> CreateAsync(CompraEntity some)
        {
            var compraModel = _mapper.Map<Compra>(some);
            await _context.Compras.AddAsync(compraModel);
            await _context.SaveChangesAsync();
            var compraEntityCreated = _mapper.Map<CompraEntity>(compraModel);
            return compraEntityCreated;
        }

        public async Task<IEnumerable<CompraEntity>> FiltrarComprasAsync(DateTime date1, DateTime date2)
        {
            var comprasFiltradas = await _context.Compras
                .Where(c => c.Fecha >= date1 && c.Fecha <= date2)
                .ToListAsync();
            return _mapper.Map<IEnumerable<CompraEntity>>(comprasFiltradas);

        }

        public async Task<IEnumerable<CompraEntity>> GetAllAsync()
        {
            var compraModels = await _context.Compras.ToListAsync();
            var compraEntities = _mapper.Map<IEnumerable<CompraEntity>>(compraModels);
            return compraEntities;
        }

        public async Task<IEnumerable<CompraEntity>?> GetByClienteIdAsync(int IdCliente)
        {
            var compraModels = _context.Compras.Where(p => p.ClienteId == IdCliente);
            return _mapper.Map<IEnumerable<CompraEntity>>(compraModels);
        }

        public async Task<CompraEntity?> GetByIdAsync(int Id)
        {
            var compraModel = await _context.Compras.FirstOrDefaultAsync(c=> c.IdCompra == Id);
            var compraEntity = _mapper.Map<CompraEntity>(compraModel);
            return compraEntity;
        }
    }
}
