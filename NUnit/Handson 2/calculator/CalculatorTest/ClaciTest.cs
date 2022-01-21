
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using calculator;
using System.Collections;
namespace CalculatorTest
{
    [TestFixture]
    public class calciTest
    {
        calci calculator;
        [SetUp]
        public void Initialize()
        {
            calculator = new calci();
        }
        [TearDown]
        public void Cleanup()
        {
            calculator = null;
        }
        [Test]
        public void AddTest()
        {
            
            int input1 = 100;
            int input2 = 200;
            int expected = 300;
            int actual = calculator.Add(input1, input2); 
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SubstractTest()
        {
            
            int input1 = 200;
            int input2 = 100;
            int expected = 100; 
            int actual = calculator.Substract(input1, input2);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [Ignore("Divide not yet implemented")]
        public void DivideTest()
        { }
        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(8, 2, 10)]
        [TestCase(9, 3, 12)]
        public void AddTest1(int input1, int input2, int expected)
        {
            int actual = calculator.Add(input1, input2);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCaseSource("AddTestData")]
        public void AddTest2(int input1, int input2, int expected)
        {
            int actual = calculator.Add(input1, input2);
            Assert.AreEqual(expected, actual);
        }
        public static object[] AddTestData =
      {
new object[] { 1, 2, 3 },
new object[] { 10, 20, 30 },
new object[] { 5, 3, 8 }
};
        [Test]
        [TestCase(3, 2, 1)]
        [TestCase(8, 2, 6)]
        [TestCase(9, 3, 6)]
        public void SubTest1(int input1, int input2, int expected)
        {
            int actual = calculator.Substract(input1, input2);
            Assert.AreEqual(expected, actual);
        }
        public void MultiplyTest()
        {
            int input1 = 20;
            int input2 = 10;
            int expected = 200;
            int actual = calculator.Multiply(input1, input2);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(3, 2, 6)]
        [TestCase(10, 2, 20)]
        [TestCase(5, 3, 15)]
        public void MultiplyTest1(int input1, int input2, int expected)
        {
            int actual = calculator.Multiply(input1, input2);
            Assert.AreEqual(expected, actual);
        }
        public void DivisionTest()
        {
            double input1 = 20;
            double input2 = 10;
            double expected = 2;
            double actual = calculator.Division(input1, input2);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(6, 3, 2)]
        [TestCase(10, 2, 5)]
        [TestCase(15, 3, 5)]
        public void DivisionTest1(int input1, int input2, int expected)
        {
            try
            {


                double actual = calculator.Division(input1, input2);
                Assert.AreEqual(expected, actual);

            }
            catch(ArgumentException exp)
            {
                Assert.Fail("Divide by Zero");
            }
            
        }
    }
}


