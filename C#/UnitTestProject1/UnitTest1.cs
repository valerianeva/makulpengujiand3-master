using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void jumlah()
        {
            var test_object = new MainWindow();
            double expected = 9;
            double actual = test_object.Add(4, 5);
            Assert.AreEqual<double>(expected, actual, "Maaf salah");
        }

        [TestMethod]
        public void kurang()
        {
            var test_object = new MainWindow();
            double expected = 2;
            double actual = test_object.Substract(5, 3);
            Assert.AreEqual<double>(expected, actual, "Maaf salah");
        }

        [TestMethod]
        public void bagi()
        {
            var test_object = new MainWindow();
            double expected = 3;
            double actual = test_object.Divide(9, 3);
            Assert.AreEqual<double>(expected, actual, "Maaf salah");
        }

        [TestMethod]
        public void kali()
        {
            var test_object = new MainWindow();
            double expected = 6;
            double actual = test_object.Multiply(3, 2);
            Assert.AreEqual<double>(expected, actual, "Maaf salah");
        }
    }
}
