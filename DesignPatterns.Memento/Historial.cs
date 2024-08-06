using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Historial
    {
        private Stack<Memento> _mementos = new Stack<Memento>();

        public void Guardar(Memento memento)
        {
            _mementos.Push(memento);
        }

        public Memento Deshacer()
        {
            if (_mementos.Count > 0)
            {
                return _mementos.Pop();
            }

            return null;
        }
    }
}
