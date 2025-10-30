using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class DetalleDTO
    {
        public int IdDetalle { get; set; }

        public int CompraId { get; set; }

        public int ProductoId { get; set; }

        public int PrecioUnitario { get; set; }

        public int Cantidad { get; set; }

        public int SubTotal => PrecioUnitario * Cantidad;
    }
}
