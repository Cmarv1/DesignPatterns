using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public abstract class Usuario
    {
        protected IChatMediador _mediador;
        private string _nombre;

        public Usuario(IChatMediador mediador, string nombre)
        {
            _mediador = mediador;
            _nombre = nombre;
        }

        public string Nombre => _nombre;

        public abstract void EnviarMensaje(string mensaje);
        public abstract void RecibirMensaje(string mensaje, Usuario remitente);
    }
}
