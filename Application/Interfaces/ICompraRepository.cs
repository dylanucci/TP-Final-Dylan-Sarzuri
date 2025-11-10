using Application.Interfaces.CRUD;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICompraRepository : IRead<CompraEntity>, ICreate<CompraEntity> 
    {
        Task<IEnumerable<CompraEntity>?> FiltrarComprasAsync(DateTime date1, DateTime date2);
        Task<IEnumerable<CompraEntity>?> GetByClienteIdAsync(int IdCliente);
    }
}
