using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Methods
{
    internal class Problema2
    {
        public static int ValidateQuantity(int quantity)
        {
            if (quantity <= 0)
            {
                quantity = 0;
            }
            return quantity;
        }
        public static string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            quantity = ValidateQuantity(quantity);
            var myAnonimousObject = new { Code = productCode, Description = productDescription, Quantity = quantity, Total = quantity * unitPrice };
            return $"{myAnonimousObject.Code}-{myAnonimousObject.Description}-{myAnonimousObject.Total}";
        }

    }
}
