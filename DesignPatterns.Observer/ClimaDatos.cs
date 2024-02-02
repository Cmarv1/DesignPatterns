using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class ClimaDatos : ISujeto
    {
        private List<IObservador> observadores;
        private float temperatura;
        private float humedad;
        private float presion;

        public ClimaDatos()
        {
            observadores = new List<IObservador>();
        }

        public void RegistrarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void EliminarObservador(IObservador observador)
        {
            observadores.Remove(observador);
        }

        public void NotificarObservadores()
        {
            foreach (IObservador observador in observadores)
            {
                observador.Actualizar(temperatura, humedad, presion);
            }
        }

        public void CambiosMediciones()
        {
            NotificarObservadores();
        }

        public void EstablecerMediciones(float temperatura, float humedad, float presion)
        {
            this.temperatura = temperatura;
            this.humedad = humedad;
            this.presion = presion;
            CambiosMediciones();
        }
    }
}
