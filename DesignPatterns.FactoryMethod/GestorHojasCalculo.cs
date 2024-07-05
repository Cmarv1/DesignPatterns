using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class GestorHojasCalculo : GestorDocumentos
    {
        protected override IDocumento CreaDocumento()
        {
            return new HojaCalculo();
        }
    }
}
