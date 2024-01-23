using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class Circulo : Forma
    {
        public Circulo(IColor color) : base(color) { }

        public override void Dibujar()
        {
            Console.WriteLine("Dibujando círculo");
            color.AplicarColor();
        }
    }
}
