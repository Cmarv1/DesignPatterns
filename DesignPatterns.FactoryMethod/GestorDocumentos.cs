using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public abstract class GestorDocumentos
    {
        protected abstract IDocumento CreaDocumento();

        public void GestionarDocumento()
        {
            IDocumento documento = CreaDocumento();

            documento.Abrir();
            documento.Guardar();
            documento.Cerrar();
        }
    }
}
