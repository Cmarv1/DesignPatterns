namespace DesignPatterns.Decorator
{
    public class Azucar : DecoradorBebida
    {
        public Azucar(IBebida bebida) : base(bebida) { }

        public override string Descripcion()
        {
            return bebida.Descripcion() + "\nAzúcar";
        }

        public override double Costo()
        {
            return bebida.Costo() + 0.20;
        }
    }
}
