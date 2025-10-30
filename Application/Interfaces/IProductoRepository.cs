using Application.Interfaces.CRUD;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProductoRepository : IRead<ProductoEntity>, ICreate<ProductoEntity>, IUpdate<ProductoEntity>, IDelete<ProductoEntity>
    {
    }
}
