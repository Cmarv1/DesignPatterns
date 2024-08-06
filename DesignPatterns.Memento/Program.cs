using DesignPatterns.Memento;

public class Program
{
    public static void Main(string[] args)
    {
        var editor = new EditorTexto();
        var historial = new Historial();

        editor.Escribir("Hola, ");
        editor.Escribir("este es un ");
        historial.Guardar(editor.Guardar());

        editor.Escribir("ejemplo del ");
        historial.Guardar(editor.Guardar());

        editor.Escribir("patrón memento.");

        Console.WriteLine("Contenido actual: " + editor.Mostrar());

        editor.Restaurar(historial.Deshacer());
        Console.WriteLine("Después de deshacer: " + editor.Mostrar());

        editor.Restaurar(historial.Deshacer());
        Console.WriteLine("Después de deshacer: " + editor.Mostrar());
    }
}
