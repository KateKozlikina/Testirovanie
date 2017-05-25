using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvertTDD;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

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
        public void TestMileToMetr()
        {
            Converter converter = new Converter();
            var value = converter.MileToMetr(100);
            double res = 100 / 0.0006214;
            Assert.AreEqual(res, value);
        }

        [TestMethod]
        public void TestMetrToFt()
        {
            Converter converter = new Converter();
            var value = converter.MetrToFt(100);
            double res = 100 * 3.281;
            Assert.AreEqual(res, value);
        }

        [TestMethod]
        public void TestFtToMetr()
        {
            Converter converter = new Converter();
            var value = converter.FtToMetr(100);
            double res = 100 / 3.281;
            Assert.AreEqual(res, value);
        }
        [TestMethod]
        public void TestMileToFt()
        {
            Converter converter = new Converter();
            var value = converter.MileToFt(100);
            double res = 100 * 5280;
            Assert.AreEqual(res, value);
        }
    }

}
