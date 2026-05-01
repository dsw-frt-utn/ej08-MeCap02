using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Methods
{
    internal partial class ProductHelper
    {
        public static void WriteElements(string? code, string? description, decimal? price)
        {
            Console.WriteLine(code);
            Console.WriteLine(description);
            Console.WriteLine(price);
        }

        
    }
}
