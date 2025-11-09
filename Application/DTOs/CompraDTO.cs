using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CompraDTO
    {
        public int IdCompra { get; set; }

        public int ClienteId { get; set; }

        public DateTime Fecha { get; set; }

        public int? Total { get; set; }

        public virtual ICollection<DetalleDTO> Detalles { get; set; } = new List<DetalleDTO>();
    }
}
