using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Models
{
    internal class Sale
    {
        private decimal _price;

        public Sale(decimal price)
        {
            _price = price;
        }

        public virtual decimal CalculateTotal(decimal price)
        {
            return price;
        }

        public decimal GetPrice() => _price;
    }
}
