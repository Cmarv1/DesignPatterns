namespace DesignPatterns.Bridge
{
    public abstract class Forma
    {
        protected IColor _color;

        protected Forma(IColor color)
        {
            _color = color;
        }

        public abstract void Dibujar();
    }
}
