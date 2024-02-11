using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    public class PanDeTrigo : ProcesoDePanaderia
    {
        protected override void MezclarIngredientes()
        {
            Console.WriteLine("Mezclando ingredientes para el pan de trigo.");
        }

        protected override void Hornear()
        {
            Console.WriteLine("Horneando el pan de trigo a 180 grados.");
        }
    }

    public class PanIntegral : ProcesoDePanaderia
    {
        protected override void MezclarIngredientes()
        {
            Console.WriteLine("Mezclando ingredientes para el pan integral.");
        }

        protected override void Hornear()
        {
            Console.WriteLine("Horneando el pan integral a 200 grados.");
        }
    }
}
