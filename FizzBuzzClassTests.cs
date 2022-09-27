using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;
using System.Linq;
using Moq;

namespace MyTests
{
    internal class FizzBuzzClassTests //8
    {
        [Test]
        public void CheckCreateObject()
        {
            var mock = new Mock<ICalculatorClass>();
            var fizzBuzz = new FizzBuzzClass(mock.Object, 9, 6);
            Assert.IsInstanceOf(typeof(FizzBuzzClass), fizzBuzz);
        }

        [Test]
        public void CheckPositiveNumberDivideByThreeAndFive()
        {
            var mock = new Mock<ICalculatorClass>();
            mock.Setup(m => m.Add(9, 6)).Returns(15);
            var fizzBuzz = new FizzBuzzClass(mock.Object, 9, 6);
            var actual = fizzBuzz.CheckFizzBuzz();
            var expected = "FizzBuzz";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckNegativeNumberDivideByThreeAndFive()
        {
            var mock = new Mock<ICalculatorClass>();
            mock.Setup(m => m.Add(-9, -6)).Returns(-15);
            var fizzBuzz = new FizzBuzzClass(mock.Object, -9, -6);
            var actual = fizzBuzz.CheckFizzBuzz();
            var expected = "FizzBuzz";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckNegativeNumberDivideByThree()
        {
            var mock = new Mock<ICalculatorClass>();
            mock.Setup(m => m.Substruct(-3, 6)).Returns(-9);
            var fizzBuzz = new FizzBuzzClass(mock.Object, -3, 6);
            var actual = fizzBuzz.CheckFizzBuzz();
            var expected = "Fizz";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckPositiveNumberDivideByThree()
        {
            var mock = new Mock<ICalculatorClass>();
            mock.Setup(m => m.Substruct(3, -6)).Returns(9);
            var fizzBuzz = new FizzBuzzClass(mock.Object, 3, -6);
            var actual = fizzBuzz.CheckFizzBuzz();
            var expected = "Fizz";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckNegativeNumberDivideByFive()
        {
            var mock = new Mock<ICalculatorClass>();
            mock.Setup(m => m.Multiply(10, -1)).Returns(-10);
            var fizzBuzz = new FizzBuzzClass(mock.Object, 10, -1);
            var actual = fizzBuzz.CheckFizzBuzz();
            var expected = "Buzz";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckPositiveNumberDivideByFive()
        {
            var mock = new Mock<ICalculatorClass>();
            mock.Setup(m => m.Multiply(10, 1)).Returns(10);
            var fizzBuzz = new FizzBuzzClass(mock.Object, 10, 1);
            var actual = fizzBuzz.CheckFizzBuzz();
            var expected = "Buzz";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckPositiveNumberNotDivideByThreeAndFive()
        {
            var mock = new Mock<ICalculatorClass>();
            mock.Setup(m => m.Add(2, 5)).Returns(7);
            var fizzBuzz = new FizzBuzzClass(mock.Object, 2, 5);
            Assert.Throws<Exception>(() => fizzBuzz.CheckFizzBuzz());

        }

        [Test]
        public void CheckNegativeNumberNotDivideByThreeAndFive()
        {
            var mock = new Mock<ICalculatorClass>();
            mock.Setup(m => m.Add(-2, -5)).Returns(-7);
            var fizzBuzz = new FizzBuzzClass(mock.Object, -2, -5);
            Assert.Throws<Exception>(() => fizzBuzz.CheckFizzBuzz());

        }


    }
}
