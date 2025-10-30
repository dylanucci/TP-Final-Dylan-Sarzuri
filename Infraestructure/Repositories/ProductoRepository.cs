using Application.Interfaces;
using Application.Interfaces.CRUD;
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
    public class ProductoRepository : IProductoRepository
    {

        private readonly GestionventasContext _context;
        private readonly IMapper _mapper;

        public ProductoRepository(GestionventasContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductoEntity> CreateAsync(ProductoEntity some)
        {
            var productoModel = _mapper.Map<Producto>(some);
            await _context.Productos.AddAsync(productoModel);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductoEntity>(productoModel);
        }

        public async Task DeleteAsync(int Id)
        {
            var productoModel = await _context.Productos.FirstOrDefaultAsync(p=> p.IdProducto == Id);
            _context.Productos.Remove(productoModel);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductoEntity>> GetAllAsync()
        {
            var ProductosModels = await _context.Productos.ToListAsync();
            return _mapper.Map<IEnumerable<ProductoEntity>>(ProductosModels);
        }

        public async Task<ProductoEntity?> GetByIdAsync(int Id)
        {
            var productoModel = await _context.Productos.FirstOrDefaultAsync(p=> p.IdProducto == Id);
            var productoEntity = _mapper.Map<ProductoEntity>(productoModel);
            return productoEntity;
        }

        public async Task<ProductoEntity> UpdateAsync(ProductoEntity some)
        {
            var productoModel = _mapper.Map<Producto>(some);
            _context.Productos.Update(productoModel);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductoEntity>(productoModel);
        }
    }
}
