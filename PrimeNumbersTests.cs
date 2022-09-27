using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;
using System.Linq;
using Moq;

namespace MyTests
{
    internal class PrimeNumbersTests
    {
        [Test]
        public void CheckCreateObject()
        {
            var mock = new Mock<INumbersManager>();
            var list = new List<int>() { 4, 1, 9, 5 };
            var primeNumber = new PrimeNumber(mock.Object, list, true);
            Assert.IsInstanceOf(typeof(PrimeNumber), primeNumber);
        }

        [Test]
        public void ReturnCountPrimeNumbersASC()
        {
            var mock = new Mock<INumbersManager>();
            var list = new List<int>() { 4, 1, 9, 5 };
            mock.Setup(m => m.SortNumbers(list, true)).Returns(new List<int>() {1, 4, 5, 9});
            var primeNumber = new PrimeNumber(mock.Object, list, true);
            var actual = primeNumber.CountNumbers();
            Assert.IsTrue(actual.QuantityPrimeNumbers == 1 && actual.QuantityNotPrimeNumbers == 3);
        }

        [Test]
        public void ReturnCountPrimeNumbersDESC()
        {
            var mock = new Mock<INumbersManager>();
            var list = new List<int>() { 4, 1, 9, 5 };
            mock.Setup(m => m.SortNumbers(list, false)).Returns(new List<int>() { 9, 5, 4, 1 });
            var primeNumber = new PrimeNumber(mock.Object, list, false);
            var actual = primeNumber.CountNumbers();
            Assert.IsTrue(actual.QuantityPrimeNumbers == 1 && actual.QuantityNotPrimeNumbers == 3);
        }
    }
}
