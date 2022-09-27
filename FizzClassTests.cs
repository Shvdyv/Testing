using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;

namespace MyTests
{
    internal class FizzClassTests
    {
        [Test]
        public void CheckCreateObject()
        {
            var fizz = new FizzClass(15);
            Assert.IsInstanceOf(typeof(FizzClass), fizz);
        }

        [Test]
        public void PositiveNumberDivideByThreeAndFive()
        {
            var fizz = new FizzClass(15);
            var actual = fizz.CheckFizzBuzz();
            var expected = "FizzBuzz";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NegativeNumberDivideByThreeAndFive()
        {
            var fizz = new FizzClass(-15);
            var actual = fizz.CheckFizzBuzz();
            var expected = "FizzBuzz";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NegativeNumberDivideByThree()
        {
            var fizz = new FizzClass(-9);
            var actual = fizz.CheckFizzBuzz();
            var expected = "Fizz";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PositiveNumberDivideByThree()
        {
            var fizz = new FizzClass(9);
            var actual = fizz.CheckFizzBuzz();
            var expected = "Fizz";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NegativeNumberDivideByFive()
        {
            var fizz = new FizzClass(-10);
            var actual = fizz.CheckFizzBuzz();
            var expected = "Buzz";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PositiveNumberDivideByFive()
        {
            var fizz = new FizzClass(10);
            var actual = fizz.CheckFizzBuzz();
            var expected = "Buzz";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PositiveNumberNotDivideByThreeAndFive()
        {
            var fizz = new FizzClass(7);
            Assert.Throws<Exception>(() => fizz.CheckFizzBuzz());
        }

        [Test]
        public void NegativeNumberNotDivideByThreeAndFive()
        {
            var fizz = new FizzClass(-7);
            Assert.Throws<Exception>(() => fizz.CheckFizzBuzz());
        }

        
    }
}
