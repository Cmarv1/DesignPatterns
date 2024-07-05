using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class HojaCalculo : IDocumento
    {
        public void Abrir()
        {
            Console.WriteLine("Abriendo hoja de cálculo.");
        }

        public void Cerrar()
        {
            Console.WriteLine("Cerrando hoja de cálculo.");
        }

        public void Guardar()
        {
            Console.WriteLine("Guardando hoja de cálculo.");
        }
    }
}
