using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProductoEntity : Entity
    {
        public int IdProducto { get; set; }

        private string _nombre;
        private int _precio;

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("El nombre no puede estar vacio");
                }
                _nombre = value;
            }
        }

        public int Precio
        {
            get { return _precio; }
            set { if (value <= 0) throw new ArgumentException("El precio no puede ser menor a 0"); 
                  _precio = value; }
        }

        public int CategoriaId { get; set; }

        public virtual CategoriaEntity Categoria { get; set; } = null!;
    }
}
