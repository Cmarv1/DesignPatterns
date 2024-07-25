using DesignPatterns.Observer;

class Program
{
    static void Main(string[] args)
    {
        ClimaDatos climaDatos = new ClimaDatos();

        IObservador pantallaActual = new PantallaActual(climaDatos);
        IObservador pantallaEstadisticas = new PantallaEstadisticas(climaDatos);

        climaDatos.EstablecerMediciones(28, 65, 1013.1f);
        climaDatos.EstablecerMediciones(22, 70, 1012.5f);
    }
}
