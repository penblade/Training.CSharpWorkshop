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

        [TestMethod]
        // BitwiseAnd (&), LogicalAnd (&&).
        public void LogicalAnd()
        {
            // Arrange
            var number = 1;
            var text = "file";

            // Act

            // BitwiseAnd: Both cases will be compared.
            // var actual = number == 0 & text == "file";

            // If the first case is false, only the first case will be compared.
            // This is considered a short-circuit evaluation.
            var actual = number == 0 && text == "file";

            // Assert
            Assert.IsFalse(actual);
        }
    }
}
