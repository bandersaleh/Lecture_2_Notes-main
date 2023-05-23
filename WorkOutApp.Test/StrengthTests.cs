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
    public class StrengthTests
    {
        Strength _strength;

        public StrengthTests()
        {
            _strength = new Strength();
        }



        [TestMethod()]
        public void SetWeightTest()
        {
            // Arrange
            float initialWeight = _strength.Weight;
            float addedWeight = 5.0f;
            float expectedWeight = addedWeight;

            // Act
            _strength.SetWeight(addedWeight);

            float actualWeight = _strength.Weight;

            // Assert
            Assert.AreEqual(expectedWeight, actualWeight);
        }

        [TestMethod()]
        public void IncreaseWeightTest()
        {
            // Arrange
            float originalWeight = _strength.Weight;
            float expectedWeight = _strength.Weight + 5;

            // Act
            _strength.IncreaseWeight();
            float actualWeight = _strength.Weight;

            // Assert
            Assert.AreEqual(expectedWeight, actualWeight);
        }

        [TestMethod()]
        public void IncreaseRepsTest()
        {
            // Arrange
            int expectedRep = _strength.Rep + 1;

            // Act
            _strength.IncreaseReps();
            float actualRep = _strength.Rep;

            // Assert
            Assert.AreEqual(expectedRep, actualRep);
        }
    }
}