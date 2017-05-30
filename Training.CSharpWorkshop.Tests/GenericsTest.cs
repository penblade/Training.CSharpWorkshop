using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training.CSharpWorkshop.Tests
{
    [TestClass]
    public class GenericsTest
    {
        [TestMethod]
        public void FindUserInTheList()
        {
            // Arrange
            var repository = new Repository();
            var expectedId = 0;
            var expectedName = "Andrew";

            // Act
            var actual = repository.Find("Andrew");

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedId, actual.Id);
            Assert.AreEqual(expectedName, actual.Name);
        }

        [TestMethod]
        public void FindUserNotInTheList()
        {
            // Arrange
            var repository = new Repository();

            // Act
            var actual = repository.Find("Don");

            // Assert
            Assert.IsNull(actual);
        }

        [TestMethod()]
        public void InsertTest()
        {
            // Arrange
            var repository = new Repository();
            var expectedId = 42;
            var expectedName = "Jon";

            // Act
            repository.Insert(new User()
            {
                Id = 42,
                Name = "Jon"
            });

            var actual = repository.Find("Jon");

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedId, actual.Id);
            Assert.AreEqual(expectedName, actual.Name);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            // Arrange
            var repository = new Repository();

            // Act
            var user = repository.Find("Andrew");
            repository.Delete(user);

            var actual = repository.Find("Andrew");

            // Assert
            Assert.IsNull(actual);
        }
    }
}
