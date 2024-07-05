using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class FactoryControlesMacOS : IFactoryControlesUI
    {
        public IBoton CrearBoton()
        {
            return new BotonMacOS();
        }

        public ICuadroTexto CrearCuadroTexto()
        {
            return new CuadroTextoMacOS();
        }
    }
}
