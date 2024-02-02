using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Publicado : IEstadoDocumento
    {
        public void Publicar(Documento documento, Usuario usuario)
        {
            // No se realiza ninguna acción
            Console.WriteLine("El documento ya está publicado. No se realiza ninguna acción. \n----------------------------------");
        }
    }
}
