using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class DocumentoTexto : IDocumento
    {
        public void Abrir()
        {
            Console.WriteLine("Abriendo documento de texto.");
        }

        public void Cerrar()
        {
            Console.WriteLine("Guardando documento de texto.");
        }

        public void Guardar()
        {
            Console.WriteLine("Cerrando documento de texto.");
        }
    }
}
