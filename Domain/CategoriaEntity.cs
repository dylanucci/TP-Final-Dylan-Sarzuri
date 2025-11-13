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

        private string _nombre;
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("El nombre no puede estar vacio");
                }
                _nombre = value;
            }
        }

        public virtual ICollection<ProductoEntity> Productos { get; set; } = new List<ProductoEntity>();
    }
}
