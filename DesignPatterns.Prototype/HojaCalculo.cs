using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class HojaCalculo : IPrototipoDocumento
    {
        public string Datos { get; set; }

        public HojaCalculo(string datos)
        {
            Datos = datos;
        }

        public IPrototipoDocumento Clonar()
        {
            return new HojaCalculo(this.Datos);
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Datos de hoja de cálculo: {Datos}");
        }
    }
}
