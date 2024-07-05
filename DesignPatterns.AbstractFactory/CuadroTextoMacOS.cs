using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class CuadroTextoMacOS : ICuadroTexto
    {
        public void Render()
        {
            Console.WriteLine("Renderizando cuadro de texto en estilo MacOS.");
        }
    }
}
