using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training.CSharpWorkshop.Tests
{
    [TestClass]
    public class Exceptions
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "User does not exist")]
        public void ThrowExceptionTest()
        {
            // Arrange
            var userId = 3;

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
                    throw new ArgumentException("User does not exist");
            }
        }

        [TestMethod]
        public void TryCatchTest()
        {
            // Arrange
            var userId = 2;
            var expected = "Dave";

            // Act
            string actual = String.Empty;

            try
            {
                switch (userId)
                {
                    case 1:
                        actual = "Andrew";
                        break;

                    case 2:
                        actual = "Dave";
                        break;

                    default:
                        throw new ArgumentException("User does not exist");
                }
            }

            // Assert
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TryCatchFinallyTest()
        {
            // Arrange
            var userId = 2;
            var finallyWasReached = false;

            var expected = "Dave";
            var expectedFinallyWasReached = true;

            // Act
            string actual = String.Empty;

            try
            {
                switch (userId)
                {
                    case 1:
                        actual = "Andrew";
                        break;

                    case 2:
                        actual = "Dave";
                        break;

                    default:
                        throw new ArgumentException("User does not exist");
                }
            }

            // Assert
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            finally
            {
                finallyWasReached = true;
            }

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedFinallyWasReached, finallyWasReached);
        }
    }
}
