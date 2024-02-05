using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class PagoPayPal : IMetodoPago
    {
        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago por PayPal por US${monto}.");
        }
    }
}
