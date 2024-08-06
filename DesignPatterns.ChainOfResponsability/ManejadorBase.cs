using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsability
{
    public abstract class ManejadorBase : IManejador
    {
        private IManejador _siguienteManejador;

        public void EstablecerSiguiente(IManejador manejador)
        {
            _siguienteManejador = manejador;
        }

        public virtual void ManejarSolicitud(int nivel)
        {
            if (_siguienteManejador != null)
            {
                _siguienteManejador.ManejarSolicitud(nivel);
            }
            else
            {
                Console.WriteLine("No existe un manejador para este nivel de solicitud.");
            }
        }
    }

}
