using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPatterns.Visitor
{
    public interface IDocumento
    {
        void Aceptar(IVisitanteOperacion visitante);
    }
}
