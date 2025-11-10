using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Excepciones
{
    public class ComprasNotFoundException : Exception
    {
        public ComprasNotFoundException(string? message) :base(message)
        {
        }
    }
}
