using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class EditorTexto
    {
        private string _contenido;

        public void Escribir(string texto)
        {
            _contenido += texto;
        }

        public string Mostrar()
        {
            return _contenido;
        }

        public Memento Guardar()
        {
            return new Memento(_contenido);
        }

        public void Restaurar(Memento memento)
        {
            _contenido = memento.ObtenerEstado();
        }
    }
}
