using DesignPatterns.ChainOfResponsability;

class Program
{
    static void Main(string[] args)
    {
        IManejador manejador1 = new ManejadorConcreto1();
        IManejador manejador2 = new ManejadorConcreto2();
        IManejador manejador3 = new ManejadorConcreto3();

        manejador1.EstablecerSiguiente(manejador2);
        manejador2.EstablecerSiguiente(manejador3);

        manejador1.ManejarSolicitud(1);
        manejador1.ManejarSolicitud(2);
        manejador1.ManejarSolicitud(3);
        manejador1.ManejarSolicitud(4);

        Console.WriteLine("Proceso completado.");
    }
}
