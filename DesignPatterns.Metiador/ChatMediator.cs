using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class ChatMediador : IChatMediador
    {
        private List<Usuario> _usuarios = new List<Usuario>();

        public void RegistrarUsuario(Usuario usuario)
        {
            if (!_usuarios.Contains(usuario))
            {
                _usuarios.Add(usuario);
            }
        }

        public void EnviarMensaje(string mensaje, Usuario remitente)
        {
            foreach (var usuario in _usuarios)
            {
                // No enviar el mensaje al remitente
                if (usuario != remitente)
                {
                    usuario.RecibirMensaje(mensaje, remitente);
                }
            }
        }
    }
}
