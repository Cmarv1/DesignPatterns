using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Usuario
    {
        public string Rol { get; set; }
        public string Nombre { get; set; }

        public Usuario(string rol, string nombre)
        {
            Rol = rol;
            Nombre = nombre;
        }
    }
}
