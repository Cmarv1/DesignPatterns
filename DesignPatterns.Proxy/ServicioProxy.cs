using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class ServicioProxy : IServicio
    {
        private ServicioReal _servicioReal;
        private readonly List<string> _logs;

        public ServicioProxy()
        {
            _servicioReal = new ServicioReal();
            _logs = new List<string>();
        }

        public void Solicitud()
        {
            _logs.Add($"Solicitud realizada a las {DateTime.Now}");
            _servicioReal.Solicitud();
        }

        public void MostrarLogs()
        {
            Console.WriteLine("Historial de solicitudes:");
            foreach (var log in _logs)
            {
                Console.WriteLine(log);
            }
        }
    }

}
