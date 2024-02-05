using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class CarritoCompra
    {
        private IMetodoPago metodoPago;

        public CarritoCompra(IMetodoPago metodoPago)
        {
            this.metodoPago = metodoPago;
        }

        public void EstablecerMetodoPago(IMetodoPago nuevoMetodoPago)
        {
            this.metodoPago = nuevoMetodoPago;
        }

        public void ProcesarCompra(double monto)
        {
            this.metodoPago.ProcesarPago(monto);
        }
    }
}
