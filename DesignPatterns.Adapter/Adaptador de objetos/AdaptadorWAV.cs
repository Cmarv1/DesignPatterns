namespace DesignPatterns.Adapter.Adaptador_de_objetos
{
    public class AdaptadorWAV:IReproductorMP3
    {
        private ReproductorWAV _reproductorWAV = new ReproductorWAV();

        public void ReproducirMP3(string archivo)
        {
            _reproductorWAV.ReproducirWAV(archivo);
        }
    }
}
