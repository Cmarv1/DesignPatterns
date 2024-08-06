using DesignPatterns.Command;

public class Program
{
    public static void Main(string[] args)
    {
        var luz = new Dispositivo("Luz del salón");
        var ventilador = new Dispositivo("Ventilador de la habitación");

        var encenderLuz = new EncenderComando(luz);
        var apagarLuz = new ApagarComando(luz);

        var encenderVentilador = new EncenderComando(ventilador);
        var apagarVentilador = new ApagarComando(ventilador);

        var controlRemoto = new ControlRemoto();

        controlRemoto.EjecutarOperacion(encenderLuz);
        controlRemoto.EjecutarOperacion(apagarLuz);

        controlRemoto.EjecutarOperacion(encenderVentilador);
        controlRemoto.DeshacerOperacion();
        controlRemoto.EjecutarOperacion(apagarVentilador);
        controlRemoto.DeshacerOperacion();
    }
}