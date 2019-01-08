using System;
using Ingredients;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PizzaTests
{
    [TestClass]
    public class DoughTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception), "Weight can't be negative")]
        public void ShouldThrowExceptionsOnUnknownWrongWeightInput()
        {
            // Arrange & Act & Assert
            var dough = new Dough(-20, "chewy", "white");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Pizza can't be that small, try weighs above 50g!")]
        public void ShouldThrowExceptionsOnWrongWeightInputBelow()
        {
            // Arrange & Act & Assert
            var dough = new Dough(35, "chewy", "white");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "This Pizza seems too big, try something below 400g!")]
        public void ShouldThrowExceptionsOnWrongWeightInputAbove()
        {
            // Arrange & Act & Assert
            var dough = new Dough(927, "chewy", "white");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Unknown baking technique, try 'Chewy' or 'Crispy'!")]
        public void ShouldThrowExceptionsOnUnknownbakingTechnique()
        {
            // Arrange & Act & Assert
            var dough = new Dough(927, "kacke", "white");
        }


        [TestMethod]
        public void ShouldCalculateProperCalories()
        {
            // Arrange
            var dough = new Dough(250, "crispy", "white");
            var expectedCalories = 675;
            
            // Act
            var caloriesResult = dough.GetDoughCalories();

            // Assert
            Assert.AreEqual(expectedCalories, caloriesResult);
        }
    }
}
