using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.CRUD
{
    public interface ICreate<T>
    {
        Task<T> CreateAsync(T some);
    }
}
