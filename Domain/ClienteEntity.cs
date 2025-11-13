using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ClienteEntity
    {
        public int IdCliente { get; set; }
    private string _nombre;
    private string _apellido;
    private int _telefono;
    private string _email;
    private string _contraseña;

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

    public string Apellido
    {
        get { return _apellido; }
        set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("El apellido no puede estar vacio");
                }
                _apellido = value; 
            }
    }

    public int Telefono
    {
        get { return _telefono; }
        set 
            {
                _telefono = value; 
            }
    }

    public string Email
    {
        get { return _email; }
        set 
            {
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Formato de Email invalido");
                }
                _email = value; 
            }
    }

    public string Contraseña
    {
        get { return _contraseña; }
        set { _contraseña = value; } 
    }
        public virtual ICollection<CompraEntity> Compras { get; set; } = new List<CompraEntity>();
    }

}
