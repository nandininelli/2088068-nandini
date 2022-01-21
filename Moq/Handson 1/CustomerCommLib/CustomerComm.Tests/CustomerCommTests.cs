
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks; 
using NUnit.Framework;
using Moq;
using CustomeCommLib;

namespace CustomerCommLibTests
{
    [TestFixture]
    public class CustomerCommLibTests{
        [Test]
        public void Test1()
        {
            Mock<IMailSender>moqob= new Mock<IMailSender>();
            moqob.Setup(m => m.SendMail("customer234@abc.com","Message")).Returns(true);
            CustomeCommLib.CustomeComm cust = new CustomeCommLib.CustomeComm(moqob.Object); 
            bool result = cust.SendMailToCustomer();
            Assert.AreEqual(true, result);
        }
    }
}

