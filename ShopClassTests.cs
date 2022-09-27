using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;

namespace MyTests
{
    internal class ShopClassTests
    {
        [Test]
        public void CheckCreateObject()
        {
            var shop = new ShopClass(2, 9);
            Assert.IsInstanceOf(typeof(ShopClass), shop);
        }

        [Test]
        public void CheckDiscountForNine()
        {
            var shopClass = new ShopClass(2, 9);
            var actual = shopClass.CreateDiscount();
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
       public void CheckDiscountForTen()
        {
            var shopClass = new ShopClass(2, 10);
            var actual = shopClass.CreateDiscount();
            var expected = 0.2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDiscountForTwentyNine()
        {
            var shopClass = new ShopClass(2, 29);
            var actual = shopClass.CreateDiscount();
            var expected = 0.2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDiscountForThirty()
        {
            var shopClass = new ShopClass(2, 30);
            var actual = shopClass.CreateDiscount();
            var expected = 5.3;
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void CheckDiscountForFourtyNine()
        {
            var shopClass = new ShopClass(2, 49);
            var actual = shopClass.CreateDiscount();
            var expected = 5.3;
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void CheckDiscountForFifty()
        {
            var shopClass = new ShopClass(2, 50);
            var actual = shopClass.CreateDiscount();
            var expected = 10.4;
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void CheckDiscountForNinetyNine()
        {
            var shopClass = new ShopClass(2, 99);
            var actual = shopClass.CreateDiscount();
            var expected = 10.4;
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void CheckDiscountForHundred()
        {
            var shopClass = new ShopClass(2, 100);
            var actual = shopClass.CreateDiscount();
            var expected = 15.5;
            Assert.AreEqual(expected, actual);
        }
    }
}
