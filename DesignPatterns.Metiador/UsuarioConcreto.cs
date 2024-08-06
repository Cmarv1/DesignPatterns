using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class UsuarioConcreto : Usuario
    {
        public UsuarioConcreto(IChatMediador mediador, string nombre) : base(mediador, nombre)
        {
        }

        public override void EnviarMensaje(string mensaje)
        {
            Console.WriteLine($"{Nombre} envía: {mensaje}");
            _mediador.EnviarMensaje(mensaje, this);
        }

        public override void RecibirMensaje(string mensaje, Usuario remitente)
        {
            Console.WriteLine($"{Nombre} recibe de {remitente.Nombre}: {mensaje}");
        }
    }
}
