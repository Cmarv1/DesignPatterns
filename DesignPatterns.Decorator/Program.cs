namespace DesignPatterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IBebida miCafeCompleto = new Cafe();
            miCafeCompleto = new Leche(miCafeCompleto);
            miCafeCompleto = new Azucar(miCafeCompleto);

            IBebida miCafeConLeche = new Cafe();
            miCafeConLeche = new Leche(miCafeConLeche);

            Console.WriteLine(miCafeCompleto.Descripcion() + "\nCosto: $" + miCafeCompleto.Costo() + "\n---------------\n");
            Console.WriteLine(miCafeConLeche.Descripcion() + "\nCosto: $" + miCafeConLeche.Costo() + "\n---------------\n");
        }
    }
}
