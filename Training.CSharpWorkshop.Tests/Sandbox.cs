using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training.CSharpWorkshop.Tests
{
    [TestClass]
    public class Sandbox
    {
        [TestMethod()]
        public void AdditionTest()
        {
            // Arrange
            var number1 = 1;
            var number3 = 3;
            var expected = 4;

            // Act
            var actual = number1 + number3;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
