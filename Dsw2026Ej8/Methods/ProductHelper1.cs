using System;
using System.Collections.Generic;
using System.Text;
using Dsw2026Ej8.Models;

namespace Dsw2026Ej8.Methods
{
    internal partial class ProductHelper
    {
        public static string ObtenerEtiquetaProducto(long code, string description, decimal price) => $"[{code}] {description} - {price}";

        
    }
}
