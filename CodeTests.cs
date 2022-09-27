using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;
using System.Linq;
using Moq;

namespace MyTests
{
    internal class CodeTests
    {
        Code code;

        [SetUp] //16
        public void Setup()
        {
            code = new Code(); 
            Assert.IsInstanceOf(typeof(Code), code);
        }

        #region ext
        [Test]
        public void CheckESTJ()
        {
            var actual = code.GenerateCode(true, true, true, true);
            var expected = "ESTJ";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckESTP()
        {
            var actual = code.GenerateCode(true, true, true, false);
            var expected = "ESTP";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckESFP()
        {
            var actual = code.GenerateCode(true, true, false, false);
            var expected = "ESFP";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckESFJ()
        {
            var actual = code.GenerateCode(true, true, false, true);
            var expected = "ESFJ";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckENFP()
        {
            var actual = code.GenerateCode(true, false, false, false);
            var expected = "ENFP";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckENTP()
        {
            var actual = code.GenerateCode(true, false, true, false);
            var expected = "ENTP";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckENTJ()
        {
            var actual = code.GenerateCode(true, false, true, true);
            var expected = "ENTJ";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckENFJ()
        {
            var actual = code.GenerateCode(true, false, false, true);
            var expected = "ENFJ";
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region int

        [Test]
        public void CheckINFP()
        {
            var actual = code.GenerateCode(false, false, false, false);
            var expected = "INFP";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckINFJ()
        {
            var actual = code.GenerateCode(false, false, false, true);
            var expected = "INFJ";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckINTJ()
        {
            var actual = code.GenerateCode(false, false, true, true);
            var expected = "INTJ";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckISTJ()
        {
            var actual = code.GenerateCode(false, true, true, true);
            var expected = "ISTJ";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckISTP()
        {
            var actual = code.GenerateCode(false, true, true, false);
            var expected = "ISTP";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckINTP()
        {
            var actual = code.GenerateCode(false, false, true, false);
            var expected = "INTP";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckISFP()
        {
            var actual = code.GenerateCode(false, true, false, false);
            var expected = "ISFP";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckISFJ()
        {
            var actual = code.GenerateCode(false, true, false, true);
            var expected = "ISFJ";
            Assert.AreEqual(expected, actual);
        }

        #endregion

    }
}
