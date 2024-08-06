using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class ControlRemoto
    {
        private List<IOperacion> _historial = new List<IOperacion>();

        public void EjecutarOperacion(IOperacion operacion)
        {
            operacion.Ejecutar();
            _historial.Add(operacion);
        }

        public void DeshacerOperacion()
        {
            if (_historial.Count > 0)
            {
                var operacion = _historial[_historial.Count - 1];
                operacion.Deshacer();
                _historial.RemoveAt(_historial.Count - 1);
            }
        }
    }
}
