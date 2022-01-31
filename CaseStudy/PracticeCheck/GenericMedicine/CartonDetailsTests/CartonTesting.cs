
using NUnit.Framework;
using System.IO;
using System;
using GenericMedicine;
    
    namespace CartonDetailsTests
{
    [TestFixture]
    public class CartonTesting
    {
        Program obj = new Program();
        [TestCase(3, "12/23/2023", "sagarnagar-3/8, pedagantyada")]
        [TestCase(1009, "12/26/2023", "hbcolony-13/13B, Godduvanipalem")]
        public void CartonObjectCreation(int medicineStripCount, DateTime launchDate, string retailerAddress, string genericMedicine)
        {
            Medicine med = obj.CreateMedicineDetail("abc-34983", "xyz-948903", "carbon iron", DateTime.Parse("12/12/2022"), 2.3);
            Assert.DoesNotThrow(() => obj.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, med));
        }
        [TestCase(-6, "12/23/2021", "Del-12/13c, Delhi")]
        [TestCase(-200, "12/23/2021", "Alt-flatno4, Dehadum")]
        public void LessThanZeroStripCount(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            Medicine med = obj.CreateMedicineDetail("abc-34983", "xyz-948903", "carbon iron", DateTime.Parse("12/12/2022"), 2.3); var ex = Assert.Throws<Exception>(() => obj.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, med));
            Assert.That(ex.Message, Is.EqualTo("Incorrect strip count. Please check"));
        }
        [TestCase(56, "12/23/2000", "BHPV-143/14c, dubai")]
        [TestCase(230, "12/23/1900", "RHColony-c07/abc, pune")]
        public void LaunchDateCheck(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            Medicine med = obj.CreateMedicineDetail("abc-34983", "xyz-948903", "carbon iron", DateTime.Parse("12/12/2022"), 2.3); var ex = Assert.Throws<Exception>(() => obj.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, med));
            Assert.That(ex.Message, Is.EqualTo("Incorrect launch date. Please provide valid value"));
        }
        [TestCase(4, "12/23/2022", "Agar-133/16c, Kolkatha")]
        [TestCase(8, "12/23/2022", "ghvnagar-283/abc, bangloe")]
        public void NullCartonObject(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            Assert.AreEqual(obj.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, null), null);
        }
    }
}

