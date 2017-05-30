using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training.CSharpWorkshop.Tests
{
    [TestClass]
    public class ForLoops
    {
        [TestMethod]
        public void ForContinueBreakTest()
        {
            // Arrange
            var list = new List<string>();

            list.Add("Andrew");
            list.Add("Dave");
            list.Add("Don");
            list.Add("Mike");
            list.Add("Sam");
            list.Add("Vidya");

            var expected = "Andrew, Don";

            // Act
            var actual = String.Empty;

            // Single letters typically represent indexes
            // i, j, k are the most common used in that order.

            for (var i = 0; i < list.Count; i++)
            {
                // Do not process this loop any further and continue to the next.
                if (list[i] == "Dave") continue;
                if (list[i] == "Mike") continue;

                // Do not process this loop any further and exit the while loop
                // regardless if the condition is met or not.
                if (list[i] == "Sam") break;

                actual += list[i] + ", ";
            }

            actual = actual.Trim();
            actual = actual.TrimEnd(',');

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
