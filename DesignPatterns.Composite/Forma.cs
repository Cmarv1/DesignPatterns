namespace DesignPatterns.Composite
{
    public class Forma : IComponenteGrafico
    {
        private string _nombre;

        public Forma(string nombre)
        {
            _nombre = nombre;
        }

        public void Dibujar()
        {
            Console.WriteLine($"Dibujando forma: {_nombre}");
        }
    }
}
