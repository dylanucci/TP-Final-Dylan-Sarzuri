using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DetalleEntity
    {
        public int IdDetalle { get; set; }

        public int CompraId { get; set; }

        public int ProductoId { get; set; }

        public int PrecioUnitario { get; set; }

        public int Cantidad { get; set; }

        public int SubTotal { get; set; }
    }
}
