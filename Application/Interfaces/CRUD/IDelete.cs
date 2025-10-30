using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.CRUD
{
    public interface IDelete<T>
    {
        Task DeleteAsync(int Id);
    }
}
