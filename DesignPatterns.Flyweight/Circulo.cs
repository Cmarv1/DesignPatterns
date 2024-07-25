using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public class Circulo : IForma
    {
        private string _color;
        private int _radio;

        public Circulo(string color)
        {
            _color = color;
            _radio = 5; // Valor predeterminado
        }

        public void Dibujar(int x, int y)
        {
            Console.WriteLine($"Dibujando un círculo de color {_color} en ({x}, {y}) con radio {_radio}");
        }
    }
    
}
