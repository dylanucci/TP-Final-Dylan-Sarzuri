using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; } = null!;

        public int Precio { get; set; }

        public int CategoriaId { get; set; }

    }
}
