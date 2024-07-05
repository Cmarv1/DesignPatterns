using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class DocumentoTexto : IPrototipoDocumento
    {
        public string Contenido { get; set; }

        public DocumentoTexto(string contenido)
        {
            Contenido = contenido;
        }

        public IPrototipoDocumento Clonar()
        {
            return new DocumentoTexto(this.Contenido);
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Contenido de texto: {Contenido}");
        }
    }
}
