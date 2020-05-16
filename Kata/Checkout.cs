using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Kata
{
    public class Checkout
    {
        private List<Item> items = new List<Item>();
        public decimal Total()
        {
            return items.Sum(i => i.Price);
        }

        public void Scan(Item item)
        {
            items.Add(item);
        }
    }
}
