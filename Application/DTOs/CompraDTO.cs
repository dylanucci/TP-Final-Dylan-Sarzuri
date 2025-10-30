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

        public DateOnly Fecha { get; set; }

        public string? Total { get; set; }

        public virtual ClienteEntity Cliente { get; set; } = null!;

        public virtual ICollection<DetalleEntity> Detalles { get; set; } = new List<DetalleEntity>();
    }
}
