using DesignPatterns.State;

class Program
{
    static void Main(string[] args)
    {
        Usuario usuario1 = new Usuario("Admin","Camilo");
        Usuario usuario2 = new Usuario("Default", "Juan");
        Documento documento1 = new Documento(new Borrador(), usuario1);

        documento1.Publicar(); // El documento ha pasado a Moderación.
        documento1.Publicar(); // El documento ha sido publicado.
        documento1.Publicar(); // El documento ya está publicado. No se realiza ninguna acción.

        Documento documento2 = new Documento(new Borrador(), usuario2);
        documento2.Publicar();
        documento2.Publicar();
        documento2.Publicar();
    }
}
