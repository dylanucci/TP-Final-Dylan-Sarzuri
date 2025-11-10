using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.UseCases
{
    public interface IComprasByClienteUseCase
    {
        Task<IEnumerable<CompraDTO>> GetByClienteIdAsync(int Id);
    }
}
