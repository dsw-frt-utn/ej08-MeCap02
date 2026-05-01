using Dsw2026Ej8.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Methods
{
    internal class Problema5
    {

        public decimal ObtenerImporteFinal(Sale sale)
        {
            decimal aux = sale.CalculateTotal(sale.GetPrice());
            Console.WriteLine($"Esto es lo que se va: {aux}");
            return aux;
        }
    }
}
