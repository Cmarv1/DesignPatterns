namespace DesignPatterns.Composite
{
    public class CompositeGrafico : IComponenteGrafico
    {
        private List<IComponenteGrafico> _componentes = new List<IComponenteGrafico>();

        public void Agregar(IComponenteGrafico componente)
        {
            _componentes.Add(componente);
        }

        public void Dibujar()
        {
            foreach (var componente in _componentes)
            {
                componente.Dibujar();
            }

            Console.WriteLine("\n--------------\n");
        }
    }
}
