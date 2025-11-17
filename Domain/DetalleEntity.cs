using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DetalleEntity : Entity
    {
        public int IdDetalle { get; set; }

        public int CompraId { get; set; }

        public int ProductoId { get; set; }

        private int _precioUnitario;
        private int _cantidad;

        public int PrecioUnitario
        {
            get { return _precioUnitario; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El precio unitario no puede ser negativo.");
                _precioUnitario = value;
            }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("La cantidad no puede ser negativa.");
                _cantidad = value;
            }
        }

        public int SubTotal { get; set; }
    }
}
