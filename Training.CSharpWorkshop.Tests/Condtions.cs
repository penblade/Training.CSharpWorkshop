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
    }
}
