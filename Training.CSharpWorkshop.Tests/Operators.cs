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

        [TestMethod]
        // BitwiseOr (|), LogicalOr (||).
        public void LogicalOr()
        {
            // Arrange
            var number = 1;
            var text = "file";

            // Act

            // BitwiseOr: Both cases will be compared.
            // var actual = number == 1 | text == "folder";

            // If the first case is true, only the first case will be compared.
            // This is considered a short-circuit evaluation.
            var actual = number == 1 || text == "folder";

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        // Addition (+), Subtraction (-), Multiplication (*), and Division (/)
        // Parentheses are honored.
        // Strings can also be concatenated,
        // however, String.Format is typically recommended instead.
        public void Addition()
        {
            // Arrange
            var number1 = 1;
            var number2 = 2;

            // Act
            var actual = number1 + number2;

            // Assert
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        // Assignments (+=, -=, *=, /=).
        public void AdditionAssignment()
        {
            // Arrange
            var number1 = 1;
            var number2 = 2;

            // Act
            number1 += number2;

            // Assert
            Assert.AreEqual(3, number1);
        }

        [TestMethod]
        // IncrementPrefix  (++i) add 1 before assignment
        // IncrementPostfix (i++) add 1 after assignment
        // DecrementPrefix  (--i) subtract 1 before assignment
        // DecrementPostfix (i--) subtract 1 after assignment
        public void IncrementPostfix()
        {
            // Arrange
            var count = 0;

            // Act
            var actual = count++;

            // Assert
            Assert.AreEqual(0, actual);
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void Conditional()
        {
            // Arrange
            string item = null;

            // Act
            // actual = item is not null ?
            //          if true return item :
            //          else return an empty string.
            var actual = item != null ? item : String.Empty;

            // Assert
            Assert.AreEqual(String.Empty, actual);
        }
    }
}
