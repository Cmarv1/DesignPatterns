using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPatterns.Visitor
{
    public class OperacionImprimir : IVisitanteOperacion
    {
        public void Visitar(DocumentoXML documento)
        {
            Console.WriteLine("Imprimiendo documento de texto.");
        }

        public void Visitar(DocumentoPDF documento)
        {
            Console.WriteLine("Imprimiendo documento PDF.");
        }
    }
}
