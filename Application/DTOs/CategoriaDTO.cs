using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CategoriaDTO
    {
        public int IdCategoria { get; set; }

        public string Nombre { get; set; } = null!;

        public virtual ICollection<ProductoDTO> Productos { get; set; } = new List<ProductoDTO>();
    }
}
