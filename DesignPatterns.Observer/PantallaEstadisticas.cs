using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class PantallaEstadisticas : IObservador
    {
        private float temperatura;
        private float presion;
        private ISujeto climaDatos;

        public PantallaEstadisticas(ISujeto climaDatos)
        {
            this.climaDatos = climaDatos;
            climaDatos.RegistrarObservador(this);
        }

        public void Actualizar(float temperatura, float humedad, float presion)
        {
            this.temperatura = temperatura;
            this.presion = presion;
            Mostrar();
        }

        public void Mostrar()
        {
            Console.WriteLine($"Condiciones actuales: {temperatura} grados y {presion} Pa");
        }
    }
}
