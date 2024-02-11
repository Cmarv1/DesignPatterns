using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    using System;

    public abstract class ProcesoDePanaderia
    {
        // Método template
        public void HacerPan()
        {
            MezclarIngredientes();
            Hornear();
            Enfriar();
            Empacar();
        }

        protected abstract void MezclarIngredientes();
        protected abstract void Hornear();

        protected virtual void Enfriar()
        {
            Console.WriteLine("Enfriando el pan. <Template>");
        }

        protected virtual void Empacar()
        {
            Console.WriteLine("Empacando el pan. <Template> \n -----------------------------------------");
        }
    }
}
