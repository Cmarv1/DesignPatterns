using DesignPatterns.Iterator;

public class Program
{
    public static void Main(string[] args)
    {
        var biblioteca = new Biblioteca();
        biblioteca.AgregarLibro(new Libro("1984", "George Orwell"));
        biblioteca.AgregarLibro(new Libro("Cien años de soledad", "Gabriel García Márquez"));
        biblioteca.AgregarLibro(new Libro("El Quijote", "Miguel de Cervantes"));

        IIterador iterador = biblioteca.CrearIterador();

        Console.WriteLine("Libros en la biblioteca:");
        while (iterador.TieneSiguiente())
        {
            Libro libro = (Libro)iterador.Siguiente();
            Console.WriteLine(libro);
        }
    }
}
