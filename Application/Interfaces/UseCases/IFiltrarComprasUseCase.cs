using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.UseCases
{
    public interface IFiltrarComprasUseCase
    {
        Task<IEnumerable<CompraDTO>?> FiltrarComprasAsync(DateOnly date1, DateOnly date2);
    }
}
