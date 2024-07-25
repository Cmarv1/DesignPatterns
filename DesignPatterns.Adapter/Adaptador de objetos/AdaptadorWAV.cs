namespace DesignPatterns.Adapter.Adaptador_de_objetos
{
    public class AdaptadorWAV:IReproductorMP3
    {
        private ReproductorWAV _reproductorWAV = new ReproductorWAV();

        public void ReproducirMP3(int archivo)
        {
            string newArchivo = $"{archivo}.wav";
            _reproductorWAV.ReproducirWAV(newArchivo);
        }
    }
}
