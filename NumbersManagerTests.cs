using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;
using System.Linq;
using Moq;

namespace MyTests
{
    internal class NumbersManagerTests
    {
        NumbersManager manager;

        [SetUp]
        public void Setup()
        { 
            manager = new NumbersManager();
            Assert.IsInstanceOf(typeof(NumbersManager), manager);
        }

        [Test] //4
        public void SortAscendingListPositiveNumbers()
        {
            var list = new List<int>() { 5, 4, 1, 7 };
            var actual = manager.SortNumbers(list, true);
            var expected = new List<int>() { 1, 4, 5, 7 };
            Assert.AreEqual(expected, actual);
        }

        [Test] 
        public void SortAscendingListNegativeNumbers()
        {
            var list = new List<int>() { -5, -4, -1, -7 };
            Assert.Throws<Exception>(() => manager.SortNumbers(list, true));
        }

        [Test]
        public void SortDescendingListPositiveNumbers()
        {
            var list = new List<int>() { 5, 4, 1, 7 };
            var actual = manager.SortNumbers(list, false);
            var expected = new List<int>() { 7, 5, 4, 1 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SortDescendingListNegativeNumbers()
        {
            var list = new List<int>() { -5, -4, -1, -7 };
            Assert.Throws<Exception>(()=> manager.SortNumbers(list, false));
        }

    }
}
