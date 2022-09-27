using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;
using System.Linq;


namespace MyTests
{
    internal class RandomizeTests //6
    {
        Randomize randomize;
        [SetUp]
        public void Setup()
        {
            var random = new Random();
            randomize = new Randomize(random);
            Assert.IsInstanceOf(typeof(Randomize), randomize);
        }
        #region 1
        [Test]
        public void RandomNegativeNumber()
        {
            var actual = randomize.RandomNumber(-10, -1);
            Assert.IsTrue(actual <= -1 && actual >= -10);
        }

        [Test]
        public void RandomPositiveNumber()
        {
            var actual = randomize.RandomNumber(1, 10);
            Assert.IsTrue(actual >= 1 && actual <= 10);
        }

        [Test]
        public void RandomNegativeOrPositiveNumber()
        {
            var actual = randomize.RandomNumber(-5, 5);
            Assert.IsTrue(actual >= -5 && actual <= 5);
        }

        [Test]
        public void TryRandomNegativeOrPositiveNumberMaxLowerMin()
        {
            Assert.Throws<Exception>(() => randomize.RandomNumber(5, -5));
        }

        [Test]
        public void TryRandomNegativeNumberMaxLowerMin()
        {
            Assert.Throws<Exception>(() => randomize.RandomNumber(-1, -10));
        }

        [Test]
        public void TryRandomPositiveNumberMaxLowerMin()
        {
            Assert.Throws<Exception>(() => randomize.RandomNumber(10, 1));
        }

        // #2

        [Test]
        public void TryRandomWordWitHSmallLettersLengthLessThanZero() //4
        {
            Assert.Throws<Exception>(() => randomize.RandomString(-7, true));
        }

        [Test]
        public void TryRandomWordWithBigLettersLengthLessThanZero()
        {
            Assert.Throws<Exception>(() => randomize.RandomString(-7, false));
        }

        [Test]
        public void RandomWordWithBigLetters()
        {
            var actual = randomize.RandomString(2, false);
            Assert.IsTrue(actual.Length == 2 && actual.All(char.IsUpper));

        }

        [Test]
        public void RandomWordWithSmallLetters()
        {
            var actual = randomize.RandomString(2, true);
            Assert.IsTrue(actual.Length == 2 && actual.All(char.IsLower));

        }

        #endregion

        #region 2

        [Test] // ok. 38
        public void RandomPasswordWithAllCharacters()
        {
            var actual = randomize.RandomPassword(true, true, 5, 2);
            Assert.IsTrue(actual.Length == 9 && actual.Any(char.IsUpper) && actual.Any(char.IsLower) &&
                actual.Any(char.IsDigit) && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithoutNumbers()
        {
            var actual = randomize.RandomPassword(false, true, 5, 2);
            Assert.IsTrue(actual.Length == 8 && actual.Any(char.IsUpper) && actual.Any(char.IsLower) &&
                !actual.Any(char.IsDigit) && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithoutSpecialChar()
        {
            var actual = randomize.RandomPassword(true, false, 5, 2);
            Assert.IsTrue(actual.Length == 8 && actual.Any(char.IsUpper) && actual.Any(char.IsLower) &&
                actual.Any(char.IsDigit) && actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithoutSpecialCharAndNumber()
        {
            var actual = randomize.RandomPassword(false, false, 5, 2);
            Assert.IsTrue(actual.Length == 7 && actual.Any(char.IsUpper) && actual.Any(char.IsLower) &&
                !actual.Any(char.IsDigit) && actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithoutSmallLetters()
        {
            var actual = randomize.RandomPassword(true, true, 0, 2);
            Assert.IsTrue(actual.Length == 4 && actual.Any(char.IsUpper) && !actual.Any(char.IsLower) &&
                actual.Any(char.IsDigit) && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithoutBigLetters()
        {
            var actual = randomize.RandomPassword(true, true, 2, 0);
            Assert.IsTrue(actual.Length == 4 && !actual.Any(char.IsUpper) && actual.Any(char.IsLower) &&
                actual.Any(char.IsDigit) && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithoutSmallLettersAndNumber()
        {
            var actual = randomize.RandomPassword(false, true, 0, 2);
            Assert.IsTrue(actual.Length == 3 && actual.Any(char.IsUpper) && !actual.Any(char.IsLower) &&
                !actual.Any(char.IsDigit) && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithoutSmallLettersAndSpecialChar()
        {
            var actual = randomize.RandomPassword(true, false, 0, 2);
            Assert.IsTrue(actual.Length == 3 && actual.Any(char.IsUpper) && !actual.Any(char.IsLower) &&
                actual.Any(char.IsDigit) && actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithoutSmallLettersAndSpecialCharAndNumber()
        {
            var actual = randomize.RandomPassword(false, false, 0, 5);
            Assert.IsTrue(actual.Length == 5 && actual.Any(char.IsUpper) && !actual.Any(char.IsLower) &&
                !actual.Any(char.IsDigit) && actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithoutBigLettersAndNumber()
        {
            var actual = randomize.RandomPassword(false, true, 2, 0);
            Assert.IsTrue(actual.Length == 3 && !actual.Any(char.IsUpper) && actual.Any(char.IsLower) &&
                !actual.Any(char.IsDigit) && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithoutBigLettersAndSpecialChar()
        {
            var actual = randomize.RandomPassword(true, false, 2, 0);
            Assert.IsTrue(actual.Length == 3 && !actual.Any(char.IsUpper) && actual.Any(char.IsLower) &&
                actual.Any(char.IsDigit) && actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithoutBigLettersAndSpecialCharAndNumber()
        {
            var actual = randomize.RandomPassword(false, false, 5, 0);
            Assert.IsTrue(actual.Length == 5 && !actual.Any(char.IsUpper) && actual.Any(char.IsLower) &&
                !actual.Any(char.IsDigit) && actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithOnlyNumber()
        {
            var actual = randomize.RandomPassword(true, false, 0, 0);
            Assert.IsTrue(actual.Length == 1 && !actual.Any(char.IsUpper) && !actual.Any(char.IsLower) &&
                actual.Any(char.IsDigit) && actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithOnlySpecialChar()
        {
            var actual = randomize.RandomPassword(false, true, 0, 0);
            Assert.IsTrue(actual.Length == 1 && !actual.Any(char.IsUpper) && !actual.Any(char.IsLower) &&
                !actual.Any(char.IsDigit) && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithOnlySpecialCharAndNumber()
        {
            var actual = randomize.RandomPassword(true, true, 0, 0);
            Assert.IsTrue(actual.Length == 2 && !actual.Any(char.IsUpper) && !actual.Any(char.IsLower) &&
                actual.Any(char.IsDigit) && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithOnlySmallLetters()
        {
            var actual = randomize.RandomPassword(false, false, 2, 0);
            Assert.IsTrue(actual.Length == 2 && !actual.Any(char.IsUpper) && actual.Any(char.IsLower) &&
                !actual.Any(char.IsDigit) && actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithOnlyBigLetters()
        {
            var actual = randomize.RandomPassword(false, false, 0, 2);
            Assert.IsTrue(actual.Length == 2 && actual.Any(char.IsUpper) && !actual.Any(char.IsLower) &&
                !actual.Any(char.IsDigit) && actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithBigLettersAndSmallLetters()
        {
            var actual = randomize.RandomPassword(false, false, 2, 2);
            Assert.IsTrue(actual.Length == 4 && actual.Any(char.IsUpper) && actual.Any(char.IsLower) &&
                !actual.Any(char.IsDigit) && actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void RandomPasswordWithNothing()
        {
            var actual = randomize.RandomPassword(false, false, 0, 0);
            Assert.IsTrue(actual.Length == 0 && !actual.Any(char.IsUpper) && !actual.Any(char.IsLower) &&
                !actual.Any(char.IsDigit) && actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void CheckPasswordWithNegativeLengthSmallLetters()
        {
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, false, -2, 0));
        }

        [Test]
        public void CheckPasswordWithNegativeLengthBigLetters()
        {
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, false, 0, -2));
        }

        [Test]
        public void CheckPasswordWithNegativeLengthSmallAndBigLetters()
        {
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, false, -2, 2));
        }

        [Test]
        public void CheckPasswordWithSmallLettersAndNegativeLengthBigLetters()
        {
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, false, 2, -2));
        }

        //[Test]
        //public void CheckPasswordWithNegativeLengthBigLetters()
        //{
        //    Assert.Throws<Exception>(() => randomize.RandomPassword(false, true, 2, -2));
        //}

        #endregion















    }
}
