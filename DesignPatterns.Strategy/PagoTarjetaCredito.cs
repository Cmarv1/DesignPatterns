using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class PagoTarjetaCredito : IMetodoPago
    {
        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago por Tarjeta de Crédito por US${monto}.");
        }
    }
}
