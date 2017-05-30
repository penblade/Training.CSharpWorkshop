using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training.CSharpWorkshop.Tests
{
    [TestClass]
    public class EnumTest
    {
        [TestMethod]
        public void AdminUserPermissions()
        {
            // Arrange
            var repository = new Repository();
            var expectedName = "Andrew";
            var expectedCanInsert = true;
            var expectedCanDelete = true;
            var expectedCanFind = true;

            // Act
            var actual = repository.Find("Andrew");

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedName, actual.Name);
            Assert.AreEqual(expectedCanInsert, actual.CanInsert());
            Assert.AreEqual(expectedCanDelete, actual.CanDelete());
            Assert.AreEqual(expectedCanFind, actual.CanFind());
        }

        [TestMethod]
        public void GuestUserPermissions()
        {
            // Arrange
            var repository = new Repository();
            var expectedName = "Dave";
            var expectedCanInsert = false;
            var expectedCanDelete = false;
            var expectedCanFind = true;

            // Act
            var actual = repository.Find("Dave");

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedName, actual.Name);
            Assert.AreEqual(expectedCanInsert, actual.CanInsert());
            Assert.AreEqual(expectedCanDelete, actual.CanDelete());
            Assert.AreEqual(expectedCanFind, actual.CanFind());
        }
    }
}
