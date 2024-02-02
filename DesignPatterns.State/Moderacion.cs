using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Moderacion : IEstadoDocumento
    {
        public void Publicar(Documento documento, Usuario usuario)
        {
            if(usuario.Rol == "Admin")
            {
                Console.WriteLine($"El documento ha sido publicado por el usuario {usuario.Nombre}.");
                documento.EstadoActual = new Publicado();
                return;
            }

            Console.WriteLine($"El usuario {usuario.Nombre} no tiene permisos de administrador.");
        }
    }
}
