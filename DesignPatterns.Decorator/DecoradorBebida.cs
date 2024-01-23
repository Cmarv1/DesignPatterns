namespace DesignPatterns.Decorator
{
    public abstract class DecoradorBebida : IBebida
    {
        protected IBebida bebida;

        public DecoradorBebida(IBebida bebida)
        {
            this.bebida = bebida;
        }

        public abstract string Descripcion();

        public abstract double Costo();
    }
}
