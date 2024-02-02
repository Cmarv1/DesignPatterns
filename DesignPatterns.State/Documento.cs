using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Documento
    {
        private IEstadoDocumento estadoActual;
        private Usuario Usuario;

        public Documento(IEstadoDocumento estado, Usuario usuario)
        {
            EstadoActual = estado;
            Usuario = usuario;
        }

        public IEstadoDocumento EstadoActual
        {
            get { return estadoActual; }
            set { estadoActual = value; }
        }

        public void Publicar()
        {
            estadoActual.Publicar(this, Usuario);
        }
    }
}
