using DesignPatterns.Prototype;

class Program
{
    static void Main(string[] args)
    {
        //Crear instancias de documentos
        DocumentoTexto docTexto = new DocumentoTexto("Contenido inicial del documento de texto");
        HojaCalculo hojaCalculo = new HojaCalculo("Datos iniciales de la hoja de cálculo");

        //Crear el gestor de prototipos y registrar los documentos
        GestorPrototipos gestor = new GestorPrototipos();
        gestor.RegistrarPrototipos("Texto", docTexto);
        gestor.RegistrarPrototipos("HojaCalculo", hojaCalculo);

        //Obtener clones de los prototipos registrados
        IPrototipoDocumento clonDocTexto = gestor.ObtenerPrototipo("Texto");
        IPrototipoDocumento clonHojaCalculo = gestor.ObtenerPrototipo("HojaCalculo");

        //Modificar contenido del clon
        (clonDocTexto as DocumentoTexto).Contenido = "Contenido modificado del documento de texto";
        (clonHojaCalculo as HojaCalculo).Datos = "Datos modificados de la hoja de cálculo";

        //Motrar la informacion de los Originales y los Clones
        docTexto.MostrarInformacion();
        hojaCalculo.MostrarInformacion();

        Console.WriteLine("\n");

        clonDocTexto.MostrarInformacion();
        clonHojaCalculo.MostrarInformacion();
    }
}
