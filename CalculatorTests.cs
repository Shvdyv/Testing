using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;

namespace MyTests
{


    public class CalculatorTests //19
    {
        Calculator calculator;
        [SetUp]
        public void SetUp()
        {
            //Arrange
            calculator = new Calculator();
            Assert.IsInstanceOf(typeof(Calculator), calculator);
        }
        #region Dodawanie
        [Test]
        public void AddTwoPositiveNumbers()
        {
            //Act
            var actual = calculator.Add(1, 2);
            var expected = 3;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddTwoNegativeNumbers()
        {
            //Act
            var actual = calculator.Add(-1, -2);
            var expected = -3;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddPositiveAndNegativeNumbers()
        {
            //Act
            var actual = calculator.Add(1, -2);
            var expected = -1;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddNegativeAndPositiveNumbers()
        {
            //Act
            var actual = calculator.Add(-1, 2);
            var expected = 1;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(1,1,2)]
        [TestCase(-1, -1, -2)]
        [TestCase(-1, 1, 0)]
        [TestCase(1, -1, 0)]
        public void CheckAdd(int number1, int number2, int expected)
        {
            var actual = calculator.Add(number1, number2);
            //Assert
            Assert.AreEqual(expected, actual);

        }

        #endregion

        #region Odejmowanie

        [Test]
        public void SubstractTwoNegativeNumbers()
        {
            var actual = calculator.Substruct(-1, -3);
            var expected = 2;
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void SubstractTwoPositiveNumbers()
        {
            var actual = calculator.Substruct(1, 3);
            var expected = -2;
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void SubstractPositiveAndNegativeNumbers()
        {
            var actual = calculator.Substruct(1, -3);
            var expected = 4;
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void SubstractNegativeAndPositiveNumbers()
        {
            var actual = calculator.Substruct(-1, 3);
            var expected = -4;
            Assert.AreEqual(expected, actual);

        }
        #endregion

        #region Dzielenie

        [Test]
        public void DivideTwoPositiveNumbers()
        {
            var actual = calculator.Divide(4, 2);
            var expected = 2;
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void DivideTwoNegativeNumbers()
        {
            var actual = calculator.Divide(-4, -2);
            var expected = 2;
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void DivideNegativeAndPositiveNumbers()
        {
            var actual = calculator.Divide(-4, 2);
            var expected = -2;
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void DividePositiveAndNegativeNumbers()
        {
            var actual = calculator.Divide(4, -2);
            var expected = -2;
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void DividePositiveNumbersByZero()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0));
        }

        [Test]
        public void DivideNegativeNumbersByZero()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(-5, 0));
        }

        [Test]
        public void DivideZeroNumbersByZero()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(0, 0));
        }
        #endregion

        #region Mnożenie

        [Test]
        public void MultiplyPostiveAndNegativeNumbers()
        {
            var actual = calculator.Multiply(6, -3);
            var expected = -18;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void MultiplyNegativeAndPositiveNumbers()
        {
            var actual = calculator.Multiply(-6, 3);
            var expected = -18;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void MultiplyTwoPositiveNumbers()
        {
            var actual = calculator.Multiply(6, 3);
            var expected = 18;
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void MultiplyTwoNegativeNumbers()
        {
            var actual = calculator.Multiply(-6, -3);
            var expected = 18;
            Assert.AreEqual(expected, actual);

        }

        #endregion
    }
}

