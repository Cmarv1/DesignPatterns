using DesignPatterns.Observer;

class Program
{
    static void Main(string[] args)
    {
        ClimaDatos climaDatos = new ClimaDatos();

        PantallaActual pantallaActual = new PantallaActual(climaDatos);
        PantallaEstadisticas pantallaEstadisticas = new PantallaEstadisticas(climaDatos);

        climaDatos.EstablecerMediciones(28, 65, 1013.1f);
        climaDatos.EstablecerMediciones(22, 70, 1012.5f);
    }
}
