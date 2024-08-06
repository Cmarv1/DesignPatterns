using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class Dispositivo
    {
        private string _nombre;

        public Dispositivo(string nombre)
        {
            _nombre = nombre;
        }

        public void Encender()
        {
            Console.WriteLine($"{_nombre} encendido.");
        }

        public void Apagar()
        {
            Console.WriteLine($"{_nombre} apagado.");
        }
    }
}
