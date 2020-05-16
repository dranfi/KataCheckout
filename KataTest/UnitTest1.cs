using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.Design;

namespace KataTest
{
    [TestClass]
    public class UnitTest1
    {
        Item item1 = new Item() { Sku = "A99", Price = 0.50m };
        Item item2 = new Item() { Sku = "B15", Price = 0.30m };
        Item item3 = new Item() { Sku = "C40", Price = 0.60m };
        [TestMethod]
        public void TotalPriceOneItem()
        {
            var checkout = new Checkout();
            checkout.Scan(item1);
            var total = checkout.Total();
            Assert.AreEqual(0.50m, total);
        }
        [TestMethod]
        public void TotalPriceThreeItem()
        {
            var checkout = new Checkout();
            checkout.Scan(item1);
            checkout.Scan(item2);
            checkout.Scan(item3);
            var total = checkout.Total();
            Assert.AreEqual(1.40m, total);
        }
    }
}
