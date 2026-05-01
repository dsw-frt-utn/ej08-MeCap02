using Dsw2026Ej8.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Methods
{
    internal class Problema3
    {

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
