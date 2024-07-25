using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class ServicioReal : IServicio
    {
        public void Solicitud()
        {
            Console.WriteLine("ServicioReal: Ejecutando solicitud.");
        }
    }

}
