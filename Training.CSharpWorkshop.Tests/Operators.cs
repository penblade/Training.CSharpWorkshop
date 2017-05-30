using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training.CSharpWorkshop.Tests
{
    [TestClass]
    public class Operators
    {
        [TestMethod]
        // Equal (==), NotEqual (!=), Remainder (%)
        // GreaterThan (>), GreaterThanOrEqual (>=),
        // LessThan (<), LessThanOrEqual (<=).
        public void Equal()
        {
            // Arrange
            var number = 1;

            // Act
            var actual = number == 1;

            // Assert
            Assert.IsTrue(actual);
        }
    }
}
