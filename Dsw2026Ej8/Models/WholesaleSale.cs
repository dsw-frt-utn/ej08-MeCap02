using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Models
{
    internal class WholesaleSale : Sale
    {
        public override decimal CalculateTotal(decimal price)
        {
            return price * 90 / 100;
        }
    }
}
