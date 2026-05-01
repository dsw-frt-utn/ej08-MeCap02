using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Models
{
    internal class Product
    {
        private long _code;
        private string _productDescription;
        private int _quantity;
        private double _total;

        public Product()
        {

        }

        public Product(long code, string productDescription, int quantity, double total)
        {
            _code = code;
            _productDescription = productDescription;
            _quantity = quantity;
            _total = total;
        }

        public void SetProductDescription(string productDescription) => _productDescription = productDescription;

        public string GetProductDescription() => _productDescription;
    }
}
