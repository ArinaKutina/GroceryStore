using Microsoft.VisualStudio.TestTools.UnitTesting;
using GroceryStoreClassLibrary;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double test1;
            ProductCountingClass productCounting = new ProductCountingClass();
            test1 = productCounting.ProductPriceCounting();

            Assert.IsNotNull(test1);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double? test2 = 80;
            ProductCountingClass productCounting = new ProductCountingClass();
            test2 = productCounting.ProductDiscountCounting(100, 0.2);

            Assert.AreEqual(80, test2);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double? test3;
            ProductCountingClass productCounting = new ProductCountingClass();
            test3 = productCounting.ProductNoDiscountCounting();

            Assert.IsNotNull(test3);
        }
    }
}
