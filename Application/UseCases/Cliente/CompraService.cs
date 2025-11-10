using Application.DTOs;
using Application.Excepciones;
using Application.Interfaces;
using Application.Interfaces.CRUD;
using Application.Interfaces.UseCases;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Cliente
{
    public class CompraService : IComprasByClienteUseCase, IRealizarCompraUseCase, IFiltrarComprasUseCase, IRead<CompraDTO>
    {
        private readonly ICompraRepository _repository;
        private readonly IMapper _mapper;

        public CompraService(ICompraRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CompraDTO>?> FiltrarComprasAsync(DateTime date1, DateTime date2)
        {
            var comprasEntity = await _repository.FiltrarComprasAsync(date1, date2);
            if (comprasEntity.Count() != 0)
            {
                return _mapper.Map<IEnumerable<CompraDTO>>(comprasEntity);
            }
            else throw new ComprasNotFoundException("No hay compras realizadas por el cliente entre las fechas seleccionadas");
        }

        public async Task<IEnumerable<CompraDTO>> GetAllAsync()
        {
            var compraEntities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<CompraDTO>>(compraEntities);
        }

        public async Task<IEnumerable<CompraDTO>> GetByClienteIdAsync(int Id)
        {
            var comprasEntity = await _repository.GetByClienteIdAsync(Id);
            if (comprasEntity.Count() != 0)
            {
                return _mapper.Map<IEnumerable<CompraDTO>>(comprasEntity);
            }
            else throw new ComprasNotFoundException("No hay compras realizadas por el cliente");
        }

        public async Task<CompraDTO?> GetByIdAsync(int Id)
        {

            var compraEntity = await _repository.GetByIdAsync(Id);
            return _mapper.Map<CompraDTO>(compraEntity);
        }

        public async Task<CompraDTO> RealizarCompra(CompraDTO compra)
        {
            var compraEntity = await _repository.CreateAsync(_mapper.Map<CompraEntity>(compra));
            return _mapper.Map<CompraDTO>(compraEntity);
        }

    }
}
