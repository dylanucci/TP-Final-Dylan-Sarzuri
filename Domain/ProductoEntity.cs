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

        private string _nombre;
        private int _precio;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public int CategoriaId { get; set; }

        public virtual CategoriaEntity Categoria { get; set; } = null!;
    }
}
