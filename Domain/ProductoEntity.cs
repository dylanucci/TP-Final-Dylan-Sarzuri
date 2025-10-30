using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProductoEntity
    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; } = null!;

        public int Precio { get; set; }

        public int CategoriaId { get; set; }

        public virtual CategoriaEntity Categoria { get; set; } = null!;
    }
}
