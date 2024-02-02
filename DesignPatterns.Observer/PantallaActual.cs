using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class PantallaActual : IObservador
    {
        private float temperatura;
        private float humedad;
        private ISujeto climaDatos;

        public PantallaActual(ISujeto climaDatos)
        {
            this.climaDatos = climaDatos;
            climaDatos.RegistrarObservador(this);
        }

        public void Actualizar(float temperatura, float humedad, float presion)
        {
            this.temperatura = temperatura;
            this.humedad = humedad;
            Mostrar();
        }

        public void Mostrar()
        {
            Console.WriteLine($"Condiciones actuales: {temperatura} grados y {humedad}% humedad");
        }
    }
}
