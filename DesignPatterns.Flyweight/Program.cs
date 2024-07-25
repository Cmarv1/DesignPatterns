using DesignPatterns.Flyweight;

class Program
{
    static void Main(string[] args)
    {
        IForma circuloRojo1 = FabricaDeFormas.ObtenerForma("rojo");
        circuloRojo1.Dibujar(10, 20);

        IForma circuloRojo2 = FabricaDeFormas.ObtenerForma("rojo");
        circuloRojo2.Dibujar(30, 40);

        IForma circuloAzul = FabricaDeFormas.ObtenerForma("azul");
        circuloAzul.Dibujar(50, 60);

        Console.WriteLine("Proceso completado.");
    }
}

