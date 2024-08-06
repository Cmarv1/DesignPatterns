using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class IteradorBiblioteca : IIterador
    {
        private Biblioteca _biblioteca;
        private int _indiceActual = 0;

        public IteradorBiblioteca(Biblioteca biblioteca)
        {
            _biblioteca = biblioteca;
        }

        public bool TieneSiguiente()
        {
            return _indiceActual < _biblioteca.Contar;
        }

        public object Siguiente()
        {
            if (TieneSiguiente())
            {
                return _biblioteca.ObtenerLibro(_indiceActual++);
            }
            else
            {
                return null;
            }
        }
    }
}
