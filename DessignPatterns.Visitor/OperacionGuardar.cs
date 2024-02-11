using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPatterns.Visitor
{
    public class OperacionGuardar : IVisitanteOperacion
    {
        public void Visitar(DocumentoXML documento)
        {
            Console.WriteLine("Guardando documento de texto.\n");
        }

        public void Visitar(DocumentoPDF documento)
        {
            Console.WriteLine("Guardando documento PDF.\n");
        }
    }
}
