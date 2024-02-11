using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPatterns.Visitor
{
    public class DocumentoPDF : IDocumento
    {
        public void Aceptar(IVisitanteOperacion visitante)
        {
            visitante.Visitar(this);
        }
    }
}
