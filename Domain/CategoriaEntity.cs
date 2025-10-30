using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CategoriaEntity
    {
        public int IdCategoria { get; set; }

        public string Nombre { get; set; } = null!;

        public virtual ICollection<ProductoEntity> Productos { get; set; } = new List<ProductoEntity>();
    }
}
