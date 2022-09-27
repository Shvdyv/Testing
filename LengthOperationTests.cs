using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;
using System.Linq;

namespace MyTests
{
    internal class LengthOperationTests
    {
        LengthOperation operation;

        [SetUp]
        public void Setup()
        {
            operation = new LengthOperation();
            Assert.IsInstanceOf(typeof(LengthOperation), operation);

        }

        [Test] //4
        public void TextFirstIsNull()
        {
            Assert.Throws<Exception>(() => operation.CompareLength(null, "dfg"));
        }

        [Test]
        public void TextsSameLength()
        {
            var actual = operation.CompareLength("Aga", "Aga");
            var expected = true;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TextSecondIsLonger()
        {
            var actual = operation.CompareLength("Aga", "AgaF");
            var expected = false;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TextFirstIsLonger()
        {
            var actual = operation.CompareLength("AgaF", "Aga");
            var expected = false;
            Assert.AreEqual(expected, actual);
        }

    }
}
