using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class Memoria : IMemoria
    {
        public void Cargar()
        {
            Console.WriteLine("Cargando datos en memoria...");
        }
    }

}
