using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;

namespace MyTests
{
    class ShopTests //8
    {
        Shop shop;
        [SetUp]

        public void SetUp()
        {
            shop = new Shop();
            Assert.IsInstanceOf(typeof(Shop), shop);
        }

        [Test]
        public void CheckDiscountForNine()
        {
            var actual = shop.CreateDiscount(1,9);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckDiscountForTen()
        {
            var actual = shop.CreateDiscount(2, 10);
            var expected = 0.2;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckDiscountForTwentyNine()
        {
            var actual = shop.CreateDiscount(2, 29);
            var expected = 0.2;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckDiscountForThirty()
        {
            var actual = shop.CreateDiscount(2, 30);
            var expected = 5.3;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckDiscountForFourtyNine()
        {
            var actual = shop.CreateDiscount(2, 49);
            var expected = 5.3;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckDiscountForFifty()
        {
            var actual = shop.CreateDiscount(2, 50);
            var expected = 10.4;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDiscountForNinetyNine()
        {
            var actual = shop.CreateDiscount(2, 99);
            var expected = 10.4;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDiscountForHundred()
        {
            var actual = shop.CreateDiscount(2, 100);
            var expected = 15.5;
            Assert.AreEqual(expected, actual);
        }

    }
}
