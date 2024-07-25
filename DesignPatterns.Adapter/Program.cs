using DesignPatterns.Adapter.Adaptador_de_objetos;
using DesignPatterns.Adapter.Clase_adaptadora;

namespace DesignPatterns.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adaptador de objetos
            IReproductorMP3 reproductor = new AdaptadorWAV();
            reproductor.ReproducirMP3(1234);  // Aunque el archivo es WAV, se utiliza la interfaz MP3

            //Clase adaptadora
            IReproductorMP3 reproductorClase = new AdaptadorWAVClase();
            reproductorClase.ReproducirMP3(5678);  // Se utiliza la interfaz MP3 con un adaptador de clase
        }
    }
}
