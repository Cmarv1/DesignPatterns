using DesignPatterns.Strategy;

class Program
{
    static void Main(string[] args)
    {
        CarritoCompra carrito = new CarritoCompra(new PagoTarjetaCredito());
        carrito.ProcesarCompra(100.0);

        // Cambiar a PayPal
        carrito.EstablecerMetodoPago(new PagoPayPal());
        carrito.ProcesarCompra(50.0);

        // Cambiar a Transferencia Bancaria
        carrito.EstablecerMetodoPago(new PagoTransferenciaBancaria());
        carrito.ProcesarCompra(200.0);
    }
}