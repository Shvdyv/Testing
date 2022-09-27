using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;

namespace MyTests
{
    public class CalculatorClassTests
    {
        [Test]
        public void CheckCreateObject()
        {
            var calculator = new CalculatorClass();
            Assert.IsInstanceOf(typeof(CalculatorClass), calculator);
        }

        #region Dodawanie
        [Test]
        public void AddTwoPositiveNumbers()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = 1,
                Number2 = 3
            };
            var actual = calculator.Add();
            var expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddTwoNegativeNumbers()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = -1,
                Number2 = -3
            };
            var actual = calculator.Add();
            var expected = -4;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddPositiveAndNegativeNumbers()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = 1,
                Number2 = -3
            };
            var actual = calculator.Add();
            var expected = -2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddNegativeAndPositiveNumbers()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = -1,
                Number2 = 3
            };
            var actual = calculator.Add();
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region Odejmowanie

        [Test]
        public void SubstractTwoNegativeNumbers()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = -1,
                Number2 = -3
            };
            var actual = calculator.Substruct();
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstractTwoPositiveNumbers()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = 1,
                Number2 = 3
            };
            var actual = calculator.Substruct();
            var expected = -2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstractPositiveAndNegativeNumbers()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = 1,
                Number2 = -3
            };
            var actual = calculator.Substruct();
            var expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstractNegativeAndPositiveNumbers()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = -1,
                Number2 = 3
            };
            var actual = calculator.Substruct();
            var expected = -4;
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region Dzielenie

        [Test]
        public void DivideTwoPositiveNumbers()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = 4,
                Number2 = 2
            };
            var actual = calculator.Divide();
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideTwoNegativeNumbers()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = -4,
                Number2 = -2
            };
            var actual = calculator.Divide();
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DividePositiveAndNegativeNumbers()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = 4,
                Number2 = -2
            };
            var actual = calculator.Divide();
            var expected = -2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideNegativeAndPositiveNumbers()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = -4,
                Number2 = 2
            };
            var actual = calculator.Divide();
            var expected = -2;
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void DividePositiveNumbersByZero()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = 4,
                Number2 = 0
            };

            Assert.Throws<DivideByZeroException>(()=> calculator.Divide());

        }
        
        [Test]

        public void DivideNegativeNumbersByZero()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = -4,
                Number2 = 0
            };

            Assert.Throws<DivideByZeroException>(() => calculator.Divide());

        }

        [Test]

        public void DivideZeroNumbersByZero()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = 0,
                Number2 = 0
            };

            Assert.Throws<DivideByZeroException>(() => calculator.Divide());

        }

        #endregion

        #region Mnożenie

        [Test]
        public void MultiplyTwoPositiveNumbers()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = 4,
                Number2 = 2
            };
            var actual = calculator.Multiply();
            var expected = 8;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyTwoNegativeNumbers()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = -4,
                Number2 = -2
            };
            var actual = calculator.Multiply();
            var expected = 8;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyPositiveAndNegativeNumbers()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = 4,
                Number2 = -2
            };
            var actual = calculator.Multiply();
            var expected = -8;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyNegativeAndPositiveNumbers()
        {
            var calculator = new CalculatorClass()
            {
                Number1 = -4,
                Number2 = 2
            };
            var actual = calculator.Multiply();
            var expected = -8;
            Assert.AreEqual(expected, actual);
        }

        #endregion
    }
}
