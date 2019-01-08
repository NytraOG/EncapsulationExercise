using System;
using Ingredients;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PizzaTests
{
    [TestClass]
    public class ToppingTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception), "The topping's weight can't be zero or negative")]
        public void ShouldThrowExceptionOnWeightBelowZero()
        {
            // Arrange & Act & Assert
            var topping = new Topping(-50, "meat");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "You might have too many toppings on your pizza, try something below 50g!")]
        public void ShouldThrowExceptionOnWeightAboveFifty()
        {
            // Arrange & Act & Assert
            var topping = new Topping(100, "meat");
        }

        [TestMethod]
        public void ShouldCalculateCalories()
        {
            // Arrange
            var topping = new Topping(35, "veggies");
            const int expectedCalories = 56;

            // Act
            var caloriesResult = topping.GetToppingCalories();

            // Assert
            Assert.AreEqual(expectedCalories, caloriesResult);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Cannot place Kackwurst on top of your pizza!")]
        public void ShouldThrowExceptionOnUnknownToppingInput()
        {
            // Arrange & Act & Assert
            var topping = new Topping(40, "Kackwurst");
        }
    }
}
