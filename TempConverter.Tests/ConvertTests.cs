using Microsoft.VisualStudio.TestTools.UnitTesting;
using TempConverter;

namespace TempConverter.Tests
{
    [TestClass]
    public class ConvertTests
    {
        private readonly Converters _sut;

        public ConvertTests()
        {
            _sut = new Converters();
        }

        [TestMethod]
        public void Check_F2C()
        {
            double f = 32;
            double expected = 0;
            double result = _sut.f2c(f);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Check_C2F()
        {
            double c = 0;
            double expected = 32;
            double result = _sut.c2f(c);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Check_K2C()
        {
            double k = 273.15;
            double expected = 0;
            double result = _sut.k2c(k);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Check_CToText_Cold()
        {
            double c = 5;
            string expected = "Cold";
            string result = _sut.cToText(c);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Check_CToText_Varm()
        {
            double c = 15;
            string expected = "Warm";
            string result = _sut.cToText(c);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Check_CToText_Hot()
        {
            double c = 25;
            string expected = "Hot";
            string result = _sut.cToText(c);
            Assert.AreEqual(expected, result);
        }
    }
}
