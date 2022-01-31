using NUnit.Framework;
using System.IO;
using System;
using MyFoodSupply;

namespace FoodDetailTesting
{
    [TestFixture]
    class FoodItemTests
    {
        Program obj = new Program();


        [TestCase("Ababa", 2, "12/12/2022", 23.23)]
        [TestCase("Cenima", 2, "12/10/2022", 21000.00)]
        public void FoodItemObjectCreation(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.DoesNotThrow(() => obj.CreateFoodDetail(name, dishType, expiryDate, price));
        }


        [TestCase("", 2, "12/12/2021", 23.23)]
        [TestCase("", 2, "12/10/2021", 21000.00)]
        public void EmptyNameException(string name, int dishType, DateTime expiryDate, double price)
        {

            var ex = Assert.Throws<Exception>(() => obj.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.That(ex.Message, Is.EqualTo("Dish name cannot be empty. Please provide valid value"));
        }

        [TestCase("ababa", 2, "12/12/2021", -0.00001)]
        [TestCase("cenima", 2, "12/10/2021", -10000)]
        public void NegativePriceExceptionTest(string name, int dishType, DateTime expiryDate, double price)
        {

            var ex = Assert.Throws<Exception>(() => obj.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.That(ex.Message, Is.EqualTo("Incorrect value for dish price. Please provide valid value"));
        }

        [TestCase("ababa", 2, "12/12/2020", 200)]
        [TestCase("cenima", 2, "12/10/2000", 22.22)]
        public void ExpiryDateTest(string name, int dishType, DateTime expiryDate, double price)
        {

            var ex = Assert.Throws<Exception>(() => obj.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.That(ex.Message, Is.EqualTo("Incorrect expiry date. Please provide valid value"));
        }

    }
}
