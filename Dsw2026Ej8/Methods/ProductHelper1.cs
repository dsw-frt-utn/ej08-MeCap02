using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Methods
{
    internal partial class ProductHelper1
    {
        public static string ObtenerEtiquetaProducto(long code, string description, decimal price) => $"[{code}] {description} - {price}";

    }
}
