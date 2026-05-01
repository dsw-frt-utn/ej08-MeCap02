using System;
using System.Collections.Generic;
using System.Text;
using Dsw2026Ej8.Models;

namespace Dsw2026Ej8.Methods
{
    internal class Problema6
    {
        public static string NormalizarCodigoProducto(string code)
        {
            return code.ToProductCode();
        }
    }
}
