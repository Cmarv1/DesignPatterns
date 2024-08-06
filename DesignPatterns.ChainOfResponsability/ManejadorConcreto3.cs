using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsability
{
    public class ManejadorConcreto3 : ManejadorBase
    {
        public override void ManejarSolicitud(int nivel)
        {
            if (nivel == 3)
            {
                Console.WriteLine($"ManejadorConcreto3 maneja la solicitud de nivel {nivel}.");
            }
            else
            {
                base.ManejarSolicitud(nivel);
            }
        }
    }

}
