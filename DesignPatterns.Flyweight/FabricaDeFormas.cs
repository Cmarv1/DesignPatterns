using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public class FabricaDeFormas
    {
        private static readonly Dictionary<string, IForma> _formas = new Dictionary<string, IForma>();

        public static IForma ObtenerForma(string color)
        {
            if (!_formas.ContainsKey(color))
            {
                _formas[color] = new Circulo(color);
                Console.WriteLine($"Creando un círculo de color {color}");
            }
            return _formas[color];
        }
    }

}
