using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            // Arrange
            double f = 32;
            double c = 0;
            // Act
            double result = _sut.f2c(f);
            // Assert
            // (expected , received)
            Assert.AreEqual(c, result);

        }

    }

}
