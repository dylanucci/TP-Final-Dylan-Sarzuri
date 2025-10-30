using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.CRUD
{
    public interface IUpdate<T>
    {
        Task<T> UpdateAsync(T some);
    }
}
