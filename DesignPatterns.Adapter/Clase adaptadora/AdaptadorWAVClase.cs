using DesignPatterns.Adapter.Adaptador_de_objetos;

namespace DesignPatterns.Adapter.Clase_adaptadora
{
    public class AdaptadorWAVClase : ReproductorWAV, IReproductorMP3
    {
        public void ReproducirMP3(int archivo)
        {
            string newArchivo = archivo.ToString();
            ReproducirWAV(newArchivo);
        }
    }
}
