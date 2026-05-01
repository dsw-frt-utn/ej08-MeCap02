using System;
using System.Collections.Generic;
using System.Text;
using Dsw2026Ej8.Models;

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

        public static string CompararCopias(int originalValue, Product product)
        {
            ref int auxValue = ref originalValue;
            auxValue++;
            ref Product auxProduct = ref product;
            auxProduct.SetProductDescription("");
            return $"{originalValue}-{auxValue}-{auxProduct.GetProductDescription()}";
        }
    }
}
