using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
     public class Cliente
    {
        public decimal Indentificacion { get; set; }
        public string Nombre { get; set; }

        public Cliente(decimal indentificacion, string nombre)
        {
            Indentificacion = indentificacion;
            Nombre = nombre;
        }
    }
}
