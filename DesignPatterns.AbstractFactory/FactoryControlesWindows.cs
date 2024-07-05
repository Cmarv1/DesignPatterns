using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class FactoryControlesWindows : IFactoryControlesUI
    {
        public IBoton CrearBoton()
        {
            return new BotonWindows();
        }

        public ICuadroTexto CrearCuadroTexto()
        {
            return new CuadroTextoWindows();
        }
    }
}
