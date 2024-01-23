namespace DesignPatterns.Decorator
{
    public class Leche : DecoradorBebida
    {
        public Leche(IBebida bebida) : base(bebida) { }

        public override string Descripcion()
        {
            return bebida.Descripcion() + "\nLeche";
        }

        public override double Costo()
        {
            return bebida.Costo() + 0.50;
        }
    }
}
