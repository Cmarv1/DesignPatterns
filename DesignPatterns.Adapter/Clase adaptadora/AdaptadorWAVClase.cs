using DesignPatterns.Adapter.Adaptador_de_objetos;

namespace DesignPatterns.Adapter.Clase_adaptadora
{
    public class AdaptadorWAVClase : ReproductorWAV, IReproductorMP3
    {
        public void ReproducirMP3(string archivo)
        {
            ReproducirWAV(archivo);
        }
    }
}
