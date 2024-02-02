namespace DesignPatterns.Observer
{
    public interface ISujeto
    {
        void RegistrarObservador(IObservador o);
        void EliminarObservador(IObservador o);
        void NotificarObservadores();
    }
}
