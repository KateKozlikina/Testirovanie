﻿using System;
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
    }

}