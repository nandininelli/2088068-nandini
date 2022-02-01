using NUnit.Framework;
using System.IO;
using System;
using MyFoodSupply;

namespace SupplyDetailsTest
{
    class SupplyDetailsTests
    {
        Program obj = new Program();


        [TestCase(2, "12/10/2022", "Aara", 23.22)]
        [TestCase(10, "12/11/2022", "Arun", 45)]
        public void CartonObjectCreation(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetails food = obj.CreateFoodDetail("Ice Cream", 2, DateTime.Parse("12/12/2022"), 21000.00);
            Assert.DoesNotThrow(() => obj.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, food));

        }

        [TestCase(-2, "12/10/2021", "John", 23.22)]
        [TestCase(-10, "12/11/2021", "Loly", 45)]
        public void LessThanZeroFoodItemCount(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetails food = obj.CreateFoodDetail("Ice Cream", 2, DateTime.Parse("12/12/2022"), 21000.00);

            var ex = Assert.Throws<Exception>(() => obj.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, food));
            Assert.That(ex.Message, Is.EqualTo("Incorrect food item count. Please check"));
        }

        [TestCase(2, "12/10/2023", "Ram", 23.22)]
        [TestCase(10, "12/11/2023", "Abhi", 45)]
        public void RequestDateValidity(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetails food = obj.CreateFoodDetail("Ice Cream", 2, DateTime.Parse("12/12/2022"), 21000.00);

            var ex = Assert.Throws<Exception>(() => obj.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, food));
            Assert.That(ex.Message, Is.EqualTo("Request date greater than expiry date. Please check"));
        }

        [TestCase(2, "12/10/2021", "Sam", 23.22)]
        [TestCase(10, "12/11/2021", "Ram", 45)]
        public void NullSupplyObject(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            Assert.AreEqual(obj.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, null), null);
        }


    }
}
