namespace DesignPatterns.Decorator
{
    public class Cafe : IBebida
    {
        public string Descripcion()
        {
            return "Café";
        }

        public double Costo()
        {
            return 1.99;
        }
    }
}
