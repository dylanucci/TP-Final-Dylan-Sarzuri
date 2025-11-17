using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CompraEntity : Entity
    {
        public int IdCompra { get; set; }

        public int ClienteId { get; set; }

        public DateTime Fecha { get; set; }

        public int? Total { get; set; }

        public virtual ICollection<DetalleEntity> Detalles { get; set; } = new List<DetalleEntity>();
    }
}
