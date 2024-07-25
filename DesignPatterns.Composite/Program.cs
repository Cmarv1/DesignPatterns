namespace DesignPatterns.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Forma circulo = new Forma("Círculo");
            Forma cuadrado = new Forma("Cuadrado");

            CompositeGrafico grafico = new CompositeGrafico();
            grafico.Agregar(circulo);
            grafico.Agregar(cuadrado);

            CompositeGrafico graficoCompuesto = new CompositeGrafico();
            graficoCompuesto.Agregar(grafico);
            graficoCompuesto.Agregar(new Forma("Triángulo"));

            CompositeGrafico graficoMasCompuesto = new CompositeGrafico();
            graficoMasCompuesto.Agregar(graficoCompuesto);
            graficoMasCompuesto.Agregar(new Forma("Rectangulo"));

            //grafico.Dibujar();  // Dibuja el círculo y el cuadrado
            //graficoCompuesto.Dibujar();  // Dibuja el círculo, el cuadrado y el triángulo
            graficoMasCompuesto.Dibujar();  // Dibuja el círculo, el cuadrado, el triángulo y el cuadrado
        }
    }
}
