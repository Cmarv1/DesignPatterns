using DesignPatterns.Facade;

class Program
{
    static void Main(string[] args)
    {
        IProcesador procesador = new Procesador();
        IAlmacenamiento almacenamiento = new Almacenamiento();
        IMemoria memoria = new Memoria();
        Computador computadora = new Computador(procesador, memoria, almacenamiento);
        computadora.Iniciar();

        Console.WriteLine("Proceso completado.");
    }
}
