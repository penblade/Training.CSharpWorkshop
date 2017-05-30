using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training.CSharpWorkshop.Tests
{
    [TestClass]
    public class WhileLoops
    {
        [TestMethod]
        public void WhileTest()
        {
            // Arrange
            var list = new List<string>();

            list.Add("Andrew");
            list.Add("Dave");
            list.Add("Don");
            list.Add("Mike");
            list.Add("Sam");
            list.Add("Vidya");

            var expected = "Andrew, Dave, Don, Mike, Sam, Vidya";

            // Act
            var actual = String.Empty;

            // Single letters typically represent indexes
            // i, j, k are the most common used in that order.
            var i = 0;

            while (i < list.Count)
            {
                actual += list[i] + ", ";
                i++;
            }

            actual = actual.Trim();
            actual = actual.TrimEnd(',');

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhileContinueBreakTest()
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
            var i = 0;

            while (i < list.Count)
            {
                // Do not process this loop any further and continue to the next.
                if (list[i] == "Dave")
                {
                    i++;
                    continue;
                }
                if (list[i] == "Mike")
                {
                    i++;
                    continue;
                }

                // Do not process this loop any further and exit the while loop
                // regardless if the condition is met or not.
                if (list[i] == "Sam") break;

                actual += list[i] + ", ";
                i++;
            }

            actual = actual.Trim();
            actual = actual.TrimEnd(',');

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
