using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class Procesador : IProcesador
    {
        public void Procesar()
        {
            Console.WriteLine("Procesando datos...");
        }
    }

}
