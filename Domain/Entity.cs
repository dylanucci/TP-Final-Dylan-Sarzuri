using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Entity
    {
        public int Id { get; set; }

        public string GetInfo()
        {
            var type = this.GetType();

            var className = type.Name;

            var properties = type.GetProperties();

            string Cadena = "";

            foreach (var prop in properties)
            {
                Cadena += $"{prop.Name}: {prop.GetValue(this)}; ";
            }

            return Cadena;
        }
    }
}
