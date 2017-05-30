using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training.CSharpWorkshop.Tests
{
    [TestClass]
    public class PolymorphismTest
    {
        [TestMethod]
        public void AdminMethodTest()
        {
            // Arrange
            var repository = new Repository();
            var expectedName = "Andrew";

            // Act
            var actual = repository.Find("Andrew");

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedName, actual.Name);

            // Verify the type of object is an AdminUser.
            Assert.AreEqual(typeof(AdminUser), actual.GetType());

            // Cast User object to AdminUser.
            AdminUser admin;

            // Will throw an exception if not the correct type.
            admin = (AdminUser)actual;
            Assert.IsTrue(admin.AdminMethodOnly());

            // Will change admin to null if not the correct type.
            admin = actual as AdminUser;
            Assert.IsTrue(admin.AdminMethodOnly());
        }

        [TestMethod]
        public void GuestMethodTest()
        {
            // Arrange
            var repository = new Repository();
            var expectedName = "Dave";

            // Act
            var actual = repository.Find("Dave");

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedName, actual.Name);

            // Verify the type of object is an GuestUser.
            Assert.AreEqual(typeof(GuestUser), actual.GetType());

            // Cast User object to GuestUser.
            GuestUser guest;

            // Will throw an exception if not the correct type.
            guest = (GuestUser)actual;
            Assert.IsTrue(guest.GuestMethodOnly());

            // Will change admin to null if not the correct type.
            guest = actual as GuestUser;
            Assert.IsTrue(guest.GuestMethodOnly());
        }
    }
}
