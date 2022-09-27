using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;
using System.Linq;
using Moq;

namespace MyTests
{
    internal class CalcTests
    {
        [Test]
        public void CheckCreateObject()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            var calc = new Calc(1, 10, 1, 10, mock1.Object, mock2.Object);
            Assert.IsInstanceOf(typeof(Calc), calc);
        }

        #region Dodawanie
        [Test]
        public void AddTwoPositiveNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(1, 10)).Returns(5);
            mock2.Setup(m => m.RandomNumber(1, 10)).Returns(7);

            var calc = new Calc(1, 10, 1, 10, mock1.Object, mock2.Object);

            var actual = calc.Add();
            var expected = 12;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void AddTwoNegativeNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(-10, -1)).Returns(-5);
            mock2.Setup(m => m.RandomNumber(-10, -1)).Returns(-7);

            var calc = new Calc(-10, -1, -10, -1, mock1.Object, mock2.Object);

            var actual = calc.Add();
            var expected = -12;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void AddNegativeAndPositiveNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(-10, -1)).Returns(-5);
            mock2.Setup(m => m.RandomNumber(1, 10)).Returns(7);

            var calc = new Calc(-10, -1, 1, 10, mock1.Object, mock2.Object);

            var actual = calc.Add();
            var expected = 2;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void AddPositiveAndNegativeNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(1, 10)).Returns(5);
            mock2.Setup(m => m.RandomNumber(-10, -1)).Returns(-7);

            var calc = new Calc(1, 10, -10, -1, mock1.Object, mock2.Object);

            var actual = calc.Add();
            var expected = -2;
            Assert.AreEqual(expected, actual);

        }

        #endregion

        #region Odejmowanie

        [Test]
        public void SubstructTwoPositiveNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(1, 10)).Returns(5);
            mock2.Setup(m => m.RandomNumber(1, 10)).Returns(7);

            var calc = new Calc(1, 10, 1, 10, mock1.Object, mock2.Object);

            var actual = calc.Substruct();
            var expected = -2;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void SubstructTwoNegativeNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(-10, -1)).Returns(-5);
            mock2.Setup(m => m.RandomNumber(-10, -1)).Returns(-7);

            var calc = new Calc(-10, -1, -10, -1, mock1.Object, mock2.Object);

            var actual = calc.Substruct();
            var expected = 2;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void SubstructNegativeAndPositiveNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(-10, -1)).Returns(-5);
            mock2.Setup(m => m.RandomNumber(1, 10)).Returns(7);

            var calc = new Calc(-10, -1, 1, 10, mock1.Object, mock2.Object);

            var actual = calc.Substruct();
            var expected = -12;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void SubstructPositiveAndNegativeNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(1, 10)).Returns(5);
            mock2.Setup(m => m.RandomNumber(-10,-1)).Returns(-7);

            var calc = new Calc(1, 10, -10, -1, mock1.Object, mock2.Object);

            var actual = calc.Substruct();
            var expected = 12;
            Assert.AreEqual(expected, actual);

        }

        #endregion

        #region Dzielenie

        [Test]

        public void DividePositiveNumberByZero()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m=> m.RandomNumber(0,10)).Returns(5);
            mock2.Setup(m => m.RandomNumber(0, 10)).Returns(0);

            var calc = new Calc(0, 10, 0, 10, mock1.Object, mock2.Object);
            Assert.Throws<DivideByZeroException>(() => calc.Divide());
        }

        [Test]

        public void DivideNegativeNumberByZero()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(-10, -1)).Returns(-5);
            mock2.Setup(m => m.RandomNumber(0, 10)).Returns(0);

            var calc = new Calc(-10, -1, 0, 10, mock1.Object, mock2.Object);
            Assert.Throws<DivideByZeroException>(() => calc.Divide());
        }

        [Test]

        public void DivideZeroByZero()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(0, 10)).Returns(0);
            mock2.Setup(m => m.RandomNumber(0, 10)).Returns(0);

            var calc = new Calc(0, 10, 0, 10, mock1.Object, mock2.Object);
            Assert.Throws<DivideByZeroException>(() => calc.Divide());
        }

        [Test]
        public void DivideTwoPositiveNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(1, 10)).Returns(10);
            mock2.Setup(m => m.RandomNumber(1, 10)).Returns(5);

            var calc = new Calc(1, 10, 1, 10, mock1.Object, mock2.Object);

            var actual = calc.Divide();
            var expected = 2;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void DivideTwoNegativeNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(-10, -1)).Returns(10);
            mock2.Setup(m => m.RandomNumber(-10, -1)).Returns(5);

            var calc = new Calc(-10, -1, -10, -1, mock1.Object, mock2.Object);

            var actual = calc.Divide();
            var expected = 2;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void DivideNegativeAndPositiveNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(-10, -1)).Returns(-10);
            mock2.Setup(m => m.RandomNumber(1, 10)).Returns(5);

            var calc = new Calc(-10, -1, 1, 10, mock1.Object, mock2.Object);

            var actual = calc.Divide();
            var expected = -2;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void DividePositiveAndNegativeNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(1, 10)).Returns(10);
            mock2.Setup(m => m.RandomNumber(-10, -1)).Returns(-5);

            var calc = new Calc(1, 10, -10, -1, mock1.Object, mock2.Object);

            var actual = calc.Divide();
            var expected = -2;
            Assert.AreEqual(expected, actual);

        }

        #endregion

        #region Mnożenie

        [Test]
        public void MultiplyTwoPositiveNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(1, 10)).Returns(10);
            mock2.Setup(m => m.RandomNumber(1, 10)).Returns(5);

            var calc = new Calc(1, 10, 1, 10, mock1.Object, mock2.Object);

            var actual = calc.Multiply();
            var expected = 50;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void MultiplyTwoNegativeNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(-10, -1)).Returns(-10);
            mock2.Setup(m => m.RandomNumber(-10, -1)).Returns(-5);

            var calc = new Calc(-10, -1, -10, -1, mock1.Object, mock2.Object);

            var actual = calc.Multiply();
            var expected = 50;
            Assert.AreEqual(expected, actual);

        }

        public void MultiplyNegativeAndPositiveNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(-10, -1)).Returns(-10);
            mock2.Setup(m => m.RandomNumber(1, 10)).Returns(5);

            var calc = new Calc(-10, -1, 1, 10, mock1.Object, mock2.Object);

            var actual = calc.Multiply();
            var expected = -50;
            Assert.AreEqual(expected, actual);

        }

        public void MultiplyPositiveAndNegativeNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();

            mock1.Setup(m => m.RandomNumber(1, 10)).Returns(10);
            mock2.Setup(m => m.RandomNumber(-10, -1)).Returns(-5);

            var calc = new Calc(1, 10, -10, -1, mock1.Object, mock2.Object);

            var actual = calc.Multiply();
            var expected = -50;
            Assert.AreEqual(expected, actual);

        }

        #endregion
    }
}
