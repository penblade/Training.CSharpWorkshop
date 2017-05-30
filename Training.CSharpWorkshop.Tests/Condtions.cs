using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training.CSharpWorkshop.Tests
{
    [TestClass]
    public class Condtions
    {
        [TestMethod]
        public void IfTest()
        {
            // Arrange
            var userId = 1;
            var expected = "Andrew";

            // Act
            string actual = String.Empty;
            if (userId == 1)
            {
                actual = "Andrew";
            }

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IfElseTest()
        {
            // Arrange
            var userId = 2;
            var expected = "UserDoesNotExist";

            // Act
            string actual = String.Empty;
            if (userId == 1)
            {
                actual = "Andrew";
            }
            else
            {
                actual = "UserDoesNotExist";
            }

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IfElseIfElseTest()
        {
            // Arrange
            var userId = 2;
            var expected = "Dave";

            // Act
            string actual = String.Empty;
            if (userId == 1)
            {
                actual = "Andrew";
            }
            else if (userId == 2)
            {
                actual = "Dave";
            }
            else
            {
                actual = "UserDoesNotExist";
            }

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SwitchTest()
        {
            // Arrange
            var userId = 2;
            var expected = "Dave";

            // Act
            string actual = String.Empty;
            switch (userId)
            {
                case 1:
                    actual = "Andrew";
                    break;

                case 2:
                    actual = "Dave";
                    break;

                default:
                    actual = "UserDoesNotExist";
                    break;
            }

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
