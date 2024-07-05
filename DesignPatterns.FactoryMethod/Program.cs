using DesignPatterns.FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        //Crear y gestionar documento de texto
        GestorDocumentos gestorTexto = new GestorDocumentosTexto();
        gestorTexto.GestionarDocumento();

        //Crear y gestionar documento de hoja de cálculo
        GestorDocumentos gestorHojaCalculo = new GestorHojasCalculo();
        gestorHojaCalculo.GestionarDocumento();
    }
}
