using DesignPatterns.Template;

class Program
{
    static void Main(string[] args)
    {
        ProcesoDePanaderia panDeTrigo = new PanDeTrigo();
        panDeTrigo.HacerPan();

        Console.WriteLine();

        ProcesoDePanaderia panIntegral = new PanIntegral();
        panIntegral.HacerPan();
    }
}
