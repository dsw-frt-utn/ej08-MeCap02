using Dsw2026Ej8.Methods;
using Dsw2026Ej8.Models;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRIMER PROBLEMA");
            Console.WriteLine(ProductHelper.ObtenerEtiquetaProducto(1234567890, "placeholder", 999));
            Console.WriteLine("SEGUNDO PROBLEMA");
            Console.WriteLine(Problema2.CrearResumenVenta(1234567890, "placeholder", 10, 149));
            Console.WriteLine("TERCER PROBLEMA");
            Product newObject = new Product(123, "placeholder", 10, 1000);
            Console.WriteLine(Problema3.CompararCopias(100, newObject));
            Console.WriteLine("CUARTO PROBLEMA");
            Console.WriteLine($"{Problema4.CalcularPromedio()}");
            Console.WriteLine("QUINTO PROBLEMA");
            Sale newObjectTheSecond = new Sale(1234);
            Console.WriteLine($"Esto es lo que llega: {Problema5.ObtenerImporteFinal(newObjectTheSecond)}");
            Console.WriteLine("SEXTO PROBLEMA");
            Console.WriteLine(Problema6.NormalizarCodigoProducto("asioaISA 123 5    blabla"));
        }
    }
}
