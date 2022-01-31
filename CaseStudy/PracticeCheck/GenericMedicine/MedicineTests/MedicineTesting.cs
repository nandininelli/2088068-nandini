
using NUnit.Framework;
using System.IO;
using System;
using GenericMedicine;

namespace MedicineTests

{
    [TestFixture]
    public class MedicineTests
    {
        Program obj = new Program();
        [SetUp]
        public void Setup()
        { }
        [TestCase("Ali", " Cytrin LC", "potassium", "12/12/2022", 2314)]
        [TestCase("Ali", "Sardon 650", "sodium", "02/10/2022", 2.3)]
        public void MedicineObjectCreation(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Assert.DoesNotThrow(() => obj.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
        }
        [TestCase("Sam", " Lambodd LC", "carbon iron", "02/10/2022", 2.3)]
        [TestCase("Sam", "Dolo 650", "carbon", "02/10/2023", 24)]
        public void EmptyNameException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            var ex = Assert.Throws<Exception>(() => obj.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.That(ex.Message, Is.EqualTo("Medicine name cannot be empty. Please provide valid value"));
        }
        [TestCase("mehri", " Terbinife", "carbon iron", "02/10/2022", -2)]
        [TestCase("mehri", "Doxycycline", "calcium", "02/10/2023", -24)]
        public void LessThanZeroPriceException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            var ex = Assert.Throws<Exception>(() => obj.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.That(ex.Message, Is.EqualTo("Incorrect value for Medicine price per strip. Please provide valid value"));
        }
        [TestCase("kali", " Montair LC", "carbon iron", "02/10/2020", 2.3)]
        [TestCase("Kali", "Doxycycline", "carbon", "02/12/1900", 24)]
        public void ExpriyDateCheck(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            var ex = Assert.Throws<Exception>(() => obj.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.That(ex.Message, Is.EqualTo("Incorrect expiry date. Please provide valid value"));
        }
    }
}

