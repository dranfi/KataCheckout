using System;
using System.Collections.Generic;
using System.Text;

namespace Kata
{
    public class Offer
    {
        public string Sku { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Offer(string sku, int quantity, decimal price)
        {
            Sku = sku;
            Quantity = quantity;
            Price = price;
        }
    }
}
