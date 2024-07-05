using DesignPatterns.AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        //Crear la fabrica para windows
        IFactoryControlesUI fabricaWindows = new FactoryControlesWindows();
        IBoton botonWindows = fabricaWindows.CrearBoton();
        ICuadroTexto cuadroTextoWindows = fabricaWindows.CrearCuadroTexto();

        botonWindows.Render();
        cuadroTextoWindows.Render();

        //Crear la fabrica para MacOS
        IFactoryControlesUI fabricaMacOS = new FactoryControlesMacOS();
        IBoton botonMacOS = fabricaMacOS.CrearBoton();
        ICuadroTexto cuadroTextoMacOS = fabricaMacOS.CrearCuadroTexto();

        botonMacOS.Render();
        cuadroTextoMacOS.Render();
    }
}
