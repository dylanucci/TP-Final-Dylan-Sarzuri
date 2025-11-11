using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ClienteEntity
    {
        public int IdCliente { get; set; }
    private string _nombre;
    private string _apellido;
    private string _telefono;
    private string _email;
    private string _contraseña;

    public string Nombre
    {
        get { return _nombre; }
            set { _nombre = value; }
    }

    public string Apellido
    {
        get { return _apellido; }
        set { _apellido = value; }
    }

    public string Telefono
    {
        get { return _telefono; }
        set { _telefono = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public string Contraseña
    {
        get { return _contraseña; }
        set { _contraseña = value; } 
    }
        public virtual ICollection<CompraEntity> Compras { get; set; } = new List<CompraEntity>();
    }

}
