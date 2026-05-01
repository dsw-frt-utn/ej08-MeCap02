using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Methods
{
    internal partial class ProductHelper
    {
        public static string ObtenerEtiquetaProducto(long code, string description, decimal price) => $"[{code}] {description} - {price}";

        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            quantity = ValidateQuantity(quantity);
            var myAnonimousObject = new { Code = productCode, Description = productDescription, Quantity = quantity, Total = quantity * unitPrice };
            return $"{myAnonimousObject.Code}-{myAnonimousObject.Description}-{myAnonimousObject.Total}";
        }
    }
}
