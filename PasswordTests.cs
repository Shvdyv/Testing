using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;

namespace MyTests //6
{
    class PasswordTests
    {
        Password password;
        [SetUp]

        public void SetUp()
        {
            password = new Password();
            Assert.IsInstanceOf(typeof(Password), password);
        }

        [Test]
        public void CheckCorrectPassword()
        {
            var actual = password.CheckPassword("Agusia1@");
            Assert.IsTrue(actual);
        }
        [Test]
        public void CheckPasswordWithoutBigLetter()
        {
            var actual = password.CheckPassword("agusia1@");
            Assert.IsFalse(actual);
        }
        [Test]
        public void CheckPasswordWithoutSpecialChar()
        {
            var actual = password.CheckPassword("Agusia11");
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckPasswordWithoutNumber()
        {
            var actual = password.CheckPassword("Agusia@@");
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckPasswordWithoutEightChar()
        {
            var actual = password.CheckPassword("Agusi1@");
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckPasswordWithoutSmallLetters()
        {
            var actual = password.CheckPassword("AGUSIA1@");
            Assert.IsFalse(actual);
        }
        
    }
}
