using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Borrador : IEstadoDocumento
    {
        public void Publicar(Documento documento, Usuario usuario)
        {
            Console.WriteLine($"El documento ha pasado a Moderación por el usuario {usuario.Nombre}.");
            documento.EstadoActual = new Moderacion();
        }
    }
}
