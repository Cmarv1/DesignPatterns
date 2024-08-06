using DesignPatterns.Mediator;

public class Program
{
    public static void Main(string[] args)
    {
        IChatMediador chat = new ChatMediador();

        Usuario usuario1 = new UsuarioConcreto(chat, "Camilo");
        Usuario usuario2 = new UsuarioConcreto(chat, "Jhon");
        Usuario usuario3 = new UsuarioConcreto(chat, "Juan");

        chat.RegistrarUsuario(usuario1);
        chat.RegistrarUsuario(usuario2);
        chat.RegistrarUsuario(usuario3);

        usuario1.EnviarMensaje("Hola a todos!");
        usuario2.EnviarMensaje($"Hola {usuario2.Nombre}!");
        usuario3.EnviarMensaje($"Hola {usuario3.Nombre}!");
    }
}
