using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class ApagarComando : IOperacion
    {
        private Dispositivo _dispositivo;

        public ApagarComando(Dispositivo dispositivo)
        {
            _dispositivo = dispositivo;
        }

        public void Ejecutar()
        {
            _dispositivo.Apagar();
        }

        public void Deshacer()
        {
            _dispositivo.Encender();
        }
    }
}
