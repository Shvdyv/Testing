using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;
using System.Linq;
using Moq;

namespace MyTests
{
    internal class PassTests
    {
        [Test]
        public void CheckCreateObject()
        {
            var mock = new Mock<IRandomize>();
            var pass = new Pass(mock.Object, true, true, 3, 3);
            Assert.IsInstanceOf(typeof(Pass), pass);
        }

        [Test]
        public void CheckCorrectPassword()
        {
            var mock = new Mock<IRandomize>();
            mock.Setup(m => m.RandomPassword(true, true, 3, 3)).Returns("AGUsia1@");
            var password = new Pass(mock.Object, true, true, 3, 3);
            var actual = password.CheckPassword();
            Assert.IsTrue(actual);
        }

        [Test]
        public void CheckPasswordWithoutSmallLetters()
        {
            var mock = new Mock<IRandomize>();
            mock.Setup(m => m.RandomPassword(true, true, 0, 6)).Returns("AGUSIA1@");
            var password = new Pass(mock.Object, true, true, 0, 6);
            var actual = password.CheckPassword();
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckPasswordWithoutBigLetters()
        {
            var mock = new Mock<IRandomize>();
            mock.Setup(m => m.RandomPassword(true, true, 6, 0)).Returns("agusia1@");
            var password = new Pass(mock.Object, true, true, 6, 0);
            var actual = password.CheckPassword();
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckPasswordWithoutSpecialChar()
        {
            var mock = new Mock<IRandomize>();
            mock.Setup(m => m.RandomPassword(true, false, 6, 1)).Returns("Agusiaa1");
            var password = new Pass(mock.Object, true, false, 6, 1);
            var actual = password.CheckPassword();
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckPasswordWithoutNumber()
        {
            var mock = new Mock<IRandomize>();
            mock.Setup(m => m.RandomPassword(false, true, 6, 1)).Returns("Agusiaa@");
            var password = new Pass(mock.Object, false, true, 6, 1);
            var actual = password.CheckPassword();
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckPasswordWithoutEightCharacters()
        {
            var mock = new Mock<IRandomize>();
            mock.Setup(m => m.RandomPassword(true, true, 4, 1)).Returns("Agusi1@");
            var password = new Pass(mock.Object, true, true, 4, 1);
            var actual = password.CheckPassword();
            Assert.IsFalse(actual);
        }

    }
}
