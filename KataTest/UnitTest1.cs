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
        public void TestTotalPriceOneItem()
        {
            var checkout = new Checkout();
            checkout.Scan(item1);
            var total = checkout.Total();
            Assert.AreEqual(0.50m, total);
        }
        [TestMethod]
        public void TestTotalPriceThreeItem()
        {
            var checkout = new Checkout();
            checkout.Scan(item1);
            checkout.Scan(item2);
            checkout.Scan(item3);
            var total = checkout.Total();
            Assert.AreEqual(1.40m, total);
        }

        [TestMethod]
        public void TestOfferOne()
        {
            var checkout = new Checkout();
            checkout.Scan(item1);
            checkout.Scan(item1);
            checkout.Scan(item1);
            var total = checkout.Total();
            Assert.AreEqual(1.30m, total);
        }
        [TestMethod]
        public void TestOfferTwo()
        {
            var checkout = new Checkout();
            checkout.Scan(item2);
            checkout.Scan(item2);
            var total = checkout.Total();
            Assert.AreEqual(0.45m, total);
        }
        [TestMethod]
        public void TestOfferOnePlusItemOne()
        {
            var checkout = new Checkout();
            checkout.Scan(item1);
            checkout.Scan(item1);
            checkout.Scan(item1);
            checkout.Scan(item1);
            var total = checkout.Total();
            Assert.AreEqual(1.80m, total);
        }
        [TestMethod]
        public void TestOfferOnePlusItemTwo()
        {
            var checkout = new Checkout();
            checkout.Scan(item1);
            checkout.Scan(item1);
            checkout.Scan(item1);
            checkout.Scan(item2);
            var total = checkout.Total();
            Assert.AreEqual(1.60m, total);
        }
        [TestMethod]
        public void TestOfferOnePlusItemThree()
        {
            var checkout = new Checkout();
            checkout.Scan(item1);
            checkout.Scan(item1);
            checkout.Scan(item1);
            checkout.Scan(item3);
            var total = checkout.Total();
            Assert.AreEqual(1.90m, total);
        }
    }
}
