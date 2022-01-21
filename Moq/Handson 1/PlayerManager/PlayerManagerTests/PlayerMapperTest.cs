using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using PlayerManager;

namespace PlayerManagerTests
{
    [TestFixture]
    public class PlayerMapperTest
    {
        [Test]
        public void EmptyTest()
        {
            var moq = new Mock<IPlayerMapper>();
            Player player = Player.RegisterNewPlayer("PlayerMapperTest", moq.Object);
        }
        [Test]
        public void AlreadyExistsTest()
        {
            var moq = new Mock<IPlayerMapper>();
            moq.Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(false);
            Player player = Player.RegisterNewPlayer("Test", moq.Object);
            Assert.AreEqual("Test", player.Name);
            Assert.AreEqual(23, player.Age);
            Assert.AreEqual(30, player.NoOfMatches);
        }
    }
}

