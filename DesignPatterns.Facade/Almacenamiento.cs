using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class Almacenamiento : IAlmacenamiento
    {
        public void Guardar()
        {
            Console.WriteLine("Guardando datos...");
        }
    }

}
