﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Convert_TDD;
namespace TestConvert
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConvert()
        {
            Converter converter = new Converter();
            Assert.IsNotNull(converter);
        }
        [TestMethod]
        public void TestMetrToMile()
        {
            Converter converter = new Converter();
            var value = converter.MetrToMile(100000);
            Assert.AreEqual(62.14, value);
        }

        [TestMethod]
        public void MileToMetr()
        {
            Converter converter = new Converter();
            var value = converter.MileToMetr(100);
            double res = 100 / 0.0006214;
            Assert.AreEqual(res, value);
        }

        [TestMethod]
        public void MetrToFt()
        {
            Converter converter = new Converter();
            var value = converter.MetrToFt(100);
            double res = 100 * 3.281;
            Assert.AreEqual(res, value);
        }

    }
}
