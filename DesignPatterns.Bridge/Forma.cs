namespace DesignPatterns.Bridge
{
    public abstract class Forma
    {
        protected IColor color;

        protected Forma(IColor color)
        {
            this.color = color;
        }

        public abstract void Dibujar();
    }
}
