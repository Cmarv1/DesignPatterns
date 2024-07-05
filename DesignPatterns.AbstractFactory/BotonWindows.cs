using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class BotonWindows : IBoton
    {
        public void Render()
        {
            Console.WriteLine("Renderizando botón en estilo Windows.");
        }
    }
}
