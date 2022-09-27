using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;
using System.Linq;
using Moq;

namespace MyTests
{
    internal class PersonalityTests
    {
        [Test]
        public void CheckCreateObject()
        {
            var mock = new Mock<ICode>();
            var personality = new Personality(mock.Object, true, true, true, true);
            Assert.IsInstanceOf(typeof(Personality), personality);
        }

        [Test] //17
        public void CheckWykonawca()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, true, true)).Returns("ESTJ");
            var personality = new Personality(mock.Object, true, true, true, true);
            var actual = personality.GetPersonality();
            var expected = "Wykonawca";
            Assert.AreEqual(expected, actual);
        }

        [Test] 
        public void CheckArchitekt()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, true, true)).Returns("INTJ");
            var personality = new Personality(mock.Object, false, false, true, true);
            var actual = personality.GetPersonality();
            var expected = "Architekt";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckLogik()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, true, false)).Returns("INTP");
            var personality = new Personality(mock.Object, false, false, true, false);
            var actual = personality.GetPersonality();
            var expected = "Logik";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDowódca()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, false, true, true)).Returns("ENTJ");
            var personality = new Personality(mock.Object, true, false, true, true);
            var actual = personality.GetPersonality();
            var expected = "Dowódca";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDyskutant()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, true, true)).Returns("ENTP");
            var personality = new Personality(mock.Object, false, false, true, true);
            var actual = personality.GetPersonality();
            var expected = "Dyskutant";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckRzecznik()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, false, true)).Returns("INFJ");
            var personality = new Personality(mock.Object, false, false, false, true);
            var actual = personality.GetPersonality();
            var expected = "Rzecznik";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckPośrednik()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, false, false)).Returns("INFP");
            var personality = new Personality(mock.Object, false, false, false, false);
            var actual = personality.GetPersonality();
            var expected = "Pośrednik";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckProtagonista()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, false, false, true)).Returns("ENFJ");
            var personality = new Personality(mock.Object, true, false, false, true);
            var actual = personality.GetPersonality();
            var expected = "Protagonista";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDziałacz()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, false, false, false)).Returns("ENFP");
            var personality = new Personality(mock.Object, true, false, false, false);
            var actual = personality.GetPersonality();
            var expected = "Działacz";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckLogistyk()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, true, true, true)).Returns("ISTJ");
            var personality = new Personality(mock.Object, false, true, true, true);
            var actual = personality.GetPersonality();
            var expected = "Logistyk";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckObrońca()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, true, false, true)).Returns("ISFJ");
            var personality = new Personality(mock.Object, false, true, false, true);
            var actual = personality.GetPersonality();
            var expected = "Obrońca";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDoradca()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, false, true)).Returns("ESFJ");
            var personality = new Personality(mock.Object, true, true, false, true);
            var actual = personality.GetPersonality();
            var expected = "Doradca";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckWirtuoz()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, true, true, false)).Returns("ISTP");
            var personality = new Personality(mock.Object, false, true, true, false);
            var actual = personality.GetPersonality();
            var expected = "Wirtuoz";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckPoszukiwaczPrzygód()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, true, false, false)).Returns("ISFP");
            var personality = new Personality(mock.Object, false, true, false, false);
            var actual = personality.GetPersonality();
            var expected = "Poszukiwacz przygód";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckPrzedsiębiorca()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, true, false)).Returns("ESTP");
            var personality = new Personality(mock.Object, true, true, true, false);
            var actual = personality.GetPersonality();
            var expected = "Przedsiębiorca";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckAnimator()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, false, false)).Returns("ESFP");
            var personality = new Personality(mock.Object, true, true, false, false);
            var actual = personality.GetPersonality();
            var expected = "Animator";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NegativeTest()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, false, false)).Returns("");
            var personality = new Personality(mock.Object, true, true, false, false);
            Assert.Throws<Exception>(() => personality.GetPersonality());
        }
    }
}
