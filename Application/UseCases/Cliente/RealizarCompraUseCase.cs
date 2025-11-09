using Application.DTOs;
using Application.Interfaces;
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
    public class RealizarCompraUseCase : IRealizarCompra
    {
        private readonly ICompraRepository _repository;
        private readonly IMapper _mapper;

        public RealizarCompraUseCase(ICompraRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<CompraDTO> RealizarCompra(CompraDTO compra)
        {
            var compraEntity = await _repository.CreateAsync(_mapper.Map<CompraEntity>(compra));
            return _mapper.Map<CompraDTO>(compraEntity);
        }
        public async Task InsertarDetalles(IEnumerable<DetalleDTO> detalles)
        {

        } 
    }
}
