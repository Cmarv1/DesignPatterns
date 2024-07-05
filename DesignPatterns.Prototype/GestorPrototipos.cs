using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class GestorPrototipos
    {
        private Dictionary<string, IPrototipoDocumento> _prototipos = new Dictionary<string, IPrototipoDocumento>();

        public void RegistrarPrototipos(string clave, IPrototipoDocumento prototipo)
        {
            _prototipos[clave] = prototipo;
        }

        public IPrototipoDocumento ObtenerPrototipo(string clave)
        {
            if(_prototipos.ContainsKey(clave))
            {
                return _prototipos[clave].Clonar();
            }
            else
            {
                throw new ArgumentException("Prototipo no registrado");
            }
        }
    }
}
