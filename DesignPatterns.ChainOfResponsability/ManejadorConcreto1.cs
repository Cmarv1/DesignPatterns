using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsability
{
    public class ManejadorConcreto1 : ManejadorBase
    {
        public override void ManejarSolicitud(int nivel)
        {
            if (nivel == 1)
            {
                Console.WriteLine($"ManejadorConcreto1 maneja la solicitud de nivel {nivel}.");
            }
            else
            {
                base.ManejarSolicitud(nivel);
            }
        }
    }

}
