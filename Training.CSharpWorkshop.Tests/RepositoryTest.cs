using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training.CSharpWorkshop.Tests
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void GetUserByNameForUserInTheList()
        {
            // Arrange
            var repository = new Repository();
            var expectedId = 0;
            var expectedName = "Andrew";

            // Act
            var actual = repository.GetUserByName("Andrew");

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedId, actual.Id);
            Assert.AreEqual(expectedName, actual.Name);
        }

        [TestMethod]
        public void GetUserByNameForUserNotInTheList()
        {
            // Arrange
            var repository = new Repository();

            // Act
            var actual = repository.GetUserByName("Don");

            // Assert
            Assert.IsNull(actual);
        }
    }
}
