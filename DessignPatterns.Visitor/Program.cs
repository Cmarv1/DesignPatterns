using DessignPatterns.Visitor;

class Program
{
    static void Main(string[] args)
    {
        var documentos = new IDocumento[]
        {
            new DocumentoXML(),
            new DocumentoPDF()
        };

        var operacionGuardar = new OperacionGuardar();
        var operacionImprimir = new OperacionImprimir();

        foreach (var documento in documentos)
        {
            documento.Aceptar(operacionGuardar);
            documento.Aceptar(operacionImprimir);
            Console.WriteLine("_________________________________\n");
        }
    }
}