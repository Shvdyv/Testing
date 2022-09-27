using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;

namespace MyTests
{
    internal class PasswordClassTests
    {
        [Test]
        public void CheckCreateObject()
        {
            var passClass = new PasswordClass();
            Assert.IsInstanceOf(typeof(PasswordClass), passClass);
        }

        [Test]
        public void CheckCorrectPassword()
        {
            var passwordClass = new PasswordClass()
            {
                MyPassword = "Agusia@1"
            };

            var actual = passwordClass.CheckPassword();
            Assert.IsTrue(actual);
               
        }
        [Test]
        public void CheckPasswordWithoutSmallLetters()
        {
            var passwordClass = new PasswordClass()
            {
                MyPassword = "AGUSIA@1"
            };

            var actual = passwordClass.CheckPassword();
            Assert.IsFalse(actual);

        }

        [Test]
        public void CheckPasswordWithoutBigLetter()
        {
            var passwordClass = new PasswordClass()
            {
                MyPassword = "agusia@1"
            };

            var actual = passwordClass.CheckPassword();
            Assert.IsFalse(actual);

        }

        [Test]
        public void CheckPasswordWithoutSpecialChar()
        {
            var passwordClass = new PasswordClass()
            {
                MyPassword = "Agusia11"
            };

            var actual = passwordClass.CheckPassword();
            Assert.IsFalse(actual);

        }

        [Test]
        public void CheckPasswordWithoutNumber()
        {
            var passwordClass = new PasswordClass()
            {
                MyPassword = "Agusia@@"
            };

            var actual = passwordClass.CheckPassword();
            Assert.IsFalse(actual);

        }

        [Test]
        public void CheckPasswordWithoutEightChar()
        {
            var passwordClass = new PasswordClass()
            {
                MyPassword = "Agusi@1"
            };

            var actual = passwordClass.CheckPassword();
            Assert.IsFalse(actual);

        }
    }
}
