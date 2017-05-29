using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training.CSharpWorkshop.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [Ignore]
        [TestMethod]
        public void ProcessTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetRoleMessageTest()
        {
            // Arrange
            var userName = "Andrew";
            var expected = "Role: Admin.";

            // Act
            var actual = Program.GetRoleMessage(userName);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
