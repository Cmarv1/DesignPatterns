namespace DesignPatterns.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Forma circuloRojo = new Circulo(new ColorRojo());
            circuloRojo.Dibujar();

            Forma cuadradoAzul = new Cuadrado(new ColorAzul());
            cuadradoAzul.Dibujar();
        }
    }
}
