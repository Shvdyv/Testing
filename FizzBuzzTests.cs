using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;

namespace MyTests
{
    class FizzBuzzTests //8
    {
        FizzBuzz fizzBuzz;
        [SetUp]

        public void SetUp()
        {
            fizzBuzz = new FizzBuzz();
            Assert.IsInstanceOf(typeof(FizzBuzz), fizzBuzz);
        }
        [Test]
        [TestCase(15, "FizzBuzz")]
        [TestCase(-15, "FizzBuzz")]
        [TestCase(9, "Fizz")]
        [TestCase(-9, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(-10, "Buzz")]
        public void CheckFizzBuzz(int number, string expected)
        {
            var actual = fizzBuzz.CheckFizzBuzz(number);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PositiveNumberDivideByThreeAndFive()
        {
            var actual = fizzBuzz.CheckFizzBuzz(15);
            var expected = "FizzBuzz";
                Assert.AreEqual(expected, actual);
        }
        [Test]
        public void NegativeNumberDivideByThreeAndFive()
        {
            var actual = fizzBuzz.CheckFizzBuzz(-15);
            var expected = "FizzBuzz";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void NegativeNumberDivideByThree()
        {
            var actual = fizzBuzz.CheckFizzBuzz(-9);
            var expected = "Fizz";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PositiveNumberDivideByThree()
        {
            var actual = fizzBuzz.CheckFizzBuzz(9);
            var expected = "Fizz";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void NegativeNumberDivideByFive()
        {
            var actual = fizzBuzz.CheckFizzBuzz(-10);
            var expected = "Buzz";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PositiveNumberDivideByFive()
        {
            var actual = fizzBuzz.CheckFizzBuzz(10);
            var expected = "Buzz";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PositiveNumberNotDivideByThreeAndFive()
        {
            Assert.Throws<Exception>(()=>fizzBuzz.CheckFizzBuzz(7));
        }

        [Test]
        public void NegativeNumberNotDivideByThreeAndFive()
        {
            Assert.Throws<Exception>(() => fizzBuzz.CheckFizzBuzz(-7));
        }
    }
}
