using Application.Interfaces.CRUD;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IClienteRepository : IRead<ClienteEntity>, ICreate<ClienteEntity>, IUpdate<ClienteEntity>, IDelete<ClienteEntity>       
    {
        Task<ClienteEntity?> GetByEmailAsync(string email);
    }
}
