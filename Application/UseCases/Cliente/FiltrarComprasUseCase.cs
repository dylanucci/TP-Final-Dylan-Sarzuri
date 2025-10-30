using Application.DTOs;
using Application.Interfaces;
using Application.Interfaces.UseCases;
using Domain;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Application.UseCases.Cliente
{
    public class FiltrarComprasUseCase : IFiltrarComprasUseCase
    {

        private readonly ICompraRepository _repository;
        private readonly IMapper _mapper;

        public FiltrarComprasUseCase(ICompraRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CompraDTO>> FiltrarComprasAsync(DateOnly date1, DateOnly date2)
        {
            var compras = await _repository.FiltrarComprasAsync(date1, date2);
            if (compras != null)
            {
                return _mapper.Map<IEnumerable<CompraDTO>>(compras);
            }
            else throw new NotImplementedException();
        }
    }
}
