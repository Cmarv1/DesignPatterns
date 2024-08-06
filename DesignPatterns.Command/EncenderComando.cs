using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class EncenderComando : IOperacion
    {
        private Dispositivo _dispositivo;

        public EncenderComando(Dispositivo dispositivo)
        {
            _dispositivo = dispositivo;
        }

        public void Ejecutar()
        {
            _dispositivo.Encender();
        }

        public void Deshacer()
        {
            _dispositivo.Apagar();
        }
    }
}
