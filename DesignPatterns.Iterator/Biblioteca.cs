using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class Biblioteca : IColeccionLibros
    {
        private List<Libro> _libros = new List<Libro>();

        public void AgregarLibro(Libro libro)
        {
            _libros.Add(libro);
        }

        public IIterador CrearIterador()
        {
            return new IteradorBiblioteca(this);
        }

        public int Contar
        {
            get { return _libros.Count; }
        }

        public Libro ObtenerLibro(int indice)
        {
            return _libros[indice];
        }
    }
}
