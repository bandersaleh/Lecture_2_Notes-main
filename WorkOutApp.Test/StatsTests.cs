using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lecture_2_Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOutApp.Test
{
    [TestClass()]
    public class StatsTests
    {
        // Arrange
        // Act
        // Assert
        Stats _stats;

        public StatsTests()
        {
            _stats = new Stats();
        }



        [TestMethod()]
        public void StatsTest()
        {
            // Arrange
            int expectedCalories = 0;
            int actualCalories = _stats.CaloriesBurned;

            // Assert
            Assert.AreEqual(expectedCalories, actualCalories);
        }

        [TestMethod()]
        public void IncreaseDaysTest()
        {
            // Arrange
            int expected = _stats.DaysWorkedout + 1;

            // Act
            _stats.IncreaseDays();
            int actual = _stats.DaysWorkedout;

            // Assert
            Assert.AreEqual(expected, actual);


        }
    }
}