using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPatterns.Visitor
{
    public interface IVisitanteOperacion
    {
        void Visitar(DocumentoXML documento);
        void Visitar(DocumentoPDF documento);
    }
}
