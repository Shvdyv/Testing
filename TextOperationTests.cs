using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;
using System.Linq;
using Moq;

namespace MyTests
{
    internal class TextOperationTests
    {
        [Test]
        public void CheckCreateObject()
        {
            var mock = new Mock<ILengthOperation>();
            var operation = new TextOperation(mock.Object, "aga", "aga");
            Assert.IsInstanceOf(typeof(TextOperation), operation);
        }

        [Test]
        public void CheckPalindrom() //4
        {
            var mock = new Mock<ILengthOperation>();
            mock.Setup(m => m.CompareLength("aga", "aga")).Returns(true);
            var operation = new TextOperation(mock.Object, "aga", "aga");
            var actual = operation.GetNameCompare();
            var expected = "Palindrom";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckAnagram() 
        {
            var mock = new Mock<ILengthOperation>();
            mock.Setup(m => m.CompareLength("aga", "aag")).Returns(true);
            var operation = new TextOperation(mock.Object, "aga", "aag");
            var actual = operation.GetNameCompare();
            var expected = "Anagram";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckBrak()
        {
            var mock = new Mock<ILengthOperation>();
            mock.Setup(m => m.CompareLength("aga", "dsf")).Returns(true);
            var operation = new TextOperation(mock.Object, "aga", "dsf");
            var actual = operation.GetNameCompare();
            var expected = "Brak";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Wyjątek()
        {
            var mock = new Mock<ILengthOperation>();
            mock.Setup(m => m.CompareLength("aga", "dsfgghnjh")).Returns(false);
            var operation = new TextOperation(mock.Object, "aga", "dsfgghnjh");
            Assert.Throws<Exception>(() => operation.GetNameCompare());
        }
    }
}
