using DesignPatterns.Proxy;

class Program
{
    static void Main(string[] args)
    {
        IServicio servicio = new ServicioProxy();

        servicio.Solicitud();
        servicio.Solicitud();
        servicio.Solicitud();

        ((ServicioProxy)servicio).MostrarLogs();

        Console.WriteLine("Proceso completado.");
    }
}
